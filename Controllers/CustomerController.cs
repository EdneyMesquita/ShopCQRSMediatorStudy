using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}