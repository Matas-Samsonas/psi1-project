using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class DatabaseInteraction<T> where T : class, IUsingUUID
    {
        public void Add(T toAdd)
        {
            using (ProjectDatabaseContext context = new())
            {
                context.Add(toAdd);
                context.SaveChanges();
            }
        }
        public void Remove(T toRemove)
        {
            using (ProjectDatabaseContext context = new())
            {
                context.Remove(toRemove);
                context.SaveChanges();
            }
        }
    }
}
