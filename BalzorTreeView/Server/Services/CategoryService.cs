using DenemeTreeView.Shared;
using System.Data;
using System.Data.SqlClient;

namespace DenemeTreeView.Server.Services;

public class CategoryService : ICategoryService
{

    private readonly string connectionString = "data source = 'SERVER\\ETA';DataBase=HRZ_KATRE_CIAS;Trusted_Connection=no;user ID=sa;Password=Eta.2017;";
    public DataTable KategoriListesiOku(string eksorgu = "", bool hatagoster = false)
    {
        try
        {
            string komutstr = @"SELECT id, KategoriUstid, KategoriAltid, KategoriStokBaglanabilir, KategoriStokVar, KategoriAktif, KategoriKod, KategoriAdi, KategoriNo From KategoriListesi";
            komutstr += " " + eksorgu + "  ORDER BY KategoriNo";

            DataTable table = new DataTable();

            using(SqlConnection kli_baglanti = new(connectionString))
            {
                if(kli_baglanti.State == ConnectionState.Closed)
                {
                    kli_baglanti.Open();
                }

                using(SqlCommand kli_komut = new(komutstr, kli_baglanti))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(kli_komut);

                    sqlDataAdapter.Fill(table);
                }

                if(kli_baglanti.State == ConnectionState.Open)
                    kli_baglanti.Close();


            }

            return table;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Sonuc<List<KategoriListesiBilgileri>>> KategoriListesiniAl()
    {
        Sonuc<List<KategoriListesiBilgileri>> sonuc = new();
        string baglantistr = connectionString;

        SqlConnection baglanti = new SqlConnection(baglantistr);

        try
        {

            DataTable tablo = KategoriListesiOku();
            if(tablo == null)
            {
                sonuc.sonuc = false;
                sonuc.mesaj = "";
                sonuc.data = null;
            }
            else if(tablo.Rows.Count == 0)
            {
                sonuc.sonuc = false;
                sonuc.mesaj = "Henüz kategoriler eklenmemiş.";
                sonuc.data = new List<KategoriListesiBilgileri>();
            }
            else
            {
                List<KategoriListesiBilgileri> klbListe = await KategoriListesiniDoldur(tablo);
                sonuc.sonuc = true;
                sonuc.mesaj = "Başarılı";
                sonuc.data = klbListe;
            }
        }
        catch(Exception ex)
        {
            sonuc.mesaj = ex.Message;
            sonuc.sonuc = false;
            sonuc.data = null;
        }
        return sonuc;
    }

    public async Task<List<KategoriListesiBilgileri>> KategoriListesiniDoldur(DataTable tablo)
    {
        List<KategoriListesiBilgileri> klbListe = new List<KategoriListesiBilgileri>();
        for(int i = 0; i < tablo.Rows.Count; ++i)
        {
            KategoriListesiBilgileri klb = new KategoriListesiBilgileri();
            /*string komutstr = @"SELECT id, KategoriUstid, KategoriAltid, KategoriStokBaglanabilir, KategoriStokVar, KategoriAktif, KategoriKod, KategoriAdi From KategoriListesi";*/
            klb.id = tablo.Rows[i]["id"].ToString();
            klb.kategoriustid = tablo.Rows[i]["KategoriUstid"].ToString();
            klb.kategorialtid = Convert.ToInt32(tablo.Rows[i]["KategoriAltid"]);
            klb.kategoristokbaglanabilir = Convert.ToInt32(tablo.Rows[i]["KategoriStokBaglanabilir"]);
            klb.kategoristokvar = Convert.ToInt32(tablo.Rows[i]["KategoriStokVar"]);
            klb.kategoriaktif = Convert.ToInt32(tablo.Rows[i]["KategoriAktif"]);
            klb.kategorikod = tablo.Rows[i]["KategoriKod"].ToString();
            klb.kategoriadi = tablo.Rows[i]["KategoriAdi"].ToString();
            klb.kategoriNo = tablo.Rows[i]["KategoriNo"].ToString();
            klbListe.Add(klb);
        }
        return klbListe;
    }
}
