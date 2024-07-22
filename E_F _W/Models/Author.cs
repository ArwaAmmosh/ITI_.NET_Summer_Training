using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Author

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public List<Post>? Posts { get; set; } = new List<Post>();

    }
}
