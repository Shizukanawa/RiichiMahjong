using RiichiMahjong.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    internal class YakuList
    {
        private List<Yaku> yakuList = new List<Yaku>();

        /// <summary>
        /// Initializes the default settings 
        /// </summary>
        public YakuList()
        {
            // 1 Han with closed hand
            yakuList.Add(new Yaku("Riichi", 1, 0, false));
            yakuList.Add(new Yaku("Tsumo", 1, 0, false));
            yakuList.Add(new Yaku("Ippatsu", 1, 0, false));
            yakuList.Add(new Yaku("Pinfu", 1, 0, false));
            yakuList.Add(new Yaku("Iipekou", 1, 0, false));
            yakuList.Add(new Yaku("Haitei Raoyue", 1, 1, false));
            yakuList.Add(new Yaku("Houtei Raoyue", 1, 1, false));
            yakuList.Add(new Yaku("Rinshan Kaihou", 1, 1, false));
            yakuList.Add(new Yaku("Chankan", 1, 1, false));
            yakuList.Add(new Yaku("Tanyao", 1, 1, false));

            yakuList.Add(new Yaku("White Dragon", 1, 1, false));
            yakuList.Add(new Yaku("Green Dragon", 1, 1, false));
            yakuList.Add(new Yaku("Red Dragon", 1, 1, false));
            yakuList.Add(new Yaku("East", 1, 1, false));
            yakuList.Add(new Yaku("West", 1, 1, false));
            yakuList.Add(new Yaku("South", 1, 1, false));
            yakuList.Add(new Yaku("North", 1, 1, false));

            // 2 Han with closed hand
            yakuList.Add(new Yaku("Double Riichi", 2, 0, false));
            yakuList.Add(new Yaku("Chanta", 2, 1, false));
            yakuList.Add(new Yaku("Shanshoku Doujun", 2, 1, false));
            yakuList.Add(new Yaku("Ittsu", 2, 1, false));
            yakuList.Add(new Yaku("Toitoi", 2, 2, false));
            yakuList.Add(new Yaku("Sanankou", 2, 2, false));
            yakuList.Add(new Yaku("Sanshoku Doukou", 2, 2, false));
            yakuList.Add(new Yaku("Sankantsu", 2, 2, false));
            yakuList.Add(new Yaku("Chiitoi", 2, 0, false));
            yakuList.Add(new Yaku("Honroutou", 2, 2, false));
            yakuList.Add(new Yaku("Shousangen", 2, 2, false));

            // 3 Han with closed hand
            yakuList.Add(new Yaku("Honitsu", 3, 2, false));
            yakuList.Add(new Yaku("Junchan", 3, 2, false));
            yakuList.Add(new Yaku("Ryanpeikou", 3, 0, false));

            // 6 Han with closed hand
            yakuList.Add(new Yaku("Chinitsu", 6, 5, false));

            // Yakuman
            yakuList.Add(new Yaku("Kazoe Yakuman", 13, 13, true));
            yakuList.Add(new Yaku("Kokushi Musou", 13, 0, true));
            yakuList.Add(new Yaku("Suuankou", 13, 0, true));
            yakuList.Add(new Yaku("Daisangen", 13, 13, true));
            yakuList.Add(new Yaku("Shousuushii", 13, 13, true));
            yakuList.Add(new Yaku("Tsuuiisou", 13, 13, true));
            yakuList.Add(new Yaku("Chinroutou", 13, 13, true));
            yakuList.Add(new Yaku("Ryuuiisou", 13, 13, true));
            yakuList.Add(new Yaku("Chuuren Poutou", 13, 13, true));
            yakuList.Add(new Yaku("Suukantsu", 13, 13, true));
            yakuList.Add(new Yaku("Tenhou", 13, 13, true));
            yakuList.Add(new Yaku("Chiihou", 13, 13, true));

            // Double Yakuman
            yakuList.Add(new Yaku("13-Wait Kokushi Musou", 26, 0, true));
            yakuList.Add(new Yaku("Daisuushii", 26, 26, true));
            yakuList.Add(new Yaku("9-Wait Chuuren Poutou", 26, 26, true));

            // Special Yaku
            yakuList.Add(new Yaku("Nagashi Mangan", 5, 5, true));
        }

        /// <summary>
        /// Adds a yaku to the list
        /// </summary>
        /// <param name="yaku"></param>
        public void AddYakuToList(Yaku yaku)
        {
            yakuList.Add(yaku);
        }

        /// <summary>
        /// Returns a specific yaku based on a string.
        /// </summary>
        /// <param name="yaku"></param>
        /// <returns></returns>
        /// <exception cref="YakuNotFoundException"></exception>
        public Yaku FindYakuByName(string yaku)
        {
            try
            {
                return yakuList.Single(x => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(yaku) == x.name); // Makes sure that yaku is in Title Case, which is how the yakus are written.
            }
            catch (Exception)
            {
                throw new YakuNotFoundException("Yaku not found.");
            }
        }
    }
}
