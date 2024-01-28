using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopiVerse.Data;
using ShopiVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopiVerse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ProjectDbContext _db;

        public OrderController(ProjectDbContext db)
        {
            _db = db;
        }

        // GET api/order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders(DateTime? startDate, DateTime? endDate, string customerName = "", string customerSurname = "")
        {
            var query = _db.Orders.Include(o => o.Customer).AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(o => o.OrderDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(o => o.OrderDate <= endDate.Value);
            }

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(o => o.Customer.Name.ToLower().Contains(customerName.ToLower()));
            }

            if (!string.IsNullOrEmpty(customerSurname))
            {
                query = query.Where(o => o.Customer.Surname.ToLower().Contains(customerSurname.ToLower()));
            }

            var orders = await query.ToListAsync();
            return Ok(orders);
        }
    }
}
