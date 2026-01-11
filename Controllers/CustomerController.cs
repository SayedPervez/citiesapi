using citiesapi.Data;
using citiesapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace citiesapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost("customers/{customerId}/orders")]
        public ActionResult<Order> CreateOrder([FromBody] Order orderData, int customerId)
        {
            if (orderData == null)
            {
                return BadRequest("No order data");
            }

            if (string.IsNullOrWhiteSpace(orderData.ProductName))
            {
                return BadRequest("Product Name cannot be empty");
            }

            var customerExists = DataSource.custData
            .Any(c => c.CustomerId == customerId);

            if (!customerExists)
                return NotFound("Customer does not exist");

            orderData.OrderId = DataSource.OrderData.Any() ? DataSource.OrderData.Max(e => e.OrderId) + 1 : 1;
            orderData.CustomerId = customerId;
            DataSource.OrderData.Add(orderData);

            return CreatedAtAction(
                    nameof(CreateOrder), new { id = customerId }, orderData);
        }
    }
}
