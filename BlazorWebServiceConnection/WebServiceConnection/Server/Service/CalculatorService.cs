using System.ServiceModel;
using CalculateWebService;
using WebServiceConnection.Server.Controllers;

namespace WebServiceConnection.Server.Service;

public class CalculatorService : ICalculatorService
{
    public async Task<int> AddCalculartor(IstenenVeri istenenVeri)
    {
        // ------ Şunları Oluşturmak Gerekiyor ------
        var binding = new BasicHttpBinding();
        // Bağlantı Adresini Giriyoruz
        var endpointAddress = new EndpointAddress("http://www.dneonline.com/calculator.asmx");

        var calculator = new CalculatorSoapClient(binding, endpointAddress);

        // ----- Bağlantı Açık Olma Durumu Kontrolü
        if(calculator.State == CommunicationState.Closed)
            await calculator.OpenAsync();

        // Gelen Sonucu Alıyoruz
        var gelenSonuc = await calculator.AddAsync(istenenVeri.sayi1, istenenVeri.sayi2);


        // ----- Bağlantı Kapalı Olma Durumu Kontrolü
        if(calculator.State == CommunicationState.Opened)
            await calculator.CloseAsync();

        return gelenSonuc;
    }
}
