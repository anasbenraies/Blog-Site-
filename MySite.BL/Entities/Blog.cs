using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.BL.Entities
{
    public class Blog
    {
            public int Id { get; set; }
            //[Column(TypeName="nvarchar(100)")]
            public string Url { get; set; }
            public ICollection<Post> Posts { get; set; }
    }
}
