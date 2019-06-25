using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;

namespace TeduShop.Data.Infrastructure
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TeduShopModel dbContext;
        
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        
        public TeduShopModel DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            
        }
    }
}
