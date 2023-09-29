using XFrame.Aggregates.Entities;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    public class Player : Entity<PlayerId>
    {
        #region Properties

        public string PlayerName { get; set; }

        #endregion
    }
}
