using OnlineChess.Domain.DomainModel.OnlineChessModel.Entities;
using OnlineChess.Domain.DomainModel.OnlineChessModel.Events;
using OnlineChess.Domain.Extensions;
using XFrame.Aggregates;
using XFrame.Specifications.Extensions;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel
{
    public class Board : AggregateRoot<Board, BoardId>
    {
        private IList<Block> _blocks;

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

        private Action<object, string> LazyLoader { get; set; }

        public IList<Block> Blocks
        {
            get => LazyLoader.Load(this, ref _blocks);
            set => _blocks = value;
        }

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        #endregion

        #region Methods

        internal void CreateBoard(IReadOnlyList<Block> blocks)
        {
            AggregateSpecifications.AggregateIsNew.ThrowDomainErrorIfNotSatisfied(this);
            Blocks = blocks.ToList();
            Emit(new CreatedBoardEvent(blocks));
        }

        #endregion
    }
}
