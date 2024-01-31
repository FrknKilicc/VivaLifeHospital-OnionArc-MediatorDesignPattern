using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.BannerCommands;
using VivaLifeHospital.Application.Features.Mediator.Handlers.BannerHandlers;
using VivaLifeHospital.Application.Features.Mediator.Queries.BannerQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BannerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _mediator.Send(new GetBannerQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Banner Bilgisi Başarıyla Eklendi");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Banner Bilgisi Başarıyla Güncellendi");

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _mediator.Send(new RemoveBannerCommand(id));
            return Ok("Banner Bilgisi Başarıyla Silindi");
        }
    }
}
