using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongListSample
{
    public class MyDataFactory
    {
        public IEnumerable<MyData> ALongList()
        {
            Random r = new Random();
            return Enumerable.Range(0, 10000).Select(x => new MyData { Text = $"sample {x}", Number = r.Next(400) }).ToList();
        }
    }
}
