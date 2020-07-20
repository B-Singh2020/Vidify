using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidify.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }  // usful for loading related types together from DB
        public MembershipType MembershipType { get; set; }   //navigation prop allows navigate from one type to another
        public byte MembershipTypeId { get; set; }       //foreign for optimization
    }                                                  
    
}