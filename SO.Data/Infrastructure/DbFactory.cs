using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SODbContext dbContext;
        public SODbContext Init()
        {
            return dbContext ?? (dbContext = new SODbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
