using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carti
{
    public class Autor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Autor(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
