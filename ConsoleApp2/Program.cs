public interface IPayment //hepsine implemente edilecek imza kodlar
{ 
    void processPayment(int amount);
}

public abstract class paymentBase : IPayment
{
    public abstract void processPayment(int amount);  //abstract metod tüm classlar override etmeli
    public void IsItBank(bool status) {}  //sadece CardPayment için

    public void latestMessage(string message)
    {
        Console.WriteLine($"Transaction logged {message} TL paid.");
    }
}
    

public class CardPayment: paymentBase
{
    public override void processPayment(int amount)
    {
    Console.WriteLine($"Credit Card Payment of {amount} TL processed.");
    latestMessage(amount.ToString()); //message erişemiyorum 
                            //metodu metod dışından çağıramıyorum
    }

    public void IsItBank (bool status)
    {
        if (status) //default false gelir
        {
            Console.WriteLine("Credit Card Payment Successful");
        }
        else
        {
            Console.WriteLine("Bank Card Payment Failed");
        }
    }

}

public class CryptoPayment: paymentBase
{
    public override void processPayment(int amount)
    {
        Console.WriteLine($"crypto payment of {amount} TL processed");
        latestMessage(amount.ToString()); //bu kısıma hala ikna olamadım
    }
}

class program
{
    static void Main(string[] args)
    {
        
        CardPayment cardPayment = new CardPayment();
        cardPayment.processPayment(500); // 500 TL'lik kredi kartı ödemesi
        
        
        /*✅ CardPayment nesnesi oluşturup çağırıyoruz
        CardPayment cardPayment = new CardPayment();
        cardPayment.processPayment(500); // 500 TL'lik kredi kartı ödemesi
        cardPayment.isItBank(true); // Kredi kartı işlemi başarılı

        Console.WriteLine("\n------------------\n");

        // ✅ CryptoPayment nesnesi oluşturup çağırıyoruz
        CryptoPayment cryptoPayment = new CryptoPayment();
        cryptoPayment.processPayment(300); // 300 TL'lik kripto ödemesi
        cryptoPayment.isItBank(false); // Kripto işlemi başarısız */
    }
}









