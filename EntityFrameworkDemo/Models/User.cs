using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        
        public string? Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        
        public string? UserName { get; set; }

        [Required]
        public string Role { get; set; }

        private User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public User(string email, string password) : this()
        {
            Email= email;
            Password= password;
        }

    }
}
