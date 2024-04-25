using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    //a: Enum
    public enum AnimalType { Harvivore =1, Carnivore, Omnivore }
    public enum Gender { Female, Male }
    //b: Principle of OOP 
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public AnimalType Type { get; set; }
    }
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T obj);
    }
    public interface ITypeSpecificGenericBehavior<T>
    {
        string GetTypeSpecificBehavior<T>(T data) where T : Animal;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name="Cow",Age = 3, Type=AnimalType.Harvivore,Sex=Gender.Female};
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericBehavior(cow));
            Animal tiger = new Animal { Name = "Tiger", Age = 2, Type = AnimalType.Carnivore, Sex = Gender.Female };
            TypeGeneric<Animal> anim = new TypeGeneric<Animal>();
            Console.WriteLine(anim.GetTypeSpecificBehavior(tiger));
            Console.ReadKey ();
        }
    }
}
