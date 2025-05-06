using Dawson_HW4.Data;
using Dawson_HW4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dawson_HW4.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly iProductRepository _productRepository;

        public Product Product { get; set; }

        public DetailsModel(iProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult OnGet(int id) // id will come from the route
        {
            Product = _productRepository.GetProductDetails(id);

            if (Product == null)
            {
                return NotFound(); // Or redirect to an error page/display a message
            }

            return Page();
        }
    }
}