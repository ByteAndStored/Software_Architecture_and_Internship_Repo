using BookStore.Api.Entities;

namespace BookStore.Api
{
    public static class StaticDB
    {
        public static List<Publisher> Publishers = new List<Publisher>
        {
            new Publisher { Name = "Can Yayınları", EstablishmentYear = 1981 },
            new Publisher { Name = "Yapı Kredi Yayınları", EstablishmentYear = 1992 },
            new Publisher { Name = "İletişim Yayınları", EstablishmentYear = 1982 },
            new Publisher { Name = "Everest Yayınları", EstablishmentYear = 2000 }
        };

        public static List<Author> Authors = new List<Author>
        {
            new Author { Name = "Sabahattin", Surname = "Ali", DateOfBirth = new DateTime(1907, 2, 25) },
            new Author { Name = "Oğuz", Surname = "Atay", DateOfBirth = new DateTime(1934, 10, 12) },
            new Author { Name = "Ahmet Hamdi", Surname = "Tanpınar", DateOfBirth = new DateTime(1901, 6, 23) },
            new Author { Name = "Mehmet", Surname = "Rauf", DateOfBirth = new DateTime(1875, 5, 12) },
            new Author { Name = "Halit Ziya", Surname = "Uşaklıgil", DateOfBirth = new DateTime(1866, 2, 22) }
        };

        public static List<Book> Books = new List<Book>
        {
            new Book { Name = "Kürk Mantolu Madonna", PageSize = 160, Author = Authors[0].Name, Publisher = Publishers[0].Name },
            new Book { Name = "İçimizdeki Şeytan", PageSize = 200, Author = Authors[0].Name, Publisher = Publishers[0].Name },
            new Book { Name = "Tutunamayanlar", PageSize = 724, Author = Authors[1].Name, Publisher = Publishers[1].Name },
            new Book { Name = "Saatleri Ayarlama Enstitüsü", PageSize = 360, Author = Authors[2].Name, Publisher = Publishers[1].Name},
            new Book { Name = "Bir Bilim Adamının Romanı", PageSize = 190, Author = Authors[1].Name, Publisher = Publishers[2].Name},
            new Book { Name = "Tehlikeli Oyunlar", PageSize = 432, Author = Authors[1].Name, Publisher = Publishers[2].Name },
            new Book { Name = "Eylül", PageSize = 300, Author = Authors[3].Name, Publisher = Publishers[3].Name },
            new Book { Name = "Aşk-ı Memnu", PageSize = 432, Author = Authors[4].Name
                , Publisher = Publishers[3].Name }
        };
    }
}

/*Author = Authors[0].Name
 Book.cs de  public string Author { get; set; } böyle tanımlamışız
 tipi string olduğu için .Name metoduyla stringe çevirdik.
 */
