using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class dbColonies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColony { get; set; }

        [StringLength(75)]
        public  string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal SurfaceH { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal SurfaceM { get; set; }

        [NotNull]
        public int Na { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Frequency { get; set; }
        public ICollection<dbTreeMap> Trees { get; set; }



    }
}
