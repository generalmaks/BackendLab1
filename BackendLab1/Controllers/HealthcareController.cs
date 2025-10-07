using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackendLab1.Controllers;

[ApiController]
public class HealthcareController: Controller
{
    [HttpGet("/healthcheck")]
    public async Task<IActionResult> GetHealthcare()
    {
        object result = new
        {
            Status = nameof(HealthStatus.Healthy),
            Time = DateTime.Now.ToString(CultureInfo.CurrentCulture)
        };
            
        return Ok(result);
    }
}