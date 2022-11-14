using Microsoft.AspNetCore.Mvc;
using NNK.Services.DTO;
using NNK.Services.Services;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestDTOService _dtoService;
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, ITestDTOService dTOService)
        {
            _logger = logger;
            _dtoService = dTOService;
        }

        [HttpGet(Name = "GetTestObject")]
        public TestDTOResponse Get()
        {
            TestDTOResponse DTO = new TestDTOResponse();

            return _dtoService.GetTestDTOResponse();
        }
    }
}