using GameScoreAPI.Application.Features.Players.Commands.CreatePlayer;
using GameScoreAPI.Application.Features.Players.Commands.DeletePlayer;
using GameScoreAPI.Application.Features.Players.Commands.UpdatePlayer;
using GameScoreAPI.Application.Features.Players.Queries.GetAllPlayers;
using GameScoreAPI.Application.Features.Players.Queries.GetPlayerById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GameScoreAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlayersController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PlayersController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreatePlayerCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut]
		public async Task<IActionResult> Update([FromBody] UpdatePlayerCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			var result = await _mediator.Send(new DeletePlayerCommand(id));
			return Ok(result);
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = await _mediator.Send(new GetAllPlayersQuery());
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var result = await _mediator.Send(new GetPlayerByIdQuery(id));
			return Ok(result);
		}
	}
}
