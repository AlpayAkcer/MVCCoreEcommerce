using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly ISettingService _settingService;

        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpGet]
        public IActionResult SettingList()
        {
            var value = _settingService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddSetting(Setting setting)
        {
            _settingService.TAdd(setting);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSetting(int id)
        {
            var value = _settingService.TGetByID(id);
            _settingService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSetting(Setting setting)
        {
            _settingService.TUpdate(setting);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSetting(int id)
        {
            var value = _settingService.TGetByID(id);
            return Ok(value);
        }
    }
}
