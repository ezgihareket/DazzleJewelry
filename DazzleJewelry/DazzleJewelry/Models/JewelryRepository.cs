using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class JewelryRepository : IJewelryRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Jewelry> GetAllJewelry => new List<Jewelry>
        {
            new Jewelry
            {
                JewelryId = 1,
                Name = "Minimal Şimşek Küpe",
                Price = 34.0M,
                Description = "Vintage Küpelerimiz, altın suyuna batırılmış pirinçten yapılmaktadır. Uzun süreli kullanımlara uygundur. Kararma ve solma yapmaz. Hassas," +
               " alerjik yapılı ciltler için önerilmez.Kullanım Şartları-Parfüm,krem ve bol suya temasından kaçınınız.- Kullanılmadığı zamanlarda,küpenizi ışıktan uzak ve " +
               "hava almayan bir kutuda muhafaza ediniz.",
                Category =_categoryRepository.GetAllCategories.ToList()[0],
                ImgUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/buyuk/minimal-simsek-kupe---k113-b029.jpg",
                ImgThumUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/thumb/minimal-simsek-kupe---k113-b029.jpg",
                IsInStock = true,
                IsOnSale = false
            }

            new Jewelry
            {
                JewelryId = 2,
                Name = "Ayarlanabilir Flat Earth Yüzük",
                Price = 39.0M,
                Description = "Yüzüklerimiz ayarlanabilir olmanın yanı sıra pirinç üzeri altın kaplama olup, kimyasal maddeler ile temasından kaçınmanız halinde uzun süreli" +
                " kullanıma uygundur.Ayarlanabilir tasarım yüzüklerimiz,çeşitli figür ve renk detaylarıyla kombinlerinizde dikkat çeken ayrıntılar olarak yer alacaktır." +
                "Son moda gold veya gümüş renkli yüzüklerimizi her parmağa uygun ayarlanabilir yapısı ile tüm parmaklarda kullanılabilir.Dilerseniz eklem yüzüğü,dilerseniz " +
                "normal yüzük olarak da kullanabileceğiniz altın kaplama yüzüklerimizi kolye,bileklik gibi diğer takı çeşitlerinin yanı sıra son moda kıyafetlerinizle,gözlük " +
                "ve saat benzeri aksesuarlarınız ile kombinleyip ellerinizin güzelliğini ön plana çıkarabilirsiniz.",
                Category =_categoryRepository.GetAllCategories.ToList()[1],
                ImgUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/buyuk/ayarlanabilir-flat-earth-yuzuk---y20-a285.jpg",
                ImgThumUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/buyuk/ayarlanabilir-flat-earth-yuzuk---y20-a285.jpg",
                IsInStock = true,
                IsOnSale = true
            }

            new Jewelry
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
                Category =_categoryRepository.GetAllCategories.ToList()[2],
                ImgUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/buyuk/hilal-kolye---vk289-34d7.jpg",
                ImgThumUrl = "https://www.dazzlecave.com/Uploads/UrunResimleri/buyuk/hilal-kolye---vk289-34d7.jpg",
                IsInStock = true,
                IsOnSale = true
            }
        };

        public IEnumerable<Jewelry> GetJewelryOnSale => throw new NotImplementedException();

        public Jewelry GetJewelryById(int jewelryId)
        {
            return GetAllJewelry.FirstOrDefault(c => c.JewelryId == jewelryId);
        }
    }
}
