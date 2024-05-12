using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class dbSpecies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSpecie { get; set; }

        [StringLength(80)]
        public string CommonName { get; set; }

        [StringLength(80)]
        public string scientificName { get; set; }

        public ICollection<dbTreeMap> Trees { get; set; }

    }
}
