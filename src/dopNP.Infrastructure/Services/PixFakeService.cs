using dopNP.Domain.Interfaces;

namespace dopNP.Infrastructure.Services
{
    public class PixFakeService : IPixFakeService
    {
        public string GerarPixFake(string PayName, decimal Qtd)
        {
            return $"Pix Fake gerado com sucesso! Pay: {PayName}, Qtd: {Qtd}";
        }

        public Task<string> GerarPixFakeAsync(string PayName, decimal Qtd)
        {
            return Task.FromResult(GerarPixFake(PayName, Qtd));
        }
    }
}
