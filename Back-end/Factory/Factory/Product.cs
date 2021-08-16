using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ProductType { get; set; }
        public bool IsSalable { get; set; }
    }
}
