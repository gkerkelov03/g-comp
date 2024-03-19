using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    [Description("Listing 2.12")]
    class ExpandedForEach
    {
        static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }
            yield return 20;
        }
        class enumer : IEnumerator<int>
        {
            public int Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public static IEnumerator<int> gosho()
        {            
            return new enumer();
        }
        static void Main()
        {
            
            IEnumerable<int> enumerable = CreateSimpleIterator();
            using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {                    
                    int value = enumerator.Current;
                    Console.WriteLine(value);
                }
            }
        }
    }
}
