# ReCapProject - Araba Kiralama Sistemi
- ReCapProject Entities, DataAccess, Business ve ConsoleUI katmanlarından oluşan "Araba Kiralama Sistemi" adlı bir C# projesidir. 
- Şuan için 3 farklı nesne (Car, Color ve Brand) ve operasyonlarından oluşan bu proje zaman içerisinde geliştirilecektir.
- Proje hakkındaki detayları zaman içerisinde [blog sayfamda](https://www.hasanbaskin.com) paylaşacağım. 


### Data Acces Katmanı Hakkında
- Başlangıç olarak memory (Bellek) üzerinde çalıştığım için [InMemory](https://github.com/hsnbskn/ReCapProject/tree/master/DataAccess/Concrete/InMemory) klasöründe yer alan InMemoryCarDal.cs içerisinde operasyonları oluşturdum. İlerleyen zamanlarda projeye Entity Framework ekleyeceğim için böyle bir yapı oluşturdum. Entity Framework eklendiği zaman ona ait olan dosyalar EntityFramework içerisinde yer alacaktır.
- Bu şekilde PnP olarak sistem alt yapısı hızlıca değiştirilebilecek.

### Core Katmanı Hakkında
- Core Katmanı asla başka bir katmana bağımlı olamaz! Tamamen bağımsızdır.
- Diğer katmanlar Core katmanına bağımlıdır ve referans alırlar.
- Farklı projelerde PnP mantığıyla CRUD işlemlerini rahatlıkla kullanabiliriz.

### Output

![Image](https://i.hizliresim.com/8wyFSc.pngg)

### Program Files

![Image](https://i.hizliresim.com/QRlI1G.png)
