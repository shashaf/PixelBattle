using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerPB
{
    public class World
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte[,] Pixels { get; set; }
        public List<string> Players { get; set; } = new List<string>();
        public Dictionary<string, DateTime> LastPixelTime { get; set; } = new();
        public Dictionary<string, int> PlayerScores { get; set; } = new(); 

        public World(int id, string name, int width, int height) 
        {
            Id = id;
            Name = name;
            Width = width;
            Height = height;
            Pixels = new byte[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    Pixels[x, y] = 0;
        }
    }
}
