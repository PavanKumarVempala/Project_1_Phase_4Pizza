using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P4PhaseEndPizzaPrototype.Pages
{
    [BindProperties(SupportsGet = true)]
    public class OrderConfirmationModel : PageModel
    {
        public string PizzaName { get; set; }  
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; } 
        public void OnGet()
        {
        }
    }
}
