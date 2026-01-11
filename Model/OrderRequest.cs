using System.ComponentModel.DataAnnotations;

namespace citiesapi.Model
{
    public class OrderRequest
    {
        [Required]
        public bool IsEnabled { get; set; }
    }
}
