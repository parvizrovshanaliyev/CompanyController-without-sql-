using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyController
{
    public static  class ExtensionsClass
    {
        public static void  UpdateSources(this DataGridView dataGrid)
        {
            var upsource = new BindingSource();
            upsource.DataSource = DataBase.Workers;
            dataGrid.DataSource = upsource;
        }
        
    }
}
