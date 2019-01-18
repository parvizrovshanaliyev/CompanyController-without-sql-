using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyController
{
    class DataBase
    {
        public static List<Worker> Workers = new List<Worker>() {
            new Worker("Parviz","Aliyev","Coder",1000,0506856915,"parvizra@code.edu.az",DateTime.Parse("01/16/2019 01:00:00")),
            new Worker("Qasim","Memmedov","dev",1500,0506856915,"Qasim@code.edu.az",DateTime.Parse("01/16/2019 09:00:00")),
            new Worker("Hatce","Kahraman","Coder",1000,0506856915,"Hatce@code.edu.az",DateTime.Parse("01/16/2019 09:30:00")),
            new Worker("Mustafa","Emin","dev",1500,0506856915,"Mustafa@code.edu.az",DateTime.Parse("01/16/2019 09:40:00")),
            new Worker("Alasgar","Nazarov","Coder",1000,0506856915,"Alasgar@code.edu.az",DateTime.Parse("01/16/2019 10:00:00")),
        };
    }
}
