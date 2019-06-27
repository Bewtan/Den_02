using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomArrayList
    {
        private const int InitCapacity = 4;

        private object[] arr;

        public int Count
        {
            get; private set;
        }

        public CustomArrayList(int cap = InitCapacity)
        {
            arr = new object[cap];
            Count = 0;
        }

        public void Add(object item)
        {
            if (Count >= arr.Length)
                this.Expand();
            arr[Count++] = item;
        }

        private void Expand()
        {
            object[] temp = new object[arr.Length*2];
            for(int i = 0;i < Count; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        public void Insert(int index, object item)
        {
            if (index >= Count || index < 0)
                throw new ArgumentOutOfRangeException();
            arr[index] = item;  
        }

        public int IndexOf(object item)
        {
            for(int i = 0; i < Count; i++)
            {
                if (item == arr[i])
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            arr = new object[InitCapacity];
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item == arr[i])
                    return true;
            }
            return false;
        }

        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new ArgumentOutOfRangeException();
                return arr[index];
            }
            set {
                if (index >= Count || index < 0)
                    throw new ArgumentOutOfRangeException();
                arr[index] = value;
            }
        }

        public object Remove(int index)
        {
            if (index >= Count || index < 0)
                throw new ArgumentOutOfRangeException();
            object temp = arr[index];
            arr[index] = null;
            this.Shift(index);
            Count--;
            if (Count <= arr.Length)
                this.Shrink();
            return temp;
        }

        private void Shrink()
        {
            object[] temp = new object[arr.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        private void Shift(int index)
        {
            for(int i = index;i < Count; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public int Remove(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(item == arr[i])
                {
                    arr[i] = null;
                    this.Shift(i);
                    Count--;
                    if (Count <= arr.Length)
                        this.Shrink();
                    return i;
                }       
            }
            return -1;
        }


    }
}
