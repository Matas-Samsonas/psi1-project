using ClassLibrary;
using System.ComponentModel.DataAnnotations;


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
