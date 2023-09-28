using Newtonsoft.Json;
using XFrame.Ids;
using XFrame.ValueObjects.SingleValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class BoardId : Identity<BoardId>
    {
        #region Constructors

        public BoardId(string value)
            : base(value)
        {

        }

        #endregion
    }
}
