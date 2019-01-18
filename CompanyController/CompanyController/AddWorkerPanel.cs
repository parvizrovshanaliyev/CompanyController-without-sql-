using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyController
{
    public partial class AddWorkerPanel : Form
    {
        public AddWorkerPanel()
        {
            InitializeComponent();
            dataGridViewAddWorker.DataSource = DataBase.Workers;
        }

        private void btnAddWorkerTolist_Click(object sender, EventArgs e)
        {

            var name = tbxName.Text;
            var surname = tbxSurname.Text;
            var work = tbxWork.Text;
            var pay = tbxPay.Text;
            var number = tbxNumber.Text;
            var email = tbxEmail.Text;
            var regdate = dateTimePickerRegister.Value;
            //var regdate = dtpicker.Value;
            //var date = txtRegisterDate;
            var worker = new Worker(name, surname, work, Convert.ToInt32(pay), Convert.ToInt32(number), email, regdate);

            DataBase.Workers.Add(worker);
            //DataBase.Workers.Add(new Worker(1, Parviz, Aliyev, Coder, Convert.ToInt32(1000), Convert.ToInt32(050 - 685 - 69 - 15), parvizra@codeeduaz, DateTime.Now))
            MessageBox.Show("New worker added");

            var upsource = new BindingSource();
            upsource.DataSource = DataBase.Workers;
            dataGridViewAddWorker.DataSource = upsource;
            
        }
    }
}
