using DenemeTreeView.Shared;
using System.Data;

namespace DenemeTreeView.Server.Services;

public interface ICategoryService
{
    public DataTable KategoriListesiOku(string eksorgu = "", bool hatagoster = false);

    public Task<Sonuc<List<KategoriListesiBilgileri>>> KategoriListesiniAl();

    public Task<List<KategoriListesiBilgileri>> KategoriListesiniDoldur(DataTable tablo);
}