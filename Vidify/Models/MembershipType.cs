using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidify.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }           //key is byte bc only 3 types of memberships 
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}