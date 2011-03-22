using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projectManagerMVC3.Models
{
    public class t_staff_holiday
    {
        public int id { get; set; }
        public int userid { get; set; }       
        public DateTime startdate { get; set; }
        public DateTime? enddate { get; set; }

        public virtual t_user user { get; set; }

    }

    public class t_user
    {
        public int id { get; set; }
        public string name { get; set; }
    }


    public class projectManager : DbContext
    {
        public DbSet<t_staff_holiday> StaffHolidays { get; set; }
        public DbSet<t_user> Users { get; set; }
    }


}