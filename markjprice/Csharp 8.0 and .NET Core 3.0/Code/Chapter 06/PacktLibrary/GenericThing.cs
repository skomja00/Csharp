using System;

namespace Packt.Shared
{
    public class GenericThing<T> where T : IComparable
    {
        public T Data = default(T);
        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "data and input are the same.";
            }
            else
            {
                return "data and input are NOT the same.";
            }
        }
    }
}