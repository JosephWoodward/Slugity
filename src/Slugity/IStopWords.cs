using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slugity
{
    public interface IStopWords
    {
        void Add(params string[] words);

        void Remove(params string[] words);
    }
}
