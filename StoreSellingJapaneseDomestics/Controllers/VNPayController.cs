using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.ViewModel.GeneralViewModel.VietQRPay;
using System.Security.Cryptography;
using System.Text;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VNPayController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public VNPayController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("generate-qr")]
        public IActionResult GenerateQR(string bankCode, string accountNumber, decimal amount, string content)
        {
            string qrUrl = $"https://img.vietqr.io/image/{bankCode}-{accountNumber}-qr_only.png?amount={amount}&addInfo={Uri.EscapeDataString(content)}";
            return Ok(new { QrImageUrl = qrUrl });
        }

    }
}
