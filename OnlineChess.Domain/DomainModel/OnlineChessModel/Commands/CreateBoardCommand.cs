using OnlineChess.Domain.DomainModel.OnlineChessModel.Entities;
using XFrame.Aggregates.Commands;
using XFrame.Aggregates.ExecutionResults;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Commands
{
    public class CreateBoardCommand
        : Command<Board, BoardId>
    {
        #region Constructors

        public CreateBoardCommand(
            BoardId boardId,
            IReadOnlyList<Block> blocks)
            : base(boardId)
        {
            Blocks = blocks;
        }

        #endregion

        #region Properties

        public IReadOnlyList<Block> Blocks { get; }

        #endregion
    }

    public class CreateBoardCommandHandler
        : CommandHandler<Board, BoardId, CreateBoardCommand>
    {
        #region Virtual Methods

        public override Task<IExecutionResult> ExecuteAsync(
            Board aggregate,
            CreateBoardCommand command,
            CancellationToken cancellationToken)
        {
            aggregate
                .CreateBoard(command.Blocks);

            return Task.FromResult(ExecutionResult.Success(aggregate.Id));
        }

        #endregion
    }
}
