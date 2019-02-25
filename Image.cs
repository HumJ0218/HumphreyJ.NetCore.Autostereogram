using System;

namespace HumphreyJ.NetCore.Autostereogram
{
    internal class Image<T>
    {
        public Image(T[][] data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public T[][] Data { get; private set; }
        public int Width => Data[0].Length;
        public int Height => Data.Length;
    }
}