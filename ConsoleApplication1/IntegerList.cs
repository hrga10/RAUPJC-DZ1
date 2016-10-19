using System;

namespace ConsoleApplication1
{
    public class IntegerList : IIntegerList
    {
        public int[] _internalStorage;
        private int initialSize = 4;
        private int size = 0;
        private int numOfItems = 0;

        public IntegerList()
        {
            _internalStorage = new int[initialSize];
            size = initialSize;
        }
       
        public IntegerList(int initialSize)
        {
            if (initialSize < 0)
                throw new ArgumentException("Krivi unos podataka!");
            else
            {
                this.initialSize = initialSize;
                size = initialSize;
                _internalStorage = new int[this.initialSize];
            }
        }

        public int Count
        {
            get
            {
                return numOfItems;
            }
        }

        public void Add(int item)
        {
            if (numOfItems == size)
            {
                Array.Resize(ref _internalStorage, 2*size);
                size *= 2;
            }
            _internalStorage[numOfItems] = item;
            numOfItems++;
        }

        public bool Remove(int item)
        {
            int position = 0;
            while (_internalStorage[position] != item)
            {
                position++;
                if (position == numOfItems)
                    return false;
            }
            return RemoveAt(position);
        }

        public bool RemoveAt(int index)
        {
            if (index >= numOfItems)
                return false;
            for(int i=index; i<numOfItems; i++)
            {
                if (index < numOfItems - 1)
                    _internalStorage[i] = _internalStorage[i + 1];
            }
            numOfItems--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index < numOfItems)
                return _internalStorage[index];
            else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < numOfItems; i++)
                if (_internalStorage[i] == item)
                    return i;                  
            throw new ArgumentException("ne postoji takav element u spremniku!");
        }

        public void Clear()
        {
            Array.Resize(ref _internalStorage, 0);
            numOfItems = 0;
        }

        public bool Contains(int item)
        {
            foreach (int index in _internalStorage)
                if (index == item)
                    return true;
            return false;
        }
    }
}
