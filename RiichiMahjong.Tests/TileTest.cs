using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public class TileTest
    {
        [Fact]
        public void Tile_TileCode_ReturnsString()
        {
            var tile = new Tile(1, "z");

            var result = tile.TileCode();

            result.Should().NotBeNullOrWhiteSpace();
        }

        [Theory]
        [InlineData(1, "m", "1m")]
        [InlineData(2, "p", "2p")]
        [InlineData(3, "s", "3s")]
        [InlineData(4, "z", "4z")]
        public void Tile_TileCode_ReturnsCorrectString(int value, string suit, string expected)
        {
            var tile = new Tile(value, suit);

            var result = tile.TileCode();

            result.Should().Be(expected);
        }
    }
}
