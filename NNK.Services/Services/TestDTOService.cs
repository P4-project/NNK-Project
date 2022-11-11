using NNK.Services.DTO;

namespace NNK.Services.Services
{
    public class TestDTOService : ITestDTOService
    {
        public TestDTOResponse GetTestDTOResponse()
        {
            return new TestDTOResponse { TestString = "MyTestUpdate", TestInt = 25 };
        }
    }
}