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
        private readonly IDbContextFactory<ProjectDatabaseContext> _dbFactory;
        public DatabaseInteraction(IDbContextFactory<ProjectDatabaseContext> DbFactory) 
        {
            _dbFactory = DbFactory;
        }
        public void Add(T toAdd)
        {
            using (var context = _dbFactory.CreateDbContext())
            {
                context.Add(toAdd);
                context.SaveChanges();
            }
        }
        public void Remove(T toRemove)
        {
            using (var context = _dbFactory.CreateDbContext())
            {
                context.Remove(toRemove);
                context.SaveChanges();
            }
        }
    }
}
