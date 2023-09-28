using XFrame.ValueObjects.XmlValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects
{
    [ValueObjectResourcePath("OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects.Mappings.PieceNameType.xml")]
    public class PieceNameType : XmlValueObject
    {
        #region Properties

        public string Image { get; set; }

        #endregion

        #region Virtual Methods

        protected override XmlValueObject OnCreateClone()
        {
            return new PieceNameType();
        }

        protected override XmlValueObject OnClone(XmlValueObject valueObject)
        {
            var clone = (PieceNameType)valueObject;
            clone.Image = Image;
            return base.OnClone(valueObject);
        }

        #endregion
    }

    public class PieceNameTypes : XmlValueObjectLookup<PieceNameType, PieceNameTypes>
    {
        public PieceNameType Pawn { get { return FindValueObject("Pawn"); } }
        public PieceNameType King { get { return FindValueObject("King"); } }
        public PieceNameType Queen { get { return FindValueObject("Queen"); } }
        public PieceNameType Bishop { get { return FindValueObject("Bishop"); } }
        public PieceNameType Night { get { return FindValueObject("Night"); } }
        public PieceNameType Rook { get { return FindValueObject("Rook"); } }
    }
}
