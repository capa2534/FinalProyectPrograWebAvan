using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10.Application
{
    public class JwtToken
    {
        [Required]

        public string Token { get; set; }
    }
}
