using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apus_app.Pages;

public class TemperatureModel : PageModel
{
    private readonly ILogger<TemperatureModel> _logger;

    public TemperatureModel(ILogger<TemperatureModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}