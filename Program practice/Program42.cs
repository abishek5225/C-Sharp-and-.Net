/*
How is a virtual method used to achieve dynamic binding in C#? Explain with the help of a suitable program.
*/

using System;

class Animal{
    public virtual void MakeSound(){
        Console.WriteLine("An animal makes a sound");
    }
}
class Dog : Animal{
    public override void MakeSound(){
        Console.WriteLine("A dog barks");
    }
}
class Cat : Animal{
    public override void MakeSound(){
        Console.WriteLine("A cat meows");
    }
}
class Program42 {
    static void Main(string[] args) {
        Animal obj = new Animal();
        obj.MakeSound();

        Dog obj2 = new Dog();
        obj2.MakeSound();

        Cat obj3 = new Cat();
        obj3.MakeSound();

    }
}