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
    public partial class CompanyUniversalPanel : Form
    {
        public CompanyUniversalPanel()
        {
            InitializeComponent();
            dataGridViewUniversal.DataSource = DataBase.Workers;
        }


        #region Average   Maas ortalamasinin hesablanmasi  uzun variant  ve qisa variant
        private void btnAverage_Click(object sender, EventArgs e)
        {

            //int sum = 0;
            //int count_rows = dataGridView1.Rows.Count;
            //for (int i = 0; i < count_rows; ++i)
            //{
            //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);                // ortalamanin hesablanmasi
            //}

            //double avg = sum / count_rows;
            //MessageBox.Show(avg.ToString());

            #region Average short version
            var workers = DataBase.Workers;
            var maaslar = from worker in workers
                          select worker.WorkerPay;
            var custom = workers.Where(item => item.WorkerPay > maaslar.Average());
            listBox1.Items.Clear();
            foreach (var item in custom)
            {
               
                //  MessageBox.Show((item.WorkerName).ToString());
                // listBox1.DisplayMember ="WorkerName";
                // listBox1.DataSource = DataBase.Workers;


                listBox1.Items.Add(item.WorkerId+" . " + item.WorkerName + " " + item.WorkerSurname+" : "+ item.WorkerPay);                //avg short version

            }
            var avg = maaslar.Average();
            MessageBox.Show(avg.ToString());
            #endregion
           
        }
        #endregion

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            var addWorkerPanel = new AddWorkerPanel();
            addWorkerPanel.Show();
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
           // int index = dataGridView1.CurrentRow.Index;
            dataGridViewUniversal.Rows.RemoveAt(dataGridViewUniversal.CurrentRow.Index);
          //  MessageBox.Show(index.ToString());
        }

        private void btnclearlist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAllWorkers_Click(object sender, EventArgs e)
        {
            ExtensionsClass.UpdateSources(dataGridViewUniversal);
            //var upsource = new BindingSource();
            //upsource.DataSource = DataBase.Workers;
            //dataGridViewUniversal.DataSource = upsource;
        }

        private void btnSalaryCalcPanel_Click(object sender, EventArgs e)
        {
            var salarycalcpanel = new HourlPayCalcPanel();
            salarycalcpanel.Show();
        }
    }
}
