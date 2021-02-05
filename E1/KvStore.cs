using System.Collections;
using System.Collections.Generic;

namespace E1
{
    public class KvStore : IEnumerable<KeyValuePair<string, object>>, IKvStore
    {
        private readonly Dictionary<string, object> _d = new Dictionary<string, object>();

        public void Add(string key, object value)
        {
            _d.Add(key, value);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _d.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _d.GetEnumerator();
        }
    }
}
