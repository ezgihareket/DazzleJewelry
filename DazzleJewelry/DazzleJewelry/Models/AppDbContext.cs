using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {

        }

        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Küpe" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Yüzük" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Kolye" });


            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 1,
                Name = "Minimal Şimşek Küpe",
                Price = 34.0M,
                Description = "Vintage Küpelerimiz, altın suyuna batırılmış pirinçten yapılmaktadır. Uzun süreli kullanımlara uygundur. Kararma ve solma yapmaz. Hassas," +
               " alerjik yapılı ciltler için önerilmez.Kullanım Şartları-Parfüm,krem ve bol suya temasından kaçınınız.- Kullanılmadığı zamanlarda,küpenizi ışıktan uzak ve " +
               "hava almayan bir kutuda muhafaza ediniz.",
                CategoryId = 1,
                ImgUrl = "\\images\\minimal-simsek-kupe---k113-b029.jpg",
                ImgThumUrl = "\\images\\thumbnails\\minimal-simsek-kupe---k113-b029 (1).jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 2,
                Name = "Ayarlanabilir Flat Earth Yüzük",
                Price = 39.0M,
                Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli" +
                " kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır." +
                "Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz " +
                "normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük " +
                "ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                CategoryId = 2,
                ImgUrl = "\\images\\ayarlanabilir-flat-earth-yuzuk---y20-a285.jpg",
                ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-flat-earth-yuzuk---y20-a285 (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 3,
                Name = "Hilal Kolye",
                Price = 49.0M,
                Description = "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna" +
                " batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi" +
                " kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel " +
                "Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında " +
                "yazabilirsiniz. Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas" +
                " etmemesine dikkat edilmelidir. Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya" +
                " kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.",
                CategoryId = 3,
                ImgUrl = "\\images\\hilal-kolye---vk289-34d7.jpg",
                ImgThumUrl = "\\images\\thumbnails\\hilal-kolye---vk289-34d7 (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 4,
                Name = "Gümüş Renk Ayarlanabilir Zincir Yüzük",
                Price = 34.0M,
                Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli " +
                "kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son " +
                "moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal" +
                " yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve " +
                "saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                CategoryId = 2,
                ImgUrl = "\\images\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41.jpg",
                ImgThumUrl = "\\images\\thumbnails\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41 (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 5,
                Name = "Ayarlanabilir Elips Madalyon Yüzük",
                Price = 39.0M,
                Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli " +
               "kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son " +
               "moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal" +
               " yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve " +
               "saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                CategoryId = 2,
                ImgUrl = "\\images\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309.jpg",
                ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309 (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });


            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 6,
                Name = "Büyük Halka Küpe",
                Price = 39.0M,
                Description = "Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas" +
                " etmemesine dikkat edilmelidir.Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya" +
                " kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.",
                CategoryId = 1,
                ImgUrl = "\\images\\buyuk-halka-kupe---k155-1-1838.jpg",
                ImgThumUrl = "\\images\\thumbnails\\buyuk-halka-kupe---k155-1-1838 (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 7,
                Name = "Taşlı Yonca Kolye",
                Price = 44.0M,
                Description = "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna " +
                "batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi" +
                " kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel " +
                "Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında " +
                "yazabilirsiniz. ",
                CategoryId = 3,
                ImgUrl = "\\images\\tasli-yonca-kolye---vk298-f27b.jpg",
                ImgThumUrl = "\\images\\thumbnails\\tasli-yonca-kolye---vk298-f27b (1).jpg",
                IsInStock = true,
                IsOnSale = true
            });

           
        }

    }


}
