# ReCapProject - Araba Kiralama Sistemi
- Bu repo **"Yazılım Geliştirici Yetiştirme Kampı"** için oluşturulmuştur.
- ReCapProject **Entities**, **DataAccess**, **Business**, **Core** ve **WebAPI** katmanlarından oluşan "Araba Kiralama Sistemi" adlı **kurumsal** bir C# projesidir. 
- Car, Color, Brand, User, Customer, Rental nesneleri ve bu nesnelerin operasyonlarından oluşan bu proje zaman içerisinde geliştirilecektir.
- Proje hakkındaki detayları seri halinde **[blog sayfamda](https://www.hasanbaskin.com)** paylaşıyor olacağım. 

## **Entities Katmanı**
- Proje veritabanında yer alan tablolara karşılık gelen **nesneler** burada tutulmaktadır. 
- Bu katman kendi içerisinde Abstract (Soyut Nesneler) ve Concrete (Somut Nesneler) olmak üzere ikiye ayrılmaktadır. 

##### Abstract Klasörü
- ~~IEntity.cs~~ (Ortak olması nedeniyle **Core** Katmanına taşınmıştır.)
##### Concrete Klasörü
- [Brand.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/Brand.cs)
- [Car.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/Car.cs)
- [Color.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/Color.cs)
- [Customer.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/Customer.cs)
- [Rental.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/Rental.cs)
- [User.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/Concrete/User.cs)
##### DTOs Klasörü
- [CarDetailDto.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs)
- [RentalDetailDto.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Entities/DTOs/RentalDetailDto.cs)
### **Data Acces Katmanı**
- Başlangıç olarak memory (Bellek) üzerinde çalışılacağı için [InMemory](https://github.com/hsnbskn/ReCapProject/tree/master/DataAccess/Concrete/InMemory) klasöründe yer alan InMemoryCarDal.cs içerisinde operasyonları oluşturuldu. İlerleyen zamanlarda projeye Entity Framework ekleyeceğim için böyle bir yapı oluşturuldu. Entity Framework eklendiği zaman ona ait olan dosyalar EntityFramework içerisinde yer alacaktır. Bu şekilde PnP olarak sistem alt yapısı hızlıca değiştirilebilecektir.
- Proje içerisinde **EntityFrameWork** alt yapısı kullanılmıştır.
- CRUD işlemlerinin gerçekleştirilmesini sağlayan katmandır. Veritabanı ile programın iletişimini sağlar.

##### Abstract Dosyası
- [IBrandDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
- [ICarDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs)
- [IColorDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs)
- [ICustomerDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs)
- [IRentalDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs)
- [IUserDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs)
 
##### Concrete Klasörü
- EntityFramework
    - [EfBrandDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
    - [EfCarDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
    - [EfColorDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
    - [EfCustomerDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
    - [EfRentalDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
    - [EfUserDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
    - [MydbContext.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/MydbContext.cs)

-  InMemory
    -  [InMemoryCarDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)
      
    
### **Business Katmanı**
- Bu katmanda gerekli olan iş kontrolleri ve kuralları yer almaktadır.
- İçerisinde başarı ve hata mesajlarını tutan dosyamız yer almaktadır. 
- **Abstract** (Soyut Nesneler), **Concrete** (Somut Nesneler) ve **Constants**(Mesaj değerleri) klasörlerinden oluşmaktadır.

##### Abstract Klasörü
- [IBrandService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/IBrandService.cs)
- [ICarService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/ICarService.cs)
- [IColorService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/IColorService.cs)
- [ICustomerService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/ICustomerService.cs)
- [IRentalService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/IRentalService.cs)
- [IUserService.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Abstract/IUserService.cs)

##### Concrete Klasörü
- [BrandManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/BrandManager.cs)
- [CarManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/CarManager.cs)
- [ColorManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/ColorManager.cs)
- [CustomerManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs)
- [RentalManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/RentalManager.cs)
- [UserManager.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Concrete/UserManager.cs) 

##### Constants Klasörü
- [Messages.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Business/Constants/Messages.cs) 

### **Core Katmanı**
- **Core Katmanı asla başka bir katmana bağımlı olamaz! Tamamen bağımsızdır.**
- Bu katmanda ortak kodlar yer almaktadır. Projenin kurumsal bir yapıya sahip olmasını sağlar.
- Diğer katmanlar **Core** katmanına bağımlıdır ve referans alırlar.
- Farklı projelerde PnP mantığıyla CRUD işlemlerini rahatlıkla kullanabiliriz.
- Daha sonra kodlanacak olan benzer projelere çatı niteliğindedir.
- DataAccess klasörü DataAcccess katmanıyla ilgili nesneleri, Entities klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur.
- Core katmanının .NET Core ile hiç bir alakası yoktur. 

##### DataAccess Klaösörü
- [IEntityRepository.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/DataAccess/IEntityRepository.cs)
- ###### EntityFramework Klasörü
    - [EfEntityRepositoryBase.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)

##### Entities Klasörü
- [IDto.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Entities/IDto.cs)
- [IEntity.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Entities/IEntity.cs) 

##### Utilities Klasörü
- ###### Results Klasörü
    - [DataResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/DataResult.cs)
    - [ErrorDataResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs)
    - [ErrorResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/ErrorResult.cs)
    - [IDataResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/IDataResult.cs)
    - [IResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/IResult.cs)
    - [Result.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/Result.cs)
    - [SuccessDataResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs)
    - [SuccessResult.cs](https://github.com/hsnbskn/ReCapProject/blob/master/Core/Utilities/Results/SuccessResult.cs) 

### **WebAPI Katmanı**
- Proje servislerine farklı yazılımlar, uygulamalar ve cihazlar üzerinden erişim imkanı sağlar.
- Bu aşamada yazılan kodlar **Postman** Aracı ile test edilmiştir.
- Controllers dosyasında yer alan class'ların amacı client tarafından server'a yapılan istekleri karşılamak ve çalıştırılacak olan servise karar vermektir.

- [Startup.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Startup.cs)
- ##### **Controllers Klasörü**
    - [BrandsController.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/BrandsController.cs)
    - [CarsController.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/CarsController.cs)
    - [ColorsControllers.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/ColorsController.cs)
    - [CustomersController.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/CustomersController.cs)
    - [RentalsController.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/RentalsController.cs)
    - [UsersController.cs](https://github.com/hsnbskn/ReCapProject/blob/master/WebAPI/Controllers/UsersController.cs) 


### Output (ConsoleUI)
![Image](https://i.hizliresim.com/8wyFSc.png)
### Output (Postman Test)
![Image](https://i.hizliresim.com/ZDJECF.png)
### Program Files
![Image](https://i.hizliresim.com/QRlI1G.png)
### WebAPI Files
![Images](https://i.hizliresim.com/7oiz7E.png)
