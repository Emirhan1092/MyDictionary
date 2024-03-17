using System.Collections.Generic;
namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] _tkeys;
        Tvalue[] _tvalue;
        private object tempValue;

        public MyDictionary()
        {
            _tkeys = new Tkey[0];
            _tvalue = new Tvalue[0];
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {

            Tvalue[] tempValue = _tvalue;
            Tkey[] tempKey = _tkeys;
            _tkeys = new Tkey[_tkeys.Length + 1];
            _tvalue = new Tvalue[_tvalue.Length + 1];

            ;

            for (int i = 0; i < tempKey.Length; i++)
            {
                _tkeys[i] = tempKey[i];
                _tvalue[i] = tempValue[i];

            }

            _tkeys[_tkeys.Length - 1] = tkey;
            _tvalue[_tvalue.Length - 1] = tvalue;

        }

        public int Length
        {
            get { return _tkeys.Length; }
        }

        public Tkey[] tkeys
        {
            get { return _tkeys; }
        }

        public Tvalue[] tvalue
        {
            get { return _tvalue; }
        }
    }
}
