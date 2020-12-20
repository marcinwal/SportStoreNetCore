using System;
using System.Linq;

namespace SportsStore.Models
{
    public interface IStoreRepositiry
    {
        IQueryable<Product> Products { get; }
    }
}
