using Microsoft.AspNetCore.Mvc;
using OnlineChess.Domain.DomainModel.OnlineChessModel;
using OnlineChess.Domain.DomainModel.OnlineChessModel.Commands;
using OnlineChess.Domain.Extensions;
using XFrame.Aggregates.Commands;

namespace OnlineChess.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChessController : ControllerBase
    {
        private readonly ICommandBus _commandBus;

        public ChessController(
            ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        [HttpPost("createboard")]
        public async Task<IActionResult> CreateBoard()
        {
            return Ok(await _commandBus
                .PublishAsync(
                new CreateBoardCommand(
                    BoardId.New,
                    ChessExtensions.BuildBoard().PlaceAllPieces()), CancellationToken.None));
        }
    }
}
