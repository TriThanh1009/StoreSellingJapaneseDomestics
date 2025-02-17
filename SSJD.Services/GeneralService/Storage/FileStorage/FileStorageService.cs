using Microsoft.AspNetCore.Hosting;

namespace SSJD.Services.GeneralService.Storage.FileStorage
{
    public class FileStorageService : IFileStorageService
    {

        private readonly string _frontendImageFolder;
        private readonly string FRONTEND_IMAGE_FOLDER = "../../SSJD.Frontend/src/Image";

        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            _frontendImageFolder = Path.GetFullPath(FRONTEND_IMAGE_FOLDER);
            if (!Directory.Exists(_frontendImageFolder))
            {
                Directory.CreateDirectory(_frontendImageFolder);
            }
        }
        public string GetFileUrl(string fileName)
        {
            return $"/{FRONTEND_IMAGE_FOLDER}/{fileName}";
        }

        public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            var filePath = Path.Combine(_frontendImageFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            mediaBinaryStream.CopyToAsync(output);
        }
        public async Task DeleteFileAsync(string fileName)
        {
            var filePath = Path.Combine(_frontendImageFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }
}
