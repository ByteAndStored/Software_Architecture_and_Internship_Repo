namespace helloCsharp
{
    class program
    {
        static void Main (string[] args)
        {
          

            getinfo Userinfo = new getinfo();
            Userinfo.info();

            helloworldCsharp helloworldCsharp = new helloworldCsharp();
            Console.WriteLine($"{helloworldCsharp.ide} {helloworldCsharp.version}"); 
            //değişkeni , içinde olan classla yaz
        }
    }
}