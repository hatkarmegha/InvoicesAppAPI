
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvoiceApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInvoice()
        {
            var invoices =  _context.Invoices.ToList();
            return View(invoices);
        }
    }
}
