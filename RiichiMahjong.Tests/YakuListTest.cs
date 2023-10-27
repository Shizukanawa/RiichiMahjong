using FluentAssertions;

namespace RiichiMahjong.Tests
{
    public  class YakuListTest
    {
        [Theory]
        [InlineData("Riichi", 1, 0, false)] // 1 Han
        [InlineData("Tsumo", 1, 0, false)]
        [InlineData("Ippatsu", 1, 0, false)]
        [InlineData("Pinfu", 1, 0, false)]
        [InlineData("Iipekou", 1, 0, false)]
        [InlineData("Haitei Raoyue", 1, 1, false)]
        [InlineData("Houtei Raoyue", 1, 1, false)]
        [InlineData("Rinshan Kaihou", 1, 1, false)]
        [InlineData("Chankan", 1, 1, false)]
        [InlineData("Tanyao", 1, 1, false)]
        [InlineData("White Dragon", 1, 1, false)]
        [InlineData("Green Dragon", 1, 1, false)]
        [InlineData("Red Dragon", 1, 1, false)]
        [InlineData("East", 1, 1, false)]
        [InlineData("West", 1, 1, false)]
        [InlineData("South", 1, 1, false)]
        [InlineData("North", 1, 1, false)]
        [InlineData("Double Riichi", 2, 0 , false)] // 2 Han
        [InlineData("Chanta", 2, 1, false)]
        [InlineData("Sanshoku Doujun", 2, 1, false)]
        [InlineData("Ittsu", 2, 1, false)]
        [InlineData("Toitoi", 2, 2, false)]
        [InlineData("Sanankou", 2, 2, false)]
        [InlineData("Sanshoku Doukou", 2, 2, false)]
        [InlineData("Sankantsu", 2, 2, false)]
        [InlineData("Chiitoi", 2, 0, false)]
        [InlineData("Honroutou", 2, 2, false)]
        [InlineData("Shousangen", 2, 2, false)]
        [InlineData("Honitsu", 3, 2, false)] // 3 Han
        [InlineData("Junchan", 3, 2, false)]
        [InlineData("Ryanpeikou", 3, 0, false)]
        [InlineData("Chinitsu", 6, 5, false)] // 6 Han
        [InlineData("Kazoe Yakuman", 13, 13, true)] // Yakuman
        [InlineData("Kokushi Musou", 13, 0, true)]
        [InlineData("Suuankou", 13, 0, true)]
        [InlineData("Daisangen", 13, 13, true)]
        [InlineData("Shousuushii", 13, 13, true)]
        [InlineData("Tsuuiisou", 13, 13, true)]
        [InlineData("Chinroutou", 13, 13, true)]
        [InlineData("Ryuuiisou", 13, 13, true)]
        [InlineData("Chuuren Poutou", 13, 0, true)]
        [InlineData("Suukantsu", 13, 13, true)]
        [InlineData("Tenhou", 13, 0, true)]
        [InlineData("Chiihou", 13, 0, true)]
        [InlineData("13-Wait Kokushi Musou", 26, 0, true)] // Double Yakuman
        [InlineData("Daisuushii", 26, 26, true)]
        [InlineData("9-Wait Chuuren Poutou", 26, 0 , true)]
        [InlineData("Nagashi Mangan", 5, 5, false)] // Special Yaku
        public void YakuList_FindYakuByName_ReturnsYaku(string name, int hanClosed, int hanOpen, bool isYakuman)
        {
            var list = new YakuList();

            var result = list.FindYakuByName(name);

            result.Should().BeOfType<Yaku>();
            result.HanClosed.Should().Be(hanClosed);
            result.HanOpen.Should().Be(hanOpen);
            result.IsYakuman.Should().Be(isYakuman);
        }
    }
}
