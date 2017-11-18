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
        public class User : Entity<int>, IUser
        {
            [Required]
            [MaxLength(40)]
            public string Name { get; set; }

            [MaxLength(60)]
            public string Surname { get; set; }

            [MaxLength(40)]
            [Display(Name = "E-mail")]
            public string Email { get; set; }

            [MaxLength(20)]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            public virtual ICollection<WorkPlace> WorkPlaces { get; set; }

            public User()
            {
                WorkPlaces = new List<WorkPlace>();
            }
    }   
}

