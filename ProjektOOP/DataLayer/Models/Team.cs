using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Alternate_Name { get; set; }
        public string Fifa_Code { get; set; }
        public int GroupId { get; set; }
        public char Group_Letter { get; set; }


        public override string ToString()
        {
            return this.Country+" "+this.Fifa_Code  ;
        }
    }
    
}
