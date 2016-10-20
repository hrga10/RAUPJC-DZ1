using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class GenericList<X> : IGenericList<X>
    {
        public X[] _internalStorage;
        private int initialSize = 4;
        private int size = 0;
        private int numOfItems = 0;

        public GenericList()
        {
            _internalStorage = new X[initialSize];
            size = initialSize;
        }

        public GenericList(int initialSize)
        {
            if (initialSize < 0)
                throw new ArgumentException("Krivi unos podataka!");
            else
            {
                this.initialSize = initialSize;
                size = initialSize;
                _internalStorage = new X[this.initialSize];
            }
        }

        public int Count
        {
            get
            {
                return numOfItems;
            }
        }

        public void Add(X item)
        {
            if (numOfItems == size)
            {
                Array.Resize(ref _internalStorage, 2 * size);
                size *= 2;
            }
            _internalStorage[numOfItems] = item;
            numOfItems++;
        }

        public bool Remove(X item)
        {
            int position = Array.FindIndex(_internalStorage, s => s.Equals(item));
            if (position > numOfItems || position == -1)
                return false;
            return RemoveAt(position);
        }

        public bool RemoveAt(int index)
        {
            if (index >= numOfItems)
                return false;
            for (int i = index; i < numOfItems; i++)
            {
                if (index < numOfItems - 1)
                    _internalStorage[i] = _internalStorage[i + 1];
            }
            numOfItems--;
            return true;
        }

        public X GetElement(int index)
        {
            if (index < numOfItems)
                return _internalStorage[index]; 
            throw new IndexOutOfRangeException("ne postoji element s tim indeksom!");
        }

        public int IndexOf(X item)
        {
            int flag = Array.FindIndex(_internalStorage, s => s.Equals(item));
            if (flag != -1)
                return flag;
            throw new ArgumentException("ne postoji takav element u spremniku!");
        }

        public void Clear()
        {
            Array.Resize(ref _internalStorage, 0);
            numOfItems = 0;
        }

        public bool Contains(X item)
        {
            return Array.Exists(_internalStorage, s => s.Equals(item));
        }
    }
}
