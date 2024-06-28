using DenemeTreeView.Shared;
using Microsoft.AspNetCore.Components;

namespace DenemeTreeView.Client.Components;

public partial class CustomTreeviewComponent
{
    [Parameter]
    public List<KategoriListesiBilgileri> Categories { get; set; }
    [Parameter]
    public bool IsToggleCategory { get; set; }
    // public List<Category> Categories { get; set; }


    Dictionary<int, bool> CategoryStates = new Dictionary<int, bool>(); /* Kategorilerin durumunu tutar */
    Dictionary<int, Dictionary<int, bool>> SubCategoryStates = new Dictionary<int, Dictionary<int, bool>>();
    private int expandedCategoryId = -1; // Başlangıçta hiçbiri açık değil

    bool HasChildren(int parentId) =>
       Categories.Any(c => c.kategoriustid == parentId.ToString()); /* Bir kategorinin alt kategorileri var mı kontrol eder */

    IEnumerable<KategoriListesiBilgileri> GetChildren(int parentId) =>
        Categories.Where(c => c.kategoriustid == parentId.ToString()); /* Bir kategorinin alt kategorilerini getirir */

    RenderFragment RenderChildren(int parentId) /* Alt kategorileri görüntüler */
    {
        return builder =>
        { // RenderFragment döndüren bir lambda fonksiyonu başlatır. Builder, UI bileşenlerini oluşturmak için kullanılır.

            if(Categories == null)
            {

            }
            else
            {
                foreach(var childCategory in GetChildren(parentId))
                { // Belirli bir üst kategorinin alt kategorileri üzerinde döngü oluşturur.

                    #region Ana Div Elementi

                    builder.OpenElement(0, "div"); // Bir <div> öğesi başlatır.
                    builder.AddAttribute(1, "class", "category-div");

                    #region Span Elementi

                    builder.OpenElement(2, "span"); // Bir <span> öğesi başlatır.


                    builder.AddAttribute(3, "style", "cursor:pointer"); // Span öğesine bir stili ekler.

                    builder.AddAttribute(4, "class", "category-sub"); // Span öğesine bir sınıf ekler.

                    builder.AddAttribute(5, "onclick", EventCallback.Factory.Create(this, () => ToggleSubCategory(childCategory))); // Tıklama olayı ekler ve ToggleCategory metodunu çağırır.

                    builder.OpenElement(6, "a"); // Bir <a> öğesi başlatır.
                    builder.AddAttribute(7, "href", $"{childCategory.NavigationUrl}");
                    builder.AddAttribute(8, "class", "category-link");
                    builder.AddContent(9, childCategory.kategoriadi); // Span öğesine kategori adını ekler.
                    builder.CloseElement(); // </a> öğesini kapatır.

                    #region SVG Elementi
                    if(childCategory.kategorialtid == 1)
                    {
                        // En sağa SVG ikonunu eklemek için
                        builder.OpenElement(10, "svg"); // SVG ikonunu <svg> öğesi başlatır.
                        builder.AddAttribute(11, "xmlns", "http://www.w3.org/2000/svg");
                        builder.AddAttribute(12, "width", "20");
                        builder.AddAttribute(13, "height", "20");
                        builder.AddAttribute(14, "fill", "currentColor");
                        builder.AddAttribute(15, "class", "bi bi-chevron-right"); // Örnek bir SVG ikonu
                        builder.AddAttribute(16, "viewBox", "0 0 16 16");
                        builder.AddAttribute(17, "style", "margin-left: 5px;"); // Sağa hizalama için boşluk ekler
                        builder.OpenElement(18, "path");
                        builder.AddAttribute(19, "d", "M4.646 5.646a.5.5 0 0 1 .708 0L8 8.293l2.646-2.647a.5.5 0 1 1 .708.708l-3 3a.5.5 0 0 1-.708 0l-3-3a.5.5 0 0 1 0-.708z");
                        builder.CloseElement(); // PATH elementini kapatır
                        builder.CloseElement(); // SVG ikonunu <svg> öğesini kapatır.
                        #endregion
                    }
                    else
                    {

                    }


                    builder.CloseElement(); // </span> öğesini kapatır.

                    if(IsCategoryOpen(childCategory) && HasChildren(int.Parse(childCategory.id)))
                    { // Alt kategorilerin varlığını ve açık olup olmadığını kontrol eder.

                        if(childCategory.kategorialtid == 1 && GetChildren(int.Parse(childCategory.kategoriustid)).Count() > 0)
                        { // Alt kategorilerin varlığını ve birden fazla olup olmadığını kontrol eder.

                            builder.OpenElement(20, "a"); // Bir <span> öğesi başlatır.

                            builder.AddAttribute(21, "href", $"{childCategory.NavigationUrl}");

                            builder.AddAttribute(22, "style", "cursor:pointer; font-weight:600;"); // Span öğesine bir stili ekler.

                            builder.AddAttribute(23, "class", "all-category text-dark"); // Span öğesine bir sınıf ekler.

                            builder.AddAttribute(24, "onclick", EventCallback.Factory.Create(this, () => SelectAll(childCategory))); // Tıklama olayı ekler ve SelectAll metodunu çağırır.

                            builder.AddContent(25, "Tümü Seç"); // Span öğesine "Tümü Seç" içeriğini ekler.

                            builder.CloseElement(); // </span> öğesini kapatır.

                        }

                        builder.OpenElement(26, "span"); // Bir <span> öğesi başlatır.

                        builder.AddContent(27, RenderChildren(int.Parse(childCategory.id))); // Alt kategorileri içeren bir RenderFragment'i <ul> öğesine ekler.


                        builder.CloseElement(); // </div> öğesini kapatır.
                    }

                    #endregion

                    builder.CloseElement(); // </div> öğesini kapatır.

                    #endregion
                }
            }
        }; // Lambda fonksiyonunu sonlandırır.

    }

