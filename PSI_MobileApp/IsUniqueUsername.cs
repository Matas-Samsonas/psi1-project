using AccountDataSerializer;
using ClassLibrary;
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
            using (ProjectDatabaseContext context = new())
            {
                return context.Accounts.All(elem => elem.UserName != (string)value);
            }
        }
    }
}
