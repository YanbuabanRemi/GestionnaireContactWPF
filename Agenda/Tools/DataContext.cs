using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Tools
{
    class DataContext : DbContext
    {
        private static DataContext _instance = null;
        private static object _lock = new object();
        private static readonly string connectionString = @"Data Source=(localdb)\GestionHotel;Integrated Security=True";

        public DataContext() : base(connectionString)
        {

        }

        public static DataContext Instance
        {
            get
            {
                lock(_lock)
                {
                    if (_instance == null)
                        _instance = new DataContext();
                    return _instance;
                }
            }
        }

        public DbSet<Contact> contact { get; set; }
    }
}
