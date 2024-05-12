using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TreeMapBusiness
    {
        public static async void AddTree(List<dbTreeMap> trees)
        {
            using (var db = new TreeContext())
            {
                db.AddRange(trees);

                await db.SaveChangesAsync();
            }

        }

        public static List<dbTreeMap> ListTreeMap()
        {
            using (var db = new TreeContext())
            {
                return db.TreeMap.ToList();
            }
        }
    }
}
