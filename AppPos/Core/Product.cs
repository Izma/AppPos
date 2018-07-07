using AppPos.DataLayer;
using AppPos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPos.Core
{
    public class Product: IProduct
    {
        private readonly IProductRepository repository;
        public Product(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public async Task<List<ProductModel>> GetProduct()
        {
            return await repository.GetProduct();
        }
    }
}
