using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public class HandTest
    {
        [Fact]
        public void Hand_HandCode_ReturnsCorrectString()
        {
            List<Tile> tiles = new List<Tile>();
            tiles.Add(new Tile(1, "z"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            Hand hand = new Hand(tiles);

            var result = hand.HandCode();

            result.Should().Be("1111m1111p1111s1z");
        }

        [Fact]
        public void Hand_DiscardTile_ReturnsCorrectHandCode()
        {
            List<Tile> tiles = new List<Tile>();
            tiles.Add(new Tile(1, "z"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "m"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "p"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            tiles.Add(new Tile(1, "s"));
            Hand hand = new Hand(tiles);

            hand.DrawTile(new Tile(1, "z"));
            hand.DiscardTile(tiles[2]); // 1m is getting discarded here.
            var result = hand.HandCode();

            result.Should().Be("111m1111p1111s11z");
        }
    }
}
