namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Matilda", 3, "Golden Retriever");
            Animal cat = new Cat("Bella", 2, "Orange");
            Animal bird = new Bird("Xmen", 1, 10.5);

            Animal bulldog = new Bulldog("Sten", 4, "Bulldog", "Wrinkled");
            Animal chihuahua = new Chihuahua("Shaq", 2, "Chihuahua", "Small");


            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();

            bulldog.MakeSound();
            chihuahua.MakeSound();
        }
    }
}