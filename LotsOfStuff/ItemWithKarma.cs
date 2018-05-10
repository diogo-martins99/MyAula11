using System;

namespace Aula11
{
    public abstract class ItemWithKarma : IHasKarma
    {
        static private Random rand = new Random();
        public virtual float Karma { get; }


        public ItemWithKarma()
        {
            Karma = (float)(rand.NextDouble() * 20 - 10);
        }

        public ItemWithKarma (float karma)
        {
            Karma = karma;
        }
    }
}
