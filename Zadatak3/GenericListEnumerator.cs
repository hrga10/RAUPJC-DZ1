using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadatak3
{
    public class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> genericList;
        private int position = -1;

        public GenericListEnumerator(GenericList<X> genericList)
        {
            this.genericList = genericList;
        }

        public X Current
        {
            get
            {
                try
                {
                    return genericList._internalStorage[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < genericList.numOfItems);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}