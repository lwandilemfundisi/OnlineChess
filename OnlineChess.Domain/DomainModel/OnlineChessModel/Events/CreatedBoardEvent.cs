using OnlineChess.Domain.DomainModel.OnlineChessModel.Entities;
using XFrame.Aggregates.Events;
using XFrame.Aggregates.Events.AggregateEvents;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Events
{
    [EventVersion("CreatedBoard", 1)]
    public class CreatedBoardEvent : AggregateEvent<Board, BoardId>
    {
        #region Constructors

        public CreatedBoardEvent(IReadOnlyList<Block> blocks)
        {
            Blocks = blocks;
        }

        #endregion

        #region Properties

        public IReadOnlyList<Block> Blocks { get; }

        #endregion
    }
}
