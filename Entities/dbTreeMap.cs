using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class dbTreeMap
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTree { get; set; }

        public int IdColony { get; set; }

        public virtual dbColonies Colony { get; set; }

        public int IdSpecie { get; set; }

        public virtual dbSpecies Specie { get; set; }

        public int Zone { get; set; }

        public int NoTree { get; set; }

        public int Xcoordinate { get; set; }

        public int Ycoordinate { get; set; }

        public int Stage { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal H { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal DB { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal DCNS { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal DCEO { get; set; }

        public int EFT { get; set; }

        public int EST { get; set; }

        public int EFC { get; set; }
        public int ESC { get; set; }
        public int Sa { get; set; }
        public int Condition { get; set; }

        public int maintenance { get; set; }
        
        public int Risk { get; set; }

        [StringLength(200)]
        public string Observation { get; set; }


    }
}
