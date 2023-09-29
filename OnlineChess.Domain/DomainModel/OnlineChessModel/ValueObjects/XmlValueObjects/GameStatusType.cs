using XFrame.ValueObjects.XmlValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects
{
    [ValueObjectResourcePath("OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects.Mappings.GameStatusType.xml")]
    public class GameStatusType : XmlValueObject
    {
    }

    public class GameStatusTypes : XmlValueObjectLookup<GameStatusType, GameStatusTypes>
    {
        public GameStatusType Ready { get { return FindValueObject("Ready"); } }
        public GameStatusType InProgress { get { return FindValueObject("InProgress"); } }
        public GameStatusType GameOver { get { return FindValueObject("GameOver"); } }

    }
}
