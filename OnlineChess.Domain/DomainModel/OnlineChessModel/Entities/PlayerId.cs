using Newtonsoft.Json;
using XFrame.Ids;
using XFrame.ValueObjects.SingleValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class PlayerId : Identity<BlockId>
    {
        #region Constructors

        public PlayerId(string value)
            : base(value)
        {

        }

        #endregion
    }
}