    void ToggleCategory(KategoriListesiBilgileri category)
    {
        // Tıklanan kategorinin durumunu tersine çevir
        CategoryStates[int.Parse(category.id)] = !IsCategoryOpen(category);

        // Eğer tıklanan kategori bir ana kategori ise
        if(category.kategoriustid == null)
        {
            // Diğer ana kategorilerin durumunu kapat
            foreach(var otherCategory in Categories.Where(c => c.id != category.id && c.kategoriustid == null))
            {
                if(IsToggleCategory)
                {
                    CategoryStates[int.Parse(otherCategory.id)] = false;
                    // Kapanan ana kategorinin alt kategorilerinin durumunu kapat
                    UpdateChildCategoryStates(otherCategory, false);
                }
            }
        }
        else
        {

            // Tıklanan kategori bir alt kategori ise
            // Kategorinin üst kategorisini bul
            var parentCategory = Categories.FirstOrDefault(c => c.id == category.kategoriustid);

            // Tıklanan kategorinin üst kategorisi başka bir ana kategori ise
            if(parentCategory != null && int.Parse(parentCategory.kategoriustid) == 0)
            {
                // Diğer ana kategorilerin durumunu kapat
                foreach(var otherCategory in Categories.Where(c => c.id != parentCategory.id && c.kategoriustid == null))
                {
                    CategoryStates[int.Parse(otherCategory.id)] = false;
                    // Kapanan ana kategorinin alt kategorilerinin durumunu kapat
                    if(IsToggleCategory)
                    {
                        UpdateChildCategoryStates(otherCategory, true);
                    }
                }
            }
            else
            {
                // Tıklanan kategori bir alt kategori ise
                // Kategorinin alt kategorilerinin durumunu güncelle
                if(IsToggleCategory)
                {
                    UpdateChildCategoryStates(category, IsCategoryOpen(category));
                }

            }

        }
    }

    void ToggleSubCategory(KategoriListesiBilgileri category)
    {

        // Tıklanan alt kategorinin durumunu tersine çevir
        CategoryStates[int.Parse(category.id)] = !IsCategoryOpen(category);

        // Eğer tıklanan kategori bir ana kategori değilse
        if(int.Parse(category.kategoriustid) != 0)
        {


            // Kategorinin açık olduğu durumda diğer alt kategorileri kapat
            if(IsCategoryOpen(category))
            {
                var parentCategory = Categories.FirstOrDefault(c => c.id == category.kategoriustid);
                if(parentCategory != null)
                {
                    // Kapanan alt kategorinin diğer alt kategorilerinin durumunu kapat
                    foreach(var otherChildCategory in GetChildren(int.Parse(parentCategory.id)).Where(c => c.id != category.id))
                    {
                        if(IsToggleCategory)
                        {
                            UpdateChildCategoryStates(otherChildCategory, false);
                        }

                    }
                }
            }

        }
    }

    void UpdateChildCategoryStates(KategoriListesiBilgileri category, bool isOpen)
    {
        // Kategorinin durumunu ayarla
        CategoryStates[int.Parse(category.id)] = isOpen;

        // Kategorinin alt kategorilerini kontrol et
        foreach(var childCategory in Categories.Where(c => c.kategoriustid == category.id))
        {
            UpdateChildCategoryStates(childCategory, isOpen);
        }
    }

    bool IsCategoryOpen(KategoriListesiBilgileri category)
    {
        if(!CategoryStates.ContainsKey(int.Parse(category.id)))
        {
            CategoryStates.Add(int.Parse(category.id), false);
        }
        return CategoryStates[int.Parse(category.id)];
    }

    void SelectAll(KategoriListesiBilgileri category)  /* Tüm alt kategorileri seçer ve her biri için link işlemi */
    {
        Console.WriteLine(category);
    }
}
