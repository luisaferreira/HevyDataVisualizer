using CsvHelper;
using CsvHelper.Configuration;
using HevyDataVisualizer.Mappings;
using HevyDataVisualizer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace HevyDataVisualizer.Controllers;

public class HomeController : Controller
{
    public HomeController() { }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> ImportFile(IFormFile file)
    {
        if (file == null)
            return BadRequest();

        IEnumerable<Workout> workout;

        using (var reader = new StreamReader(file.OpenReadStream()))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<WorkoutMap>();
            workout = csv.GetRecords<Workout>().ToList();
        }

        return Ok();
    }
}
