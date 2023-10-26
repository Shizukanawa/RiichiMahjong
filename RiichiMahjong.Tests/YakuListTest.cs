using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public  class YakuListTest
    {
        [Fact]
        public void YakuList_FindYakuByName_ReturnsYaku()
        {
            var list = new YakuList();
            var name = "Riichi";

            var result = list.FindYakuByName(name);

            result.Should().BeOfType<Yaku>();
        }
    }
}
