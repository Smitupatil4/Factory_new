using factory.business;
using Factory.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Factory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactoryController : Controller
    {
        private readonly factory1 _factory;

        public FactoryController(factory1 factory)
        {
            this._factory = factory;
        }
        [HttpPost]
        public async Task<string> Index(DTO dto)
        {
            var result = string.Empty;
            var module = _factory.GetModuleService(dto.Id);

            if (module != null)
            {
                result = await module.Invoke(dto);
            }
            return result.ToString();
        }
    }
}
