        using Microsoft.AspNetCore.Hosting;
        using Microsoft.AspNetCore.Http;
using SSJD.Services.GeneralService.Storage.CloudStorage;

        namespace SSJD.Services.GeneralService.Storage.FileStorage
        {
            public class FileStorageService: IFileStorageService
            {
                private readonly IWebHostEnvironment _environment;
                private readonly CloudStorageService _cloudStorageService;

                public FileStorageService(IWebHostEnvironment environment, CloudStorageService cloudStorageService)
                {
                    _environment = environment;
                    _cloudStorageService = cloudStorageService;

                }
                public async Task<string> SaveFileAsync(IFormFile imageFile, string[] allowedFileExtensions)
                {
                    if (imageFile == null)
                    {
                        throw new ArgumentNullException(nameof(imageFile));
                    }

                    // Check the allowed extensions
                    var ext = Path.GetExtension(imageFile.FileName);
                    if (!allowedFileExtensions.Contains(ext))
                    {
                        throw new ArgumentException($"Only {string.Join(",", allowedFileExtensions)} are allowed.");
                    }

                    // Generate a unique filename
                    var fileName = $"{Guid.NewGuid().ToString()}{ext}";

                    // Upload to Cloud Storage
                    var objectName = await _cloudStorageService.UploadFileAsync(imageFile, fileName);

                    // Get the public URL
                    var fileUrl = await _cloudStorageService.GetFileUrlAsync(objectName);
                    return fileUrl; 
                }


                public void DeleteFile(string fileNameWithExtension)
                {
                    if (string.IsNullOrEmpty(fileNameWithExtension))
                    {
                        throw new ArgumentNullException(nameof(fileNameWithExtension));
                    }
                    var contentPath = _environment.ContentRootPath;
                    var path = Path.Combine(contentPath, $"Uploads", fileNameWithExtension);

                    if (!File.Exists(path))
                    {
                        throw new FileNotFoundException($"Invalid file path");
                    }
                    File.Delete(path);
                }

            }
        }
