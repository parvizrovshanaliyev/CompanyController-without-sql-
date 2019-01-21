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
    public partial class HourlPayCalcPanel : Form
    {
        public HourlPayCalcPanel()
        {
            InitializeComponent();
            dataGridViewSalaryCalc.DataSource = DataBase.Workers;
        }

        private void btnStartDate_Click(object sender, EventArgs e)
        {
            // CrazyMethod();
            DateTime startDate = DateTime.Now;
            lblstart.Text = startDate.ToString();
            int id = dataGridViewSalaryCalc.CurrentRow.Index + 1;
            // MessageBox.Show(id.ToString());

            foreach (var item in DataBase.Workers)
            {
                if (item.WorkerId == id)
                {
                    item.WorkerStartDate = startDate;
                   
                }
            }

            MessageBox.Show(startDate.ToString());

            ExtensionsClass.UpdateSources(dataGridViewSalaryCalc);
            //var upsource = new BindingSource();
            //upsource.DataSource = DataBase.Workers;
            //dataGridViewSalaryCalc.DataSource = upsource;

        }

        //private void CrazyMethod()
        //{
        //    DateTime startDate = DateTime.Now;
        //    DateTime exitDate = DateTime.Now;


        //    int id = Convert.ToInt32((dataGridViewSalaryCalc.CurrentRow.Index) + 1);
        //    // MessageBox.Show(id.ToString());

        //    foreach (var item in DataBase.Workers)
        //    {
        //        if (item.WorkerId == id)
        //        {
        //            item.WorkerStartDate = startDate;
        //            item.WorkerExitDate = exitDate;
        //        }
        //    }
        //}

        private void btnExitDate_Click(object sender, EventArgs e)
        {
            DateTime exitDate = dateTimePickerExit.Value;
            int id = Convert.ToInt32((dataGridViewSalaryCalc.CurrentRow.Index) + 1);
            // MessageBox.Show(id.ToString());

            foreach (var item in DataBase.Workers)
            {
                if (item.WorkerId == id)
                {
                   
                    item.WorkerExitDate = exitDate;
                }
            }
            MessageBox.Show(exitDate.ToString());

            ExtensionsClass.UpdateSources(dataGridViewSalaryCalc);

            //var upsource = new BindingSource();
            //upsource.DataSource = DataBase.Workers;
            //dataGridViewSalaryCalc.DataSource = upsource;
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dataGridViewSalaryCalc.CurrentRow.Index) + 1);
            // MessageBox.Show(id.ToString());
            int money = Convert.ToInt32(comboBox1.SelectedItem);
            foreach (var item in DataBase.Workers)
            {
                if (item.WorkerId == id)
                {
                    item.WorkerHourlyPay = money;

                }
            }
            // MessageBox.Show(comboBox1.ToString());

            ExtensionsClass.UpdateSources(dataGridViewSalaryCalc);
            //var upsource = new BindingSource();
            //upsource.DataSource = DataBase.Workers;
            //dataGridViewSalaryCalc.DataSource = upsource;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            DateTime Startday;
            TimeSpan minus;
            int id = Convert.ToInt32((dataGridViewSalaryCalc.CurrentRow.Index) + 1);
            foreach (var item in DataBase.Workers)
            {

                if (item.WorkerId == id)
                {
                    
                    Startday = item.WorkerStartDate;
                    DateTime Exitdate = dateTimePickerExit.Value.AddMinutes(1);

                    decimal WorkerHourlymoney = item.WorkerHourlyPay;
                    decimal WorkerDailymoney = item.WorkerDailyPay;
                    minus = Exitdate - Startday;      // datetimepicker
                   
                    //  minus = Exitday - Startday; // DateTime.now
                    decimal minute = minus.Minutes;
                    decimal hours = minus.Hours;


                    WorkerDailymoney = hours * (decimal)(WorkerHourlymoney) + minute * (decimal)(WorkerHourlymoney/60);//+(minus.Minutes*(Pul/Saat) bunu nece double edim ? :/
                    item.WorkerDailyPay = Math.Round(WorkerDailymoney,2,MidpointRounding.ToEven);
                    MessageBox.Show(Math.Round(WorkerDailymoney, 2, MidpointRounding.ToEven).ToString());
                    MessageBox.Show(minus.Days.ToString() + " :" + minus.Hours.ToString() + " :" + minus.Minutes.ToString() + ">>>> " + item.WorkerDailyPay.ToString());
                    MessageBox.Show(item.WorkerDailyPay.ToString());

                    ExtensionsClass.UpdateSources(dataGridViewSalaryCalc);
                    //var upsource = new BindingSource();
                    //upsource.DataSource = DataBase.Workers;
                    //dataGridViewSalaryCalc.DataSource = upsource;


                }

            }
        }
    }
}
