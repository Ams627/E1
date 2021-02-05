using System.Collections.Generic;

namespace E1
{
    public interface IKvStore
    {
        void Add(string key, object value);
        IEnumerator<KeyValuePair<string, object>> GetEnumerator();
    }
}