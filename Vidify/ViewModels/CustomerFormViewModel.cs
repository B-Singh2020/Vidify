using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidify.Models;

namespace Vidify.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } //dont need list bc we just need to iterate 
        public Customer Customer { get; set; }
    }
}