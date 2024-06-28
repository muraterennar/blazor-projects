using DenemeTreeView.Server.Services;
using DenemeTreeView.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DenemeTreeView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<Sonuc<List<KategoriListesiBilgileri>>> Get()
        {
            try
            {
                ICategoryService categoryService = new CategoryService();
                Sonuc<List<KategoriListesiBilgileri>> sonuc = new();
                sonuc = await categoryService.KategoriListesiniAl();
                return sonuc;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
