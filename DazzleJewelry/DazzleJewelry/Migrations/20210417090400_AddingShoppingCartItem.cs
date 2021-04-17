using Microsoft.EntityFrameworkCore.Migrations;

namespace DazzleJewelry.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JewelryId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Jewelries",
                columns: new[] { "JewelryId", "CategoryId", "Description", "ImgThumUrl", "ImgUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 8, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz. ", "\\images\\thumbnails\\ayarlanabilir-zirkon-tasli-hayat-agaci-9-4d30 (1).jpg", "\\images\\ayarlanabilir-zirkon-tasli-hayat-agaci-9-4d30.jpg", true, true, "Zirkon Taşlı Hayat Ağacı Madalyon Yüzük", 44.0m },
                    { 9, 2, "Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz. Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor. Bol su ile teması, kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir. Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.", "\\images\\thumbnails\\ayarlanabilir-alyans-yuzuk---y211-44a0 (1).jpg", "\\images\\ayarlanabilir-alyans-yuzuk---y211-44a0.jpg", true, true, "Alyans Yüzük", 34.0m },
                    { 10, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz.Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz.Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor.Bol su ile teması,kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir.Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.", "\\images\\thumbnails\\ayarlanabilir-flame-yuzuk---y227--9a78- (1).jpg", "\\images\\ayarlanabilir-flame-yuzuk---y227--9a78-.jpg", true, true, "Flame Yüzük", 44.0m },
                    { 11, 2, "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır.Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.Ayarlanabilir yüzüklerin bir diğer özelliği de bitişlerindeki oval uçları sayesinde istediğiniz kadar ayarlama yapabilmenize imkan sağlarken kesinlikle parmağınıza batma yapmazlar.Ayarlanabilir yüzüklerimizi duruma ve kombinleyeceğiniz diğer takılarınıza göre tüm parmaklarınızda gönül rahatlığı ile kullabilir ve ardından boyutunu eski haline getirebilirsiniz.Her şekilde kullanabileceğiniz ayarlanabilir altın kaplama yüzüklerimizi muhafaza etmek de en az kullanmak kadar rahat olduğundan emin olabilirsiniz.Kimyasallardan uzak ve güneş ışığının direkt olarak gelmediği her hangi bir ortamda saklayabileceğiniz altın kaplama yüzüklerimizi bol su ile yıkamaktan da kaçınmanız gerekiyor.Bol su ile teması,kimyasal ürünlerin de yaptığı gibi pirinç üzeri altın kaplama tasarım yüzüklerimizde renk değişimine veya kararmaya yol açabilir.Fakat bu unsurlara dikkat etmeniz durumunda tamamen rahatlıkla kullanabileceğiniz altın kaplama ayarlanabilir yüzüklerimiz size takı ve moda dünyasındaki son trendleri yakalamak için en parlak fırsatı sunuyor.", "\\images\\thumbnails\\gumus-renk-ayarlanabilir-line-yuzuk----b-d768 (1).jpg", "\\images\\gumus-renk-ayarlanabilir-line-yuzuk----b-d768.jpg", true, true, "Gümüş Line Yüzük", 34.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_JewelryId",
                table: "ShoppingCartItems",
                column: "JewelryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 11);
        }
    }
}
