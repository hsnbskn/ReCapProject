# ReCapProject - Araba Kiralama Sistemi
- ReCapProject Entities, DataAccess, Business ve ConsoleUI katmanlarından oluşan bir "Araba Kiralama Sistemi" adlı C# projesidir. 
- Şuan için 3 farklı nesne (Car, Color ve Brand) ve operasyonlarından oluşan bu proje zaman içerisinde geliştirilecektir.
- Proje hakkındaki detayları zaman içerisinde [blog sayfamda](https://www.hasanbaskin.com) paylaşacağım. 


### Data Acces Katmanı Hakkında
- Başlangıç olarak memory (Bellek) üzerinde çalıştığım için [InMemory](https://github.com/hsnbskn/ReCapProject/tree/master/DataAccess/Concrete/InMemory) klasöründe yer alan InMemoryCarDal.cs içerisinde operasyonları oluşturdum. İlerleyen zamanlarda projeye Entity Framework ekleyeceğim için böyle bir yapı oluşturdum. Entity Framework eklendiği zaman ona ait olan dosyalar EntityFramework içerisinde yer alacaktır.
- Bu şekilde PnP olarak sistem alt yapısı hızlıca değiştirilebilecek.

### Output

![Image](https://i.hizliresim.com/PDDu1H.jpg)

### Program Files

![Image](https://i.hizliresim.com/IJF9GI.jpg)
