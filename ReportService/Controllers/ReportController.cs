using Microsoft.AspNetCore.Mvc;
using ReportService.Models;

namespace ReportService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet("summary")]
        public ActionResult<ExpenseReport> GetReport()
        {
            var report = new ExpenseReport
            {
                Category = "Food",
                TotalAmount = 150.50m
            };
            return Ok(report);
        }
    }
}
