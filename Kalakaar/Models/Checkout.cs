using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalakaar.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public List<int> ProductIDs { get; set; }
        public string Username { get; set; }
    }
}
