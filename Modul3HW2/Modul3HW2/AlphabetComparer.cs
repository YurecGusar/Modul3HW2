using System.Collections.Generic;
using Modul3HW2.Models.Abstractions;

namespace Modul3HW2
{
    public class AlphabetComparer : IComparer<KeyValuePair<string, IContact>>
    {
        private string _alphabet;
        public AlphabetComparer()
        {
            _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Запихнуть в конфиг
        }

        public int Compare(KeyValuePair<string, IContact> x, KeyValuePair<string, IContact> y)
        {
            var index1 = 0;
            var index2 = 0;

            for (var i = 0; i < _alphabet.Length; i++)
            {
                if (x.Key[0] == _alphabet[i])
                {
                    index1 = i;
                }

                if (y.Key[0] == _alphabet[i])
                {
                    index2 = i;
                }
            }

            if (index1 < index2)
            {
                return -1;
            }
            else if (index1 > index2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
