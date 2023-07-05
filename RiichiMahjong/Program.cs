using RiichiMahjong;
using RiichiMahjong.Exceptions;

GetWallAndCode();

void GetWallAndCode()
{
    try
    {
        Wall wall = new Wall();
        wall.GenerateWallAndCode();
        Console.WriteLine(wall.WallCode());
        YakuList yakuList = new YakuList();
        Console.WriteLine(yakuList.FindYakuByName("Riichi").hanOpen);
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