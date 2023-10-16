using Newtonsoft.Json;
using XFrame.Ids;
using XFrame.ValueObjects.SingleValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class PieceId : Identity<PieceId>
    {
        #region Constructors

        public PieceId(string value)
            : base(value)
        {

        }

        #endregion
    }
}
