
namespace products.Services
{
    public class IdGeneratorService
    {
        public string Generate() => Guid.NewGuid().ToString();
    }
}
