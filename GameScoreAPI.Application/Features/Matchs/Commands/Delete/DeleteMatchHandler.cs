using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Commands.Delete
{
	public class DeleteMatchHandler : IRequestHandler<DeleteMatchCommand, DeleteMatchResponse>
	{
		private readonly IWriteRepository<Match> _writeRepository;
		private readonly IReadRepository<Match> _readRepository;

		public DeleteMatchHandler(IWriteRepository<Match> writeRepository, IReadRepository<Match> readRepository)
		{
			_writeRepository = writeRepository;
			_readRepository = readRepository;
		}

		public async Task<DeleteMatchResponse> Handle(DeleteMatchCommand request, CancellationToken cancellationToken)
		{
			var match = await _readRepository.GetByIdAsync(request.Id);

			if (match == null)
			{
				return new DeleteMatchResponse
				{
					IsSuccess = false,
					Message = "Maç bulunamadı. Silinemedi 😢"
				};
			}

			await _writeRepository.DeleteAsync(match);

			return new DeleteMatchResponse
			{
				IsSuccess = true,
				Message = "Maç başarıyla silindi 🧹"
			};
		}
	}
}
