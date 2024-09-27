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

        // Properties
        public int UsedSize { get { return usedSize; } set { usedSize = value; } }
        public int TotalLength { get { return totalLength;  } set { totalLength = value; } }

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
            if (index >= values.Length)
            {
                index = 0;

                values[0] = item;

                index++;
            } else
            {
                values[index] = item;

                index++;

                if(usedSize < values.Length)
                {
                usedSize++;
                }
            }

        }
        public void Clear ()
        {
            Array.Clear(values, 0, usedSize); // Length heist wie viele (ab postion 0 -> solange bis totalValues)
        }

        public override string ToString()
        {
            string returnstring = string.Empty;
            for(int i = 0; i < values.Length; i++)
            {
                int index = (this.index + i) % values.Length;

                returnstring += values[index] + ",";
            }

            return returnstring;
        }
    }
}
