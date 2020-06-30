using CompLab.Models.Collections;
using CompLab.Models.Entities;
using CompLab.Services;
using System;
using System.Windows.Forms;

namespace CompLab
{
    public partial class ComputerForm : Form
    {
        private string _path;
        private ComputerList _computerList;
        private Computer _computer;
        private Form1 _contextForm;
        public ComputerForm(string path, Form1 contextForm, ComputerList computerList, Computer computer = null)
        {
            InitializeComponent();
            _path = path;
            _contextForm = contextForm;
            _computerList = computerList;
            _computer = computer;
            if (computer != null)
            {
                labelId.Text = computer.Id.ToString();
                textBoxPrice.Text = computer.Price.ToString();
            }
            else
            {
                labelId.Text = Guid.NewGuid().ToString();
                textBoxPrice.Text = 0.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal price;
            try { price = decimal.Parse(textBoxPrice.Text); }
            catch
            {
                MessageBox.Show("Введите сумму числом");
                return;
            }

            if (_computer == null)
            {
                _computerList.Push(new Computer()
                {
                    Id = Guid.Parse(labelId.Text),
                    Price = price
                });
                FileHelper.CreateComputerList(_path, _computerList);
                _contextForm.FillData();
                Close();
            }
            else
            {
                _computer.Price = price;
                FileHelper.UpdateComputer(_path, _computer);
                _contextForm.FillData();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
