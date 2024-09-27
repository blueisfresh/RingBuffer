using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class RingBuffer<T>
    {

        // Fields
        private int totalLength;
        private int usedSize = 0; // How much is already in the array
        private T[] values;
        private int index = 0;
        private bool isFull = false;

        // Properties
        public int UsedSize { get { return isFull ? totalLength : index; } }
        public int TotalLength { get { return totalLength;  } }

        // Constructor
        public RingBuffer(int totalLength)
        {
            if(totalLength > 0)
            {
                this.totalLength = totalLength;
                values = new T[totalLength];
            } else
            {
                throw new ArgumentException("You cannot add Negative Numbers");
            }
        }

        // Methods
        public void Add(T item)
        {
            values[index] = item;
            index = (index + 1) % totalLength;

            isFull = isFull || index == 0;
        }
        public void Clear ()
        {
            Array.Clear(values, 0, usedSize);
            index = 0;
            isFull = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < values.Length; i++)
            {
                int index = (this.index + i) % values.Length;

                sb.Append(values[index] + ",");
            }

            return sb.ToString();
        }
    }
}
