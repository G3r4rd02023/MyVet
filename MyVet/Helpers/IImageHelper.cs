using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyVet.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);

    }
}
