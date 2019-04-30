using OpenMahjong.Logic.Common.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenMahjong.Logic.Common.GameObject
{
    public class Wall
    {
        public Wall(Tile[] tiles)
        {
            this.tiles = tiles.Shuffle();
        }

        public Tile this[int index] => tiles[index];

        public int TileCount => tiles.Length;
        
        private readonly Tile[] tiles;
    }
}
