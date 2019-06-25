using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;

namespace TeduShop.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T
    {
        #region
        private TeduShopModel dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected TeduShopModel DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        //protected RepositoryBase(IDbFactory dbFactory)
        //{
        //    DbFactory = dbFactory;
        //    dbSet = DbContext.Set<T>();
        //}

    }
}
