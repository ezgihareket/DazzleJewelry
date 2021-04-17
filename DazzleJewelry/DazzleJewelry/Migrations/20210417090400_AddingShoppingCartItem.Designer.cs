﻿// <auto-generated />
using System;
using DazzleJewelry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DazzleJewelry.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210417090400_AddingShoppingCartItem")]
    partial class AddingShoppingCartItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DazzleJewelry.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescripton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Küpe"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Yüzük"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kolye"
                        });
                });

            modelBuilder.Entity("DazzleJewelry.Models.Jewelry", b =>
                {
                    b.Property<int>("JewelryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgThumUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JewelryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Jewelries");

                    b.HasData(
                        new
                        {
                            JewelryId = 1,
                            CategoryId = 1,
                            Description = "Vintage Küpelerimiz, altın suyuna batırılmış pirinçten yapılmaktadır. Uzun süreli kullanımlara uygundur. Kararma ve solma yapmaz. Hassas, alerjik yapılı ciltler için önerilmez.Kullanım Şartları-Parfüm,krem ve bol suya temasından kaçınınız.- Kullanılmadığı zamanlarda,küpenizi ışıktan uzak ve hava almayan bir kutuda muhafaza ediniz.",
                            ImgThumUrl = "\\images\\thumbnails\\minimal-simsek-kupe---k113-b029 (1).jpg",
                            ImgUrl = "\\images\\minimal-simsek-kupe---k113-b029.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Minimal Şimşek Küpe",
                            Price = 34.0m
                        },
                        new
                        {
                            JewelryId = 2,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                            ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-flat-earth-yuzuk---y20-a285 (1).jpg",
                            ImgUrl = "\\images\\ayarlanabilir-flat-earth-yuzuk---y20-a285.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Ayarlanabilir Flat Earth Yüzük",
                            Price = 39.0m
                        },
                        new
                        {
                            JewelryId = 3,
                            CategoryId = 3,
                            Description = "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında yazabilirsiniz. Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas etmemesine dikkat edilmelidir. Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.",
                            ImgThumUrl = "\\images\\thumbnails\\hilal-kolye---vk289-34d7 (1).jpg",
                            ImgUrl = "\\images\\hilal-kolye---vk289-34d7.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Hilal Kolye",
                            Price = 49.0m
                        },
                        new
                        {
                            JewelryId = 4,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                            ImgThumUrl = "\\images\\thumbnails\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41 (1).jpg",
                            ImgUrl = "\\images\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Gümüş Renk Ayarlanabilir Zincir Yüzük",
                            Price = 34.0m
                        },
                        new
                        {
                            JewelryId = 5,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                            ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309 (1).jpg",
                            ImgUrl = "\\images\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Ayarlanabilir Elips Madalyon Yüzük",
                            Price = 39.0m
                        },
                        new
                        {
                            JewelryId = 6,
                            CategoryId = 1,
                            Description = "Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas etmemesine dikkat edilmelidir.Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.",
                            ImgThumUrl = "\\images\\thumbnails\\buyuk-halka-kupe---k155-1-1838 (1).jpg",
                            ImgUrl = "\\images\\buyuk-halka-kupe---k155-1-1838.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Büyük Halka Küpe",
                            Price = 39.0m
                        },
                        new
                        {
                            JewelryId = 7,
                            CategoryId = 3,
                            Description = "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında yazabilirsiniz. ",
                            ImgThumUrl = "\\images\\thumbnails\\tasli-yonca-kolye---vk298-f27b (1).jpg",
                            ImgUrl = "\\images\\tasli-yonca-kolye---vk298-f27b.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Taşlı Yonca Kolye",
                            Price = 44.0m
                        },
                        new
                        {
                            JewelryId = 8,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz. ",
                            ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-zirkon-tasli-hayat-agaci-9-4d30 (1).jpg",
                            ImgUrl = "\\images\\ayarlanabilir-zirkon-tasli-hayat-agaci-9-4d30.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Zirkon Taşlı Hayat Ağacı Madalyon Yüzük",
                            Price = 44.0m
                        },
                        new
                        {
                            JewelryId = 9,
                            CategoryId = 2,
                            Description = "Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz. Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor. Bol su ile teması, kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir. Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.",
                            ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-alyans-yuzuk---y211-44a0 (1).jpg",
                            ImgUrl = "\\images\\ayarlanabilir-alyans-yuzuk---y211-44a0.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Alyans Yüzük",
                            Price = 34.0m
                        },
                        new
                        {
                            JewelryId = 10,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz.Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz.Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor.Bol su ile teması,kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir.Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.",
                            ImgThumUrl = "\\images\\thumbnails\\ayarlanabilir-flame-yuzuk---y227--9a78- (1).jpg",
                            ImgUrl = "\\images\\ayarlanabilir-flame-yuzuk---y227--9a78-.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Flame Yüzük",
                            Price = 44.0m
                        },
                        new
                        {
                            JewelryId = 11,
                            CategoryId = 2,
                            Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz.Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz.Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor.Bol su ile teması,kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir.Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.",
                            ImgThumUrl = "\\images\\thumbnails\\gumus-renk-ayarlanabilir-line-yuzuk----b-d768 (1).jpg",
                            ImgUrl = "\\images\\gumus-renk-ayarlanabilir-line-yuzuk----b-d768.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Gümüş Line Yüzük",
                            Price = 34.0m
                        });
                });

            modelBuilder.Entity("DazzleJewelry.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("JewelryId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("JewelryId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("DazzleJewelry.Models.Jewelry", b =>
                {
                    b.HasOne("DazzleJewelry.Models.Category", "Category")
                        .WithMany("Jewelries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DazzleJewelry.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("DazzleJewelry.Models.Jewelry", "Jewelry")
                        .WithMany()
                        .HasForeignKey("JewelryId");

                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("DazzleJewelry.Models.Category", b =>
                {
                    b.Navigation("Jewelries");
                });
#pragma warning restore 612, 618
        }
    }
}
