using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SODbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public SODbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }

        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
