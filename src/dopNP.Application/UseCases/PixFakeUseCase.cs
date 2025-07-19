using dopNP.Application.DTOs;
using dopNP.Domain.Interfaces;

namespace dopNP.Application.UseCases
{
    public class PixFakeUseCase
    {
        private readonly IPixFakeService _pixFakeService;

        public PixFakeUseCase(IPixFakeService pixFakeService)
        {
            _pixFakeService = pixFakeService;
        }

        public string Execute(PixRequestDto requestDto)
        {
            if (requestDto == null)
            {
                throw new ArgumentNullException(nameof(requestDto), "Request DTO cannot be null");
            }
            if (string.IsNullOrWhiteSpace(requestDto.PayName))
            {
                throw new ArgumentException("PayName cannot be null or empty", nameof(requestDto.PayName));
            }
            if (requestDto.Qtd <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(requestDto.Qtd), "Qtd must be greater than zero");
            }
            return _pixFakeService.GerarPixFakeAsync(requestDto.PayName, requestDto.Qtd).GetAwaiter().GetResult();
        }
    }
}
