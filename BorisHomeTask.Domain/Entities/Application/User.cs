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
        [Table("User")]
        public class User : AuditableEntity<int>
        {
            [Required]
            [MaxLength(30)]
            public string Name { get; set; }

            [Required]
            [MaxLength(30)]
            public string Surname { get; set; }

            [MaxLength(40)]
            public string Email { get; set; }

            [MaxLength(15)]
            public string PhoneNumber { get; set; }
        }   
}

