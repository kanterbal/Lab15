using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithp = new ArithProgression();
            arithp.setStart(5);
            arithp.D = 3;
            arithp.getNext();
            arithp.getNext();
            arithp.getNext();
            Console.WriteLine(arithp.value);
            arithp.reset();
            Console.WriteLine(arithp.value);

            GeomProgression geomp = new GeomProgression();
            geomp.setStart(5);
            geomp.Q = 2;
            geomp.getNext();
            geomp.getNext();
            geomp.getNext();
            Console.WriteLine(geomp.value);
            geomp.reset();
            Console.WriteLine(geomp.value);
            Console.ReadKey();

        }
    }
    interface ISeries
    {

        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        public int value;
        public int D { get; set; }
        
        public ArithProgression()
        {
            start = 0;
            value = 0;
        }
        public int getNext()
        {
            value += D;
            return value;
        }

        public void reset()
        {
            value = start;
        }

        public void setStart(int x)
        {
            start = x;
            value = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        public int value;
        public int Q { get; set; }
        public GeomProgression()
        {
            start = 0;
            value = 0;
        }
        public int getNext()
        {
            value *= Q;
            return value;
        }

        public void reset()
        {
            value = start;
        }

        public void setStart(int x)
        {
            start = x;
            value = start;
        }
    }
}
