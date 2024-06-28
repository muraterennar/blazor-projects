using WebServiceConnection.Server.Controllers;

namespace WebServiceConnection.Server.Service;

public interface ICalculatorService
{
    Task<int> AddCalculartor(IstenenVeri istenenVeri);
}
