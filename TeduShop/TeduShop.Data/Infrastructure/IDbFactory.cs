using System;
using TeduShop.Model.Model;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory :IDisposable
    {
        TeduShopModel Init();
    }
}
