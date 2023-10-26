using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public class TileListTest
    {
        [Theory]
        [InlineData(0x01, "1m")]
        [InlineData(0x14, "4p")]
        [InlineData(0x25, "5s")]
        [InlineData(0x37, "7z")]
        [InlineData(0x105, "0m")]
        [InlineData(0x115, "0p")]
        [InlineData(0x125, "0s")]
        public void TileList_TiletoString_ReturnsCorrectString(int tile, string expected)
        {
            var tilelist = new TileList();

            var result = tilelist.TileToString(tile);

            result.Should().Be(expected);
        }

        [Fact]
        public void Tile_ToTile_ReturnsCorrectTypeTile()
        {
            var tilelist = new TileList();

            var expected = new Tile(2, "z");
            var result = tilelist.ToTile("2z");

            result.Should().BeEquivalentTo(expected);
        }
    }
}
