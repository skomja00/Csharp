using System;

namespace Packt.Shared
{
    public class Thing
    {
        public object Data = default(object);
        public string Process(object input)
        {
            if (Data == input)
            {
                return "data and input are the same.";
            }
            else 
            {
                return "data and input and NOT the same.";
            }
        }
    }
}