using dopNP.Application.DTOs;
using dopNP.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace dopNP.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NetPixController : ControllerBase
    {
        private readonly PixFakeUseCase _pixFakeUseCase;
        private readonly ILogger<NetPixController> _logger;
        public NetPixController(
            ILogger<NetPixController> logger,
            PixFakeUseCase pixFakeUseCase
            )
        {
            _pixFakeUseCase = pixFakeUseCase;
            _logger = logger;
        }

        [HttpPost("gerar-pix-fake")]
        public IActionResult GerarPixFakeAsync([FromBody] PixRequestDto requestDto)
        {
            _logger.LogInformation("Iniciando a geração do Pix Fake para a chave: {ChavePix}", requestDto);

            var result = _pixFakeUseCase.Execute(requestDto);

            return Ok(result);
        }

    }
}
