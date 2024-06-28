using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceConnection.Server.Service;

namespace WebServiceConnection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorServiceController : ControllerBase
    {

        private readonly ICalculatorService _calculatorService;

        public CalculatorServiceController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] IstenenVeri istenenVeri)
        {
            // ----- Gelen Sonucu Alıyorum
            int sonuc = await _calculatorService.AddCalculartor(istenenVeri);
            return Ok($"Sonuç: {sonuc}");
        }
    }
    public class IstenenVeri
    {
        public int sayi1 { get; set; }
        public int sayi2 { get; set; }
    }
}
