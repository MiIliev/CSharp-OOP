using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    internal class RandomList : List<string>
    {
        private Random rand = new Random();
        public string RandomString()
        {            
            return this[rand.Next(0, this.Count)];
        }
    }
}
