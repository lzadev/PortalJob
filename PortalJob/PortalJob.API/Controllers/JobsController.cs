namespace PortalJob.API.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using PortalJob.BusinessLogic;
    using PortalJob.BusinessLogic.Dtos;
    using PortalJob.BusinessLogic.Queries;

    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Response<IEnumerable<VacancyDto>>>> Get()
        {
            var result = await _mediator.Send(new GetAllVacancyQuery());
            return Ok(result);
        }
    }
}
