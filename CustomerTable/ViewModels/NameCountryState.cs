using CustomerTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerTable.ViewModels
{
    public class NameCountryState
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<State> States { get; set; }
        public Customer Customer { get; set; }
    }
}