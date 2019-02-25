using System;

namespace HumphreyJ.NetCore.Autostereogram
{

    public class Autostereogram<T>
    {

        public T[][] Pattern => pattern.Data;
        public int[][] Map => map.Data;
        public T[][] Photogram => photogram.Data;

        private Image<T> pattern;
        private Image<int> map;
        private Image<T> photogram;

        public Autostereogram(T[][] pattern, int[][] map)
        {
            this.pattern = new Image<T>(pattern);
            this.map = new Image<int>(map);
            this.photogram = GetPhotogram();
        }

        private Image<T> GetPhotogram()
        {
            var photogram = new Image<T>(new T[map.Height][]);
            for (var y = 0; y < map.Height; y++)
            {
                photogram.Data[y] = new T[map.Width + pattern.Width];
                for (var x = 0; x < photogram.Width; x++)
                {
                    var patternX = x % pattern.Width;
                    var patternY = y % pattern.Height;
                    photogram.Data[y][x] = pattern.Data[patternY][patternX];
                }

                for (var x = 0; x < map.Width; x++)
                {
                    var sourceX = x + pattern.Width - map.Data[y][x];
                    var sourceY = y;
                    photogram.Data[sourceY][sourceX] = photogram.Data[y][x];
                }
            }
            return photogram;

        }

    }
}