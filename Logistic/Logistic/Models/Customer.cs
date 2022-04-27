using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public partial class LogisticContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

    [Table("customer")]
    public class Customer
    {
        [Key]
        public int ID_Customer { get; set; }
        public string Organization_Name { get; set; }
        public string Organization_Form { get; set; }
        public string Director_FIO { get; set; }
        public string Law_Address { get; set; }
        public string Mail_Address { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public int Checking_Account { get; set; }
        public int Korr_Account { get; set; }
        public int BIK { get; set; }

        [ForeignKey("ID_OKPO")]
        public int ID_OKPO { get; set; }

        [ForeignKey("ID_FIAS")]
        public int ID_FIAS { get; set; }

        public Okpo OKPO { get { return Program.db.Okpos.Find( ID_OKPO ); } }
        public Fias Fias { get { return Program.db.Fiases.Find( ID_FIAS ); } }

        public override string ToString()
        {
            return OKPO.ToString();
        }

    }
}
