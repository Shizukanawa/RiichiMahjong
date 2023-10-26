using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public class YakuTest
    {
        [Fact]
        public void Yaku_Name_ReturnsName()
        {
            //Arrange
            var yaku = new Yaku("test", 4, 3, false); 

            //Act
            var result = yaku.Name;

            //Assert
            result.Should().Be("test");
        }

        [Fact]
        public void Yaku_HanClosed_ReturnsHanClosed()
        {
            var yaku = new Yaku("test", 5, 4, false);

            var result = yaku.HanClosed;

            result.Should().Be(5);
        }

        [Fact]
        public void Yaku_HanOpen_ReturnsHanOpen()
        {
            var yaku = new Yaku("test", 3, 2, false);

            var result = yaku.HanOpen;

            result.Should().Be(2);
        }

        [Fact]
        public void Yaku_IsYakuman_ReturnsFalse()
        {
            var yaku = new Yaku("test", 1, 2, false);

            var result = yaku.IsYakuman;

            result.Should().BeFalse();
        }

        [Fact]
        public void Yaku_IsYakuman_ReturnsTrue()
        {
            var yaku = new Yaku("test", 1, 2, true);

            var result = yaku.IsYakuman;

            result.Should().BeTrue();
        }
    }
}