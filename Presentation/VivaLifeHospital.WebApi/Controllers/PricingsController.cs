using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.PricingCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.PricingQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
             var values =  await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetPricingById(int id)
        {
            var values = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Fiyat Bilgisi Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
           await _mediator.Send(command);
            return Ok("Fiyat Bilgisi Başarıyla Güncellendi");
           
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePricing (int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Fiyat Bilgisi Başarıyla Güncellendi");
        }
    }
}
