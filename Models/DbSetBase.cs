using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class DbSetBase
    {
        [Required]
        public Guid Id{set;get;}

    }
}
