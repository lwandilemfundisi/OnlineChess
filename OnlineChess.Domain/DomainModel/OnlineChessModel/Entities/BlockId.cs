using Newtonsoft.Json;
using XFrame.Ids;
using XFrame.ValueObjects.SingleValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.Entities
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class BlockId : Identity<BlockId>
    {
        #region Constructors

        public BlockId(string value)
            : base(value)
        {

        }

        #endregion
    }
}
