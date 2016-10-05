using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Category:DbSetBase
    {

        [Required]
        public string Name{set;get;}

        public ICollection<Blog> Blogs{set;get;}
    }
}
