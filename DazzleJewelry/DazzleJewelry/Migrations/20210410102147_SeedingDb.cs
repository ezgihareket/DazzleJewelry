using Microsoft.EntityFrameworkCore.Migrations;

namespace DazzleJewelry.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescripton", "CategoryName" },
                values: new object[] { 1, null, "Küpe" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescripton", "CategoryName" },
                values: new object[] { 2, null, "Yüzük" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescripton", "CategoryName" },
                values: new object[] { 3, null, "Kolye" });

            migrationBuilder.InsertData(
                table: "Jewelries",
                columns: new[] { "JewelryId", "CategoryId", "Description", "ImgThumUrl", "ImgUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Vintage Küpelerimiz, altın suyuna batırılmış pirinçten yapılmaktadır. Uzun süreli kullanımlara uygundur. Kararma ve solma yapmaz. Hassas, alerjik yapılı ciltler için önerilmez.Kullanım Şartları-Parfüm,krem ve bol suya temasından kaçınınız.- Kullanılmadığı zamanlarda,küpenizi ışıktan uzak ve hava almayan bir kutuda muhafaza ediniz.", "\\images\\thumbnails\\minimal-simsek-kupe---k113-b029 (1).jpg", "\\images\\minimal-simsek-kupe---k113-b029.jpg", true, false, "Minimal Şimşek Küpe", 34.0m },
                    { 6, 1, "Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas etmemesine dikkat edilmelidir.Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.", "\\images\\thumbnails\\buyuk-halka-kupe---k155-1-1838 (1).jpg", "\\images\\buyuk-halka-kupe---k155-1-1838.jpg", true, true, "Büyük Halka Küpe", 39.0m },
                    { 2, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.", "\\images\\thumbnails\\ayarlanabilir-flat-earth-yuzuk---y20-a285 (1).jpg", "\\images\\ayarlanabilir-flat-earth-yuzuk---y20-a285.jpg", true, true, "Ayarlanabilir Flat Earth Yüzük", 39.0m },
                    { 4, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.", "\\images\\thumbnails\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41 (1).jpg", "\\images\\gumus-renk-ayarlanabilir-zincir-yuzuk--d34-41.jpg", true, true, "Gümüş Renk Ayarlanabilir Zincir Yüzük", 34.0m },
                    { 5, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye, bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.", "\\images\\thumbnails\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309 (1).jpg", "\\images\\ayarlanabilir-elips-madalyon-yuzuk---y22-0309.jpg", true, true, "Ayarlanabilir Elips Madalyon Yüzük", 39.0m },
                    { 3, 3, "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında yazabilirsiniz. Kullanım TavsiyeleriAltın kaplama tasarım kolyelerinizi uzun süreli kullanımını sağlamak için;Parfüm, krem gibi kimyasal maddeler ile temas etmemesine dikkat edilmelidir. Deniz, duş veya havuza girilmesi tavsiye edilmemektedir.Takılarınızı birbirine temas etmeyecek şekilde kapalı bir kutu veya kesede muhafaza etmenizi tavsiye ederiz.Hassas cilter için önerilmemektedir.", "\\images\\thumbnails\\hilal-kolye---vk289-34d7 (1).jpg", "\\images\\hilal-kolye---vk289-34d7.jpg", true, true, "Hilal Kolye", 49.0m },
                    { 7, 3, "Tasarım Kolye Modellerimiz günlük hayatta veya iş, düğün gibi özel günlerinizde kıyafetlerinizin parlayan parçaları olacaklar. Altın suyuna batırılmış pirinçten üretilen tasarım kolyeleri istediğiniz zincir uzunluğunu seçerek sipariş verebilirsiniz. Farklı uzunluklar seçerek kolye kombinlerinizi kendiniz oluşturabilirsiniz. Zirkon Taşlı, hayvan, kalp, nesne figürlü tasarım kolye modellerimizi sizler için özenle şeffaf ambalajda hazırlayıp özel Dazzlecave mühürlü kutularda gönderiyoruz. Hediye kolye olarak çok sevilen mühürlü kutularımızın içine istediğiniz hediye notunu sipariş aşamasında yazabilirsiniz. ", "\\images\\thumbnails\\tasli-yonca-kolye---vk298-f27b (1).jpg", "\\images\\tasli-yonca-kolye---vk298-f27b.jpg", true, true, "Taşlı Yonca Kolye", 44.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
