using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public class SeedData
    {
        public static void  EnsurePopulated(IApplicationBuilder app)
        {
            PastaciDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PastaciDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product {
                        ProductName ="Çikolatalı Pasta",
                        ProductComment ="Dehşet derecede lezzetli ayol",
                        ImagePath= "cikolatalıpasta.jpg",
                        Price =100,
                        Category=3
                        },
                    new Product
                    {
                        ProductName = "Çilekli Pasta",
                        ProductComment = "Çileğin eşşiz lezzetini tatmaya hazır mısın?",
                        ImagePath = "cileklipasta.jpg",
                        Price = 120,
                        Category = 3
                    },
                    new Product
                    {
                        ProductName = "Lotus Pasta",
                        ProductComment = "Lotus kreması ile lezzetini devleştiren pastamızda lotus biküvi ve karamel lezzetini bir araya getirdik. " +
                        "Pastamızı lotus bisküvi parçaları ile süsledik.",
                        ImagePath = "lotusPasta.jpg",
                        Price = 95,
                        Category = 3
                    },
                    new Product
                    {
                        ProductName = "Yaban Mersinli Pasta",
                        ProductComment = "Yaban mersini ağzınızda unutamayacağınız tatlar bırakırken mutluluktan ölebilirsiniz :)",
                        ImagePath = "yabanmersinlipasta.jpg",
                        Price = 95,
                        Category = 3
                    }
                    ,
                    new Product
                    {
                        ProductName = "Limonlu Pasta",
                        ProductComment = "Limon kokusu içinde huzuru bulabilirsiniz",
                        ImagePath = "limonlupasta.jpg",
                        Price = 85,
                        Category = 3
                    },
                    new Product
                    {
                        ProductName = "Oreo Pasta",
                        ProductComment = "Oreo ile kremanın bütünleştiği bir lezzet patlaması",
                        ImagePath = "oreopasta.jpg",
                        Price = 75,
                        Category = 3
                    },
                    new Product
                    {
                        ProductName = "Fırın Sütlaç Cam Kase",
                        ProductComment = "Yerli üretim pirinçlerimizle yapılan tamamen katkısız bir kase mutluluk",
                        ImagePath = "sutlac.jpg",
                        Price = 15,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Profiterol Cam Kase",
                        ProductComment = "Taptaze profiterol toplarıyla çikolata kremasının eşsiz uyumu ,sizi başka yerlere götürecek",
                        ImagePath = "profiterol.jpg",
                        Price = 20,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Magnolya",
                        ProductComment = "Bahçemizden gelen taze meyvelerle buluşturulmuş,müşterilerimizin favorisi ...",
                        ImagePath = "magnolya.jpg",
                        Price = 25,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Keşkül",
                        ProductComment = "Osmanlının en sevdiği,padişahlara parmak ısırtan o lezzet,evet işte o...",
                        ImagePath = "keskul.jpg",
                        Price = 15,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Fıstıklı Sarma",
                        ProductComment = "Fıstıkla buluşan ezberleri bozan lezzet",
                        ImagePath = "fistiklidurum.jpg",
                        Price = 150,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Cevizli Sarı Burma",
                        ProductComment = "Isparta'dan gelen özel üretim cevizlerimizle yapılan bu lezzeti hala tatmadınız mı?",
                        ImagePath = "cevizliburma.jpg",
                        Price = 70,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Çikolatalı Baklava",
                        ProductComment = "Sıradan baklava lezzetinin ötesinde bir deneyim yaşamaya var mısın?",
                        ImagePath = "cikolatalibaklava.jpg",
                        Price = 165,
                        Category = 1
                    },
                    new Product
                    {
                        ProductName = "Soğuk Baklava",
                        ProductComment = "Hava sıcak ve canınız tatlı mı çekiyor? Ee ne duruyorsun söylesene hemen!!",
                        ImagePath = "sogukbaklava.jpg",
                        Price = 135,
                        Category = 1
                    } ,
                    new Product
                    {
                        ProductName = "Büyük Boy Madlen Çikolata",
                        ProductComment = "Büyük boy çikolata  kutumuzda 72 adet kağıt sargılı madlen çikolata bulunmaktadır",
                        ImagePath = "buyukboymadlencikolata.jpg",
                        Price = 115,
                        Category = 2
                    },
                    new Product
                    {
                        ProductName = "Büyük Boy Special Çikolata",
                        ProductComment = "13 Farklı çikolata tatlarının birleştiği mutluluk kutusu",
                        ImagePath = "buyukboyspecialcikolata.jpg",
                        Price = 150,
                        Category = 2
                    },
                    new Product
                    {
                        ProductName = "Bebek Çikolatası (Pembe) ",
                        ProductComment = "Küçük tatlı ve şirin aynı minnoş bebeğiniz gibi",
                        ImagePath = "bebekcikolatasipembe.jpg",
                        Price = 150,
                        Category = 2
                    },
                    new Product
                    {
                        ProductName = "Bebek Çikolatası (Mavi) ",
                        ProductComment = "Küçük tatlı ve şirin aynı minnoş bebeğiniz gibi",
                        ImagePath = "bebekcikolatasimavi.jpg",
                        Price = 150,
                        Category = 2
                    }
                    ,
                    new Product
                    {
                        ProductName = "Yaldızlı Çikolata ",
                        ProductComment = "Dünyanın en güzel belçika çikolatası bir tık uzağınızda...",
                        ImagePath = "yaldizlicikolata.jpg",
                        Price = 250,
                        Category = 2
                    },
                    new Product
                    {
                        ProductName = "Pleksi Madlen Çikolata ",
                        ProductComment = "Pleksi özel çikolata kutumuzda 72 adet kağıt sargılı madlen çikolata bulunmaktadır.",
                        ImagePath = "pleksicikolata.jpg",
                        Price = 170,
                        Category = 2
                    },
                    new Product
                    {
                        ProductName = "Havuç Dilimi",
                        ProductComment = "Özenle kesilmiş damak zevkinin ötesinde bir lezzet",
                        ImagePath = "havucdilimi.jpg",
                        Price = 95,
                        Category = 1
                    }


                    );
                context.SaveChanges();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                       CategoryName="PASTALAR",
                       ImagePath="k_pasta.jpg"
                    }, 
                    new Category
                    {
                        CategoryName = "ÇİKOLATALAR",
                         ImagePath = "k_cikolata.jpg"
                    },
                      new Category
                      {
                          CategoryName = "TATLILAR",
                           ImagePath = "k_tatlı.jpg"
                      }
                    );
                context.SaveChanges();
            }
        }
    }
}
