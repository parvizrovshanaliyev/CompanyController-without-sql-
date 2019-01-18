﻿using System;
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
            dataGridView1.DataSource = DataBase.Workers;
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

        
    }
}
