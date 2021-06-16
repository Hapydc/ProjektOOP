using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP
{
    class Team
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string AlternateName { get; set; }
        public string FifaCode { get; set; }
        public int GroupId { get; set; }
        public int GroupLetter { get; set; }
        public override string ToString()
        {
            return Country + " " + FifaCode;
        }

    }
}
