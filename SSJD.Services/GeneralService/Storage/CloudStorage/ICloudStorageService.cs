using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Storage.CloudStorage
{
    public interface ICloudStorageService
    {
        Task<string> UploadFileAsync(IFormFile file, string fileName);
        Task<string> GetFileUrlAsync(string fileName);
    }
}
