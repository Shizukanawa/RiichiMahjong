using RiichiMahjong;
using RiichiMahjong.Exceptions;

GetWallAndCode();

void GetWallAndCode()
{
    try
    {
        Wall wall = new Wall();
        Console.WriteLine(wall.WallCode());
        YakuList yakuList = new YakuList();
        Console.WriteLine(yakuList.FindYakuByName("13-wait kokushi musou").hanOpen);
        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
    catch (TileNotFoundException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (YakuNotFoundException e)
    {
        Console.WriteLine(e.Message);
    }
}