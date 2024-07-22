using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("Author_ID")]
        public int Author_id { get; set; }
        public Author? Author_ID { get; set; }

        [ForeignKey("Category_ID")]

        public int Categoy_id { get; set; }
        public Category? Category_ID { get; set; }


    }
}
