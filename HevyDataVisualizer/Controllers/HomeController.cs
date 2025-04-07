using CsvHelper;
using CsvHelper.Configuration;
using HevyDataVisualizer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace HevyDataVisualizer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ImportFile(IFormFile file)
        {
            if (file == null)
                return BadRequest();

            var workout = new Workout();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(), //TODO: Snake Case to Pascal Case
            };
            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<Workout>();
            }

            return Ok();
        }
    }
}
