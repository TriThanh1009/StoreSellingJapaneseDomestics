using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Http;
using SSJD.Services.GeneralService.Storage.FileStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Storage.CloudStorage
{
    public class CloudStorageService : ICloudStorageService
    {
        private readonly StorageClient _storageClient;
        private readonly string _bucketName = "ssjd-uploads"; // Thay bằng tên bucket của bạn

        public CloudStorageService()
        {
            _storageClient = StorageClient.Create();
        }

        public async Task<string> UploadFileAsync(IFormFile file, string fileName)
        {
            using var stream = file.OpenReadStream();
            var objectName = $"images/{fileName}"; // Lưu vào thư mục "images" trong bucket
            await _storageClient.UploadObjectAsync(_bucketName, objectName, file.ContentType, stream);
            return objectName;
        }

        public async Task<string> GetFileUrlAsync(string fileName)
        {
            return $"https://storage.cloud.google.com/{_bucketName}/{fileName}";
        }

    }
}
