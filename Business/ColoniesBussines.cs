using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ColoniesBussines
    {

        public static async void AddColonies(List<dbColonies> Colonies)
        {
            using (var db = new TreeContext())
            {
               db.AddRange(Colonies);
               await db.SaveChangesAsync();
            }
        }


    }
}
