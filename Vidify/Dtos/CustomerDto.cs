using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidify.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidify.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]   //makes attribute not nullable
        [StringLength(255)] //sets max length of name             dtata annotations add constraints for attributes 
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }  // usful for loading related types together from DB
        public byte MembershipTypeId { get; set; }       //foreign for optimization
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}