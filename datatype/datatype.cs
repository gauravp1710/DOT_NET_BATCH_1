using System;
using System.Text;
namespace DataType
{ 
    public class Int
    {
        private int data;
         
        public Int()
        {
            data = 0;
        }
        public Int(int data)
        {
            this.data = data;
        }
        public float ToFloat()
        {
            return (float)(this.data);
        }
        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.data);
            return str.ToString();
        }

        public int Add(Int a, Int b)
        {
            return (a.data + b.data);
        }

        public int Sub(Int a, Int b)
        {
            return (a.data - b.data);
        }

        public void display()
        {
            Console.WriteLine(data);
        }
    }

    public class Float
    {
        private float data;
        public Float()
        {
            data = 0;
        }
        public Float(int data)
        {
            this.data = data;
        }
        public void setData(int data)
        {
            this.data = data;
        }

        public float ToInt()
        {
            return (float)this.data;
        }
        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.data);
            return str.ToString();
        }

        public float Add(Float a, Float b)
        {
            return (a.data + b.data);
        }
        public float Sub(Float a, Float b)
        {
            return (a.data - b.data);
        }
        public void display()
        {
            Console.WriteLine(data);
        }
    }
}