using DenemeTreeView.Shared;

namespace DenemeTreeView.Client.Services
{
    public static class CategoryDemoService
    {
        //public static List<Category> GetCategories()
        //{
        //    List<Category> Categories = new()
        //    {
        //        new Category{id=1, KategoriKod="001", KategoriAdi="Kombi", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=2, KategoriKod="002", KategoriAdi="Klima", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=3, KategoriKod="001-01", KategoriAdi="Yoğuşmalı", KategoriUstid=1,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=4, KategoriKod="002-01", KategoriAdi="Tavan", KategoriUstid=2,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=5, KategoriKod="003", KategoriAdi="Şohben", KategoriUstid=0,KategoriAltid=0,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=6, KategoriKod="004", KategoriAdi="Radyatör", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=7, KategoriKod="005", KategoriAdi="Pompa", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=8, KategoriKod="004-01", KategoriAdi="Panel", KategoriUstid=6,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=9, KategoriKod="005-01", KategoriAdi="Submersible", KategoriUstid=7,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=10, KategoriKod="006", KategoriAdi="Vanalar", KategoriUstid=0,KategoriAltid=0,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=11, KategoriKod="007", KategoriAdi="Kazanlar", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=12, KategoriKod="008", KategoriAdi="Boru", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=13, KategoriKod="007-01", KategoriAdi="Kombi Kazanı", KategoriUstid=11,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=14, KategoriKod="008-01", KategoriAdi="PVC Boru", KategoriUstid=12,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=15, KategoriKod="009", KategoriAdi="Eşanjörler", KategoriUstid=0,KategoriAltid=0,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=16, KategoriKod="010", KategoriAdi="Fanlar", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=17, KategoriKod="011", KategoriAdi="Kontrol Sistemleri", KategoriUstid=0,KategoriAltid=1,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1},
        //        new Category{id=18, KategoriKod="010-01", KategoriAdi="Tavan Fanı", KategoriUstid=16,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=19, KategoriKod="011-01", KategoriAdi="Otomatik Kontrol", KategoriUstid=17,KategoriAltid=0,KategoryStokBaglanabilir=1, KategoriStokVar = 1, KategoriAktif=1},
        //        new Category{id=20, KategoriKod="012", KategoriAdi="Filtreler", KategoriUstid=0,KategoriAltid=0,KategoryStokBaglanabilir=0, KategoriStokVar = 0, KategoriAktif=1}


        //    };

        //    return Categories;
        //}


        //public static List<KategoriListesiBilgileri> GetCategories()
        //{
        //    List<KategoriListesiBilgileri> Categories = new()
        //    {
        //        new KategoriListesiBilgileri{id=1, kategorikod="001", kategoriadi="Kombi", kategoriustid=0,kategorialtid=1,kategoristokbaglanabilir=0, kategoristokvar = 0, kategoriaktif=1},
        //         new KategoriListesiBilgileri { id = 2, kategorikod = "002", kategoriadi = "Klima", kategoriustid = 0, kategorialtid = 1, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 3, kategorikod = "001-01", kategoriadi = "Yoğuşmalı", kategoriustid = 1, kategorialtid = 0, kategoristokbaglanabilir = 1, kategoristokvar = 1, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 4, kategorikod = "002-01", kategoriadi = "Tavan", kategoriustid = 2, kategorialtid = 0, kategoristokbaglanabilir = 1, kategoristokvar = 1, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 5, kategorikod = "003", kategoriadi = "Şohben", kategoriustid = 0, kategorialtid = 1, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 6, kategorikod = "003-001", kategoriadi = "Şohben alt 1", kategoriustid = 5, kategorialtid = 1, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 7, kategorikod = "003-001-01", kategoriadi = "Şohben alt 1.1", kategoriustid = 6, kategorialtid = 1, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 8, kategorikod = "003-001-02", kategoriadi = "Şohben alt 1.2", kategoriustid = 6, kategorialtid = 0, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 },
        //         new KategoriListesiBilgileri { id = 9, kategorikod = "003-001-02", kategoriadi = "Şohben alt 1.1.1", kategoriustid = 7, kategorialtid = 0, kategoristokbaglanabilir = 0, kategoristokvar = 0, kategoriaktif = 1 }
        //    };

        //    return Categories;
        //}
    }


}
