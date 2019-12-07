using AppGestionStagiaires.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionStagiaires.Data
{
    public class AppModel : DbContext
    {
        public AppModel() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=TP_TraineeManagement_EF;user = sa; password = admintp4")
        {

        }
        public virtual DbSet<Group> Groups { get; set; }
    }
}
