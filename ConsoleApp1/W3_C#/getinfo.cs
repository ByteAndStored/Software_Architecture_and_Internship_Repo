namespace helloCsharp;

public class getinfo
{
    public void info()
    {
        Console.WriteLine("Enter your name");
        string name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Your name:" + name);
        
        //Console.Readline() method returns a string
        
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age:" + age);
    }
}

