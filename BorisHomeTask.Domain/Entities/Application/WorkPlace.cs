using BorisHomeTask.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Domain.Entities.Application
{
    [Table("WorkPlace")]
    public class WorkPlace : AuditableEntity<int>, IWorkPlace
    {
        [Required]
        [MaxLength(150)]
        public string CompanyName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
