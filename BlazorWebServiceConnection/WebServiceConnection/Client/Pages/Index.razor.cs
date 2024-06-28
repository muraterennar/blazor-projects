using Microsoft.AspNetCore.Components;
using System.Text.Json;
using System.Text;
using System.Net.Http.Json;

namespace WebServiceConnection.Client.Pages;

public partial class Index
{
    public int Sayi1 { get; set; }
    public int Sayi2 { get; set; }
    string sonuc;


    [Inject]
    private HttpClient HttpClient { get; set; }

    IstenenVeri sayilar = new();

    public async void HesaplaIstegi(int sayi1, int sayi2)
    {
        sayilar.sayi1 = sayi1;
        sayilar.sayi2 = sayi2;


        // İsterk Gönderilecek yer - İsteğin Body'sini Gönderiyoruz
        StringContent body = new StringContent(JsonSerializer.Serialize(sayilar), Encoding.UTF8, "application/json");
        var response = await HttpClient.PostAsync("api/CalculatorService", body);

        //TODO: Bakılacak yer --------
        sonuc = await response.Content.ReadAsStringAsync();
    }
}

public class IstenenVeri
{
    public int sayi1 { get; set; }
    public int sayi2 { get; set; }
}
