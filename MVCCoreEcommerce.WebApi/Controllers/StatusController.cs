using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet]
        public IActionResult StatusList()
        {
            var value = _statusService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddStatus(Status status)
        {
            _statusService.TAdd(status);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStatus(int id)
        {
            var value = _statusService.TGetByID(id);
            _statusService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStatus(Status status)
        {
            _statusService.TUpdate(status);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            var value = _statusService.TGetByID(id);
            return Ok(value);
        }
    }
}
