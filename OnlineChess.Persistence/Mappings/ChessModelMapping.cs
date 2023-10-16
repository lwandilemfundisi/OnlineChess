using Microsoft.EntityFrameworkCore;
using OnlineChess.Domain.DomainModel.OnlineChessModel;
using OnlineChess.Domain.DomainModel.OnlineChessModel.Entities;
using OnlineChess.Domain.DomainModel.OnlineChessModel.ValueObjects.XmlValueObjects;
using XFrame.Persistence.EFCore.ValueObjectConverters;

namespace OnlineChess.Persistence.Mappings
{
    public static class ChessModelMapping
    {
        public static ModelBuilder ChessModelMap(this ModelBuilder modelBuilder)
        {
            #region Board

            modelBuilder
                .Entity<Board>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<BoardId>());

            #endregion

            #region Block

            modelBuilder
                .Entity<Block>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<BlockId>());

            modelBuilder
                .Entity<Block>()
                .Property(o => o.BlockColor)
                .HasConversion(new ValueObjectValueConverter<ColorType, ColorTypes>());

            #endregion

            #region Piece

            modelBuilder
                .Entity<Piece>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<PieceId>());

            modelBuilder
                .Entity<Piece>()
                .Property(o => o.PieceColor)
                .HasConversion(new ValueObjectValueConverter<ColorType, ColorTypes>());

            modelBuilder
                .Entity<Piece>()
                .Property(o => o.PieceName)
                .HasConversion(new ValueObjectValueConverter<PieceNameType, PieceNameTypes>());

            #endregion

            #region Player

            modelBuilder
                .Entity<Player>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<PlayerId>());

            #endregion

            #region Relationships

            modelBuilder
                .Entity<Block>()
                .HasOne<Board>()
                .WithMany(c => c.Blocks);

            modelBuilder
                .Entity<Piece>()
                .HasOne<Block>();

            modelBuilder
                .Entity<Board>()
                .HasOne(c => c.Player1);

            modelBuilder
                .Entity<Board>()
                .HasOne(c => c.Player2);

            #endregion

            return modelBuilder;
        }
    }
}
