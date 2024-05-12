using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SpeciesBusiness
    {
        public static async void AddSpecies(List<dbSpecies> Species)
        {
            using (var db = new TreeContext())
            {
                db.AddRange(Species);
                await db.SaveChangesAsync();
            }
        }
    }
}
