using Dawson_HW4.Models;

namespace Dawson_HW4.Data
{
    public interface iProductRepository
    {
        List<Product> GetProductList(int categoryID);

        List<Product> GetProductDetails(int productID);

    }
}
