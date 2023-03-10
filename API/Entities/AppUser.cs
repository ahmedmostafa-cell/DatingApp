using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }




        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}