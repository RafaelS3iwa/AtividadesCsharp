using System;

namespace ExemploInterface
{
    public interface IAnimal
    {
        void EmitirSom();
    }
    public class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("O Cachorro faz au au.");
        }
    }
    public class Gato : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("O Gato faz miaaau.");
        }
    }

    class program
    {
        static void Main (string[]args)
        {
            IAnimal cachorro1 = new Cachorro();
            IAnimal gato1 = new Gato();

            cachorro1.EmitirSom();
            gato1.EmitirSom();

            Console.ReadLine();
        }
    }
}