using Application.Features.Match.Commands.Update;
using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Commands.Update
{
	public class UpdateMatchCommandHandler : IRequestHandler<UpdateMatchCommand, UpdateMatchResponse>
	{
		private readonly IReadRepository<Match> _readRepository;
		private readonly IWriteRepository<Match> _writeRepository;

		public UpdateMatchCommandHandler(IReadRepository<Match> readRepository,
										 IWriteRepository<Match> writeRepository)
		{
			_readRepository = readRepository;
			_writeRepository = writeRepository;
		}

		public async Task<UpdateMatchResponse> Handle(UpdateMatchCommand request, CancellationToken cancellationToken)
		{
			var match = await _readRepository.GetByIdAsync(request.Id);
			if (match == null)
				throw new Exception("Match not found!");

			// Güncelle
			match.Score = request.Score;
			match.PlayedAt = request.PlayedAt;
			match.PlayerId = request.PlayerId;
			match.UpdatedAt = DateTime.UtcNow;

			await _writeRepository.UpdateAsync(match);

			return new UpdateMatchResponse
			{
				Id = match.Id,
				Message = "Match updated succesfully."
			};
		}
	}
}
