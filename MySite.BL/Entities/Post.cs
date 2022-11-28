using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.BL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDateTime { get; set; }

        [Display(Name ="Image Name")]
        public String ImagePath { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
