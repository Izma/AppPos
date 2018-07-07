using AppPos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPos.Core
{
    public interface IProduct
    {
        Task<List<ProductModel>> GetProduct();
    }
}
