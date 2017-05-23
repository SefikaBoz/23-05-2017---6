# 23-05-2017---6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionExample
{
    public class Liste<T>
    {
        private T[] elements;
        private static int defaultCapacity = 4;
        private int size;
        public Liste()
        {
            elements = new T[0];
        }
        public virtual int Add(T value)
        {
            if (this.size == this.elements.Length)
            {
                this.IncreaseCapacity(this.size + 1);
            }
            this.elements[this.size] = value;
            return this.size;
        }
        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index >= this.size))
                {
                    //throw new Exception("yanlış index");  
                    return this.elements[index];
                }
                return this.elements[index];
            }
            set
            {
                if ((index < 0) || (index >= this.size))
                {
                    throw new Exception("Yanlış index");
                }
                this.elements[index] = value;
            }
        }
        private void IncreaseCapacity(int min)
        {
            if (this.elements.Length < min)
            {
                int piece = (this.elements.Length == 0) ? defaultCapacity : (this.elements.Length * 2);
                if (piece < min)
                {
                    piece = min;
                }
                this.Capacity = piece;
            }
        }
        public int Capacity
        {
            get
            {
                return elements.Length;
            }
            set
            {
                if (value != this.elements.Length)
                {
                    if (value > 0)
                    {
                        T[] newArray = new T[value];
                        if (value > 0)
                        {
                            Array.Copy(this.elements, 0, newArray, 0, this.size);
                        }
                        this.elements = newArray;
                    }
                    else
                    {
                        this.elements = new T[defaultCapacity];
                    }
                }
            }
        }
    }
}
