using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public FilesController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet("files")]
        public IActionResult GetUploadedFiles()
        {
            var uploadsPath = Path.Combine(_environment.ContentRootPath, "Uploads");
            var fileNames = Directory.GetFiles(uploadsPath)
                                      .Select(f => Path.GetFileName(f))
                                      .ToList();

            return Ok(fileNames);
        }
    }
}
