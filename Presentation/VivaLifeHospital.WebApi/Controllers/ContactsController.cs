using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.ContactQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _mediator.Send(new GetContactQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgileri Başarıyla Kayıt Edildi.");
        }
    }
}
