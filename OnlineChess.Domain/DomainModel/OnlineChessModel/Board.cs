using XFrame.Aggregates;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel
{
    public class Board : AggregateRoot<Board, BoardId>
    {
        #region Constructors

        public Board()
            : base(null)
        {

        }

        public Board(BoardId boardId)
            : base(boardId)
        {

        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
