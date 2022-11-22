using AccountDataSerializer;
using ClassLibrary;
using ProfileClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PSI_MobileApp
{
    public class IsUniqueUsername : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            using(var context = new ProjectDatabaseContext())
            {
                return context.Accounts.All(elem => elem.UserName != (string)value);
            }
                
        }
    }
}
