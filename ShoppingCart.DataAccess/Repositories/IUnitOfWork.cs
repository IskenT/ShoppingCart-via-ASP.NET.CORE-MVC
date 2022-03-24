using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface IUnitOfWork 
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        //ICartRepository Product { get;  }
        //IApplicationUser ApplicationUser { get;  }
        //IOrderHeaderRepository OrderHeader { get;  }
        //IOrderDetailRepository OrderDetail { get;  }
        void Save();
    }
}
