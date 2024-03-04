using HotelWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWpfApp.Classes
{
    public static class Helper
    {
        public static DataBaseContext Db = new DataBaseContext();

        public static void RefreshData()
        {
            foreach (var item in Db.ChangeTracker.Entries())
            {
                item.Reload();
            }
        }
    }
}
