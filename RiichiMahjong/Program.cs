﻿using RiichiMahjong;
using RiichiMahjong.Exceptions;

GetWallAndCode();

void GetWallAndCode()
{
    try
    {
        Wall wall = new Wall();
        //wall.ReadWallCode("275s5p6229m4p9s");
        Console.WriteLine(wall.WallCode());
        YakuList yakuList = new YakuList();
        Console.WriteLine(yakuList.FindYakuByName("13-wait kokushi musou").HanOpen);
        
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
        Console.WriteLine(hand.HandCode());

        hand.DrawTile(new Tile(1, "z"));
        Tile tsumogiri = hand.GetTsumogiri();
        Console.WriteLine(tsumogiri.ToString());
        hand.DiscardTile(tsumogiri);

        //hand.DiscardTile(tiles[2]);

        Console.WriteLine(hand.HandCode());

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
    catch (HandSizeExceededException e)
    {
        Console.WriteLine(e.Message);
    }
}