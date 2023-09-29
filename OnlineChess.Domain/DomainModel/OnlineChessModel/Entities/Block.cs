using OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects;
using OnlineChess.Domain.Extensions;
using XFrame.Aggregates.Entities;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    public class Block : Entity<BlockId>
    {
        private Piece _piece;

        #region Properties

        private Action<object, string> LazyLoader { get; set; }

        public Piece Piece
        {
            get => LazyLoader.Load(this, ref _piece);
            set => _piece = value;
        }

        public ColorType BlockColor { get; set; }

        public uint XCoordinate { get; set; }

        public uint YCoordinate { get; set; }

        #endregion
    }
}
