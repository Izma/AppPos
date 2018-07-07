using AppPos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPos.DataAccess
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProduct();
    }
}
