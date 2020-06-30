using CompLab.Models.Collections;
using CompLab.Models.Entities;
using CompLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompLab
{
    public partial class Form1 : Form
    {
        private string _root;

        private RoomQueue _rooms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _root = File.ReadAllText("path.txt");
            tbPath.Text = _root;
            FillData();
        }

        public void FillData()
        {
            if (string.IsNullOrEmpty(_root)) return;
            var indexBefore = dropDownRooms.SelectedIndex;
            dropDownRooms.Items.Clear();
            _rooms = FileHelper.ReadRooms(_root);
            foreach (Room room in _rooms)
                dropDownRooms.Items.Add(room.Num);
            if (_rooms.Length != 0)
                dropDownRooms.SelectedIndex = 0;
            if (indexBefore != -1 && _rooms.Length > indexBefore)
                dropDownRooms.SelectedIndex = indexBefore;
            FillComputerList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillComputerList();
        }

        private void FillComputerList()
        {
            listComputers.Items.Clear();
            var room = GetCurrentRoom();
            if (room == null) return;
            foreach (Computer computer in room.Computers)
                listComputers.Items.Add($"Табельный номер : {computer.Id}, баланс. стоимость : {computer.Price}");
            RefreshLabels();
        }
        private Room GetCurrentRoom()
        {
            var roomNum = dropDownRooms.SelectedItem?.ToString();
            if (roomNum == null) return null;
            foreach (Room room in _rooms)
                if (roomNum == room.Num)
                    return room;
            return null;
        }
        
        private Computer GetCurrentComputer()
        {
            var room = GetCurrentRoom();
            if (listComputers.SelectedIndex == -1 || room==null)
                return null;
            
            var selectedCompStr = listComputers.SelectedItem.ToString();
            var compId = Guid.Parse(selectedCompStr.Split(' ')[3].TrimEnd(','));
            return room.Computers[compId];
        }

        private void RefreshLabels()
        {
            var room = GetCurrentRoom();
            labelSumPrice.Text = room.ComputersSumPrice.ToString();
            labelCompCount.Text = room.Computers.Count.ToString();
        }
        #region RoomButtons
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var roomForm = new RoomForm(_root, this);
            roomForm.Show();
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            var room = GetCurrentRoom();
            if (room == null) return;
            var roomForm = new RoomForm(_root, this, room);
            roomForm.Show();
        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            var room = GetCurrentRoom();
            if (room == null) return;
            FileHelper.DeleteRoom(_root, room);
            FillData();
            MessageBox.Show("Кабинет успешно удален");
        }

        #endregion

        #region ComputerButtons
        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            var room = GetCurrentRoom();
            if (room == null) return;
            var compForm = new ComputerForm($"{_root}\\{room.Num}", this, room.Computers);
            compForm.Show();
        }

        private void btnEditComputer_Click(object sender, EventArgs e)
        {
            var computer = GetCurrentComputer();
            if (computer == null) return;
            var room = GetCurrentRoom();
            var compForm = new ComputerForm($"{_root}\\{room.Num}", this, room.Computers,computer);
            compForm.Show();
        }

        private void btnDeleteComputer_Click(object sender, EventArgs e)
        {
            var computer = GetCurrentComputer();
            var room = GetCurrentRoom();
            if (computer == null) return;
            FileHelper.DeleteComputer($"{_root}\\{room.Num}", computer);
            FillData();
            MessageBox.Show("Компьютер успешно удален");
        }
        #endregion

        private void btnPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var root = folderBrowserDialog1.SelectedPath;
            if (string.IsNullOrEmpty(root)) return;
            _root = root;
            tbPath.Text = _root;
            File.WriteAllText("path.txt", _root);
            FillData();
        }
    }
}
