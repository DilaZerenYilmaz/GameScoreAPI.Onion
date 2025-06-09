using Application.Features.Match.Commands.Update;
using GameScoreAPI.Application.Features.Matchs.Commands.Delete;
using GameScoreAPI.Application.Features.Matchs.Commands;
using GameScoreAPI.Application.Features.Matchs.Queries.GetAll;
using GameScoreAPI.Application.Features.Matchs.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameScoreAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MatchController : ControllerBase
	{
		private readonly IMediator _mediator;

		public MatchController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateMatchCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut]
		public async Task<IActionResult> Update([FromBody] UpdateMatchCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			var result = await _mediator.Send(new DeleteMatchCommand(id));
			return Ok(result);
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _mediator.Send(new GetAllMatchesQuery());
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var result = await _mediator.Send(new GetMatchByIdQuery(id));
			return Ok(result);
		}
	}
}
