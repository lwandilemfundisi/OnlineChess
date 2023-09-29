using XFrame.ValueObjects.XmlValueObjects;

namespace OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects
{
    [ValueObjectResourcePath("OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects.Mappings.ColorType.xml")]
    public class ColorType : XmlValueObject
    {
        #region Properties

        public bool YAxisDirectionIsUp { get; set; }

        #endregion

        #region Virtual Methods

        protected override XmlValueObject OnCreateClone()
        {
            return new ColorType();
        }

        protected override XmlValueObject OnClone(XmlValueObject valueObject)
        {
            var clone = (ColorType)valueObject;
            clone.YAxisDirectionIsUp = YAxisDirectionIsUp;
            return base.OnClone(valueObject);
        }

        #endregion
    }

    public class ColorTypes : XmlValueObjectLookup<ColorType, ColorTypes>
    {
        public ColorType Black { get { return FindValueObject("Black"); } }

        public ColorType White { get { return FindValueObject("White"); } }
    }
}
