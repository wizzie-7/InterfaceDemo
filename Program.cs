

using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            wildAnimal w;
            InterfaceImple imp = new InterfaceImple();
            imp.taste();
            imp.color();
        }
    }
    public interface wildAnimal
    {
        void taste();
    }
    public interface petAnimal 
    {
        void color();
    }
    public class InterfaceImple : wildAnimal,petAnimal
    {
        public void taste()
        {
            Console.WriteLine("Senssing diff taste");
        }
        public void color()
        {
            Console.WriteLine("White");
        }
    }
    abstract class interfcaAbstractclass : petAnimal
    {
        public void color()
        {
            Console.WriteLine("colorful");
        }
    }
}
