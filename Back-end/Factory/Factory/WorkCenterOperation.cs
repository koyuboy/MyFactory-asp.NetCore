using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WorkCenterOperation : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WcOprId { get; set; }
        public int WorkCenterId { get; set; }
        public int OperationId { get; set; }
        public int Speed { get; set; }

    }
}
