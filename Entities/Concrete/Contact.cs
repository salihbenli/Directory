using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int UUID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
