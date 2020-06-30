using CompLab.Models.Entities;
using CompLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompLab
{
    public partial class RoomForm : Form
    {
        private Room _room;
        private string _root;
        private Form1 _form;
        public RoomForm(string root, Form1 form, Room room = null)
        {
            InitializeComponent();
            _room = room;
            _root = root;
            if (room != null)
                tbRoomNum.Text = room.Num;
            _form = form;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_room == null)
                FileHelper.CreateRoom(_root, new Room()
                {
                    Num = tbRoomNum.Text
                });
            else FileHelper.UpdateRoom(_root, _room.Num, tbRoomNum.Text);
            _form.FillData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
