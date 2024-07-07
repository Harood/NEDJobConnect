using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registration_login_system
{
    internal class JobListing
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }

        public string Requirements { get; set; }
        public string Type { get; set; }
    }
}
