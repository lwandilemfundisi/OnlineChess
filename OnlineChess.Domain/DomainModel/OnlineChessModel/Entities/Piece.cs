using OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects;
using XFrame.Aggregates.Entities;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    public class Piece : Entity<PieceId>
    {
        #region Properties

        public PieceNameType PieceName { get; set; }

        public ColorType PieceColor { get; set; }

        public uint XCoordinate { get; set; }

        public uint YCoordinate { get; set; }

        public bool HasMovedSinceStart { get; set; }

        #endregion
    }
}
