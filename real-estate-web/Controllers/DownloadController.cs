using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Tools.Services;

namespace real_estate_web.Controllers;

[Authorize]
public class DownloadController : Controller
{
    private readonly ZipService _zipService;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public DownloadController(ZipService zipService, IWebHostEnvironment hostingEnvironment)
    {
        _zipService = zipService;
        _hostingEnvironment = hostingEnvironment;
    }

    public IActionResult DownloadFiles(string folderPath)
    {
        if (string.IsNullOrEmpty(folderPath))
        {
            return Redirect(Request.Headers["Referer"].ToString());
        }
        
        folderPath = folderPath.TrimStart(Path.DirectorySeparatorChar);
        var fullFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, folderPath);
        var zipBytes = _zipService.ZipFiles(fullFolderPath);
        string fileName = folderPath.Split(Path.DirectorySeparatorChar).Last();

        return File(zipBytes, "application/zip", fileName+"_all_photo.zip");
    }
}
