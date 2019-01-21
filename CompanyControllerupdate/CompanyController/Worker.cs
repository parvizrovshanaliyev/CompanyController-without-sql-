using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyController
{
    class Worker
    {
        static int id = 1;

        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerWork { get; set; }
        public int WorkerPay { get; set; }
        public int Workernumber { get; set; }
        public string WorkerEmail { get; set; }
        public DateTime WorkerRegDate { get; set; }
        public DateTime WorkerStartDate { get; set; }
        public DateTime WorkerExitDate { get; set; }
        public int WorkerHourlyPay { get; set; }
        public decimal WorkerDailyPay { get; set; }

        public Worker(string workerName, string workerSurname, string workerWork, int workerPay, int workernumber, string workerEmail, DateTime workerRegDate)//,DateTime workerStartDate, DateTime workerExitDate
        {
            WorkerId = id;
            WorkerName = workerName;
            WorkerSurname = workerSurname;
            WorkerWork = workerWork;
            WorkerPay = workerPay;
            Workernumber = workernumber;
            WorkerEmail = workerEmail;
            WorkerRegDate = workerRegDate;
            //WorkerStartDate = workerStartDate;
            //WorkerExitDate = workerExitDate;

            id++;
        }
    }
}
