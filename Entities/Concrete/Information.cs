using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Information
    {
        [Key]
        public int InfoID { get; set; }
        public string Telephone_Number { get; set; }
        public string E_Mail { get; set; }
        public string Location { get; set; }
        public string Info { get; set; }
        public int UUID { get; set; }
        public Contact Contact { get; set; }


    }
}
