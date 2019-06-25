using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Diposable, IDbFactory
    {
        TeduShopModel dbContext;

        public TeduShopModel Init()
        {
            return dbContext ?? (dbContext = new TeduShopModel());
        }

        
    }
}
