using AccountDataSerializer;
using ProfileClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class IsUniqueUsername : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            AccountDataSerializer<Profile> serializer = new AccountDataSerializer<Profile>("C:\\Users\\Matas\\source\\repos\\psi1-project-new\\PSI_MobileApp\\ProfileData.json");
            if (serializer.List.Any(user => String.Equals(user.Name, value)))
            {
                return false;
            }
            return true;
        }
    }
}
