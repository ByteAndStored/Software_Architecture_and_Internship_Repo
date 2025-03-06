namespace helloCsharp;

public class helloworldCsharp : HelloWorld // ; yok
{
    public void generalInfo()
    {
        Console.WriteLine("Enter release year");
        int firstRelease = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( $"Yıl bilgisi alındı {firstRelease}" );
    }

    public string version = "Rider";


}