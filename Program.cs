using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;

        Console.WriteLine("Введите имя: ");
        User.Name = Console.ReadLine();

        User.Dishes = new string [5];

        Console.WriteLine("Введите 5 ваших любимых блюд: ");

        for (int i = 0; i < 5; i++)
        {
            User.Dishes[i] = Console.ReadLine();
        }

        Console.WriteLine("Вас зовут {0}", User.Name);

        Console.Write("Ваши любимые блюда: ");
        foreach (string Dishes in User.Dishes)
        {
            Console.Write(Dishes + ",");
        }

             
    }

}