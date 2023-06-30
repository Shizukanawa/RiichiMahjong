using RiichiMahjong;

GetWallAndCode();

void GetWallAndCode()
{
    Wall wall = new Wall();
    wall.GenerateWallAndCode();
    Console.WriteLine(wall.WallCode());
}