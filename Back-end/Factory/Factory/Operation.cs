using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Operation : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OperationId { get; set; }
        [StringLength(50)]
        public string OperationName { get; set; }
        [StringLength(50)]
        public string ProductType { get; set; }
    }
}
