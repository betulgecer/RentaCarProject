# RentaCarProject
RentaCarProject, SOLID prensiplerine bağlı kalınarak ve N-Katmalı mimari yapısıyla C# programlama diline ait; henüz geliştirilme aşamasında olan bir araç kiralama projesidir. Şu anda projenin back-end kısmını incelemektesiniz.

Veritabanı, Visual Studio 2019 içindeki SQL Server Object Explorer kısmından yola çıkılarak oluşturulmuştur. Alt kısımda bu veritabanına ait bazı tabloların alan isimlerini ve veri tiplerini görebilirsiniz.

:open_file_folder:[Database](https://github.com/hlmclgl/RentaCarProject/tree/master/DB)

RentaCarProject; Entities, DataAccess ve Business katmanlarından oluşmaktadır. Başlangıç olarak bu katmanlardaki operasyonların simülasyonu için ConsoleUI katmanı kullanılmıştır. Daha sonrasında ise projede WebAPI yapılandırmasıyla beraber operasyonların testi için Postman kullanılmaya başlanılmıştır. Bu katmanları yakından inceleyelim:

## Entities Layer ##
Bu katman veritabanı nesneleri için oluşturulmuştur. Concrete klasöründe sadace tablolar için oluştrulmuş 'Class'lar bulunurken DTOs klasör kısmında ise farklı tablolardaki özellikleri birleştirmek amacıyla oluşturulan 'Class'lara yer verilmiştir. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

:open_file_folder:[Concrete](https://github.com/hlmclgl/RentaCarProject/tree/master/Entities/Concrete)
 
- :page_facing_up:[Brand](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/Brand.cs)

- :page_facing_up:[Car](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/Car.cs)

- :page_facing_up:[CarImage](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/CarImage.cs)

- :page_facing_up:[Color](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/Color.cs)

- :page_facing_up:[CreditCard](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/CreditCard.cs)

- :page_facing_up:[Customer](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/Customer.cs)

- :page_facing_up:[CustomerFindexScore](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/CustomerFindeksScore.cs)

- :page_facing_up:[PaymentTest](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/PaymentTest.cs)

- :page_facing_up:[Rental](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/Concrete/Rental.cs)

:open_file_folder:[Dto's](https://github.com/hlmclgl/RentaCarProject/tree/master/Entities/DTO's)

- :page_facing_up:[CarDetailDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/CarDetailDto.cs)

- :page_facing_up:[CarImageDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/CarImageDto.cs)

- :page_facing_up:[CustomerDetailDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/CustomerDetailDto.cs)

- :page_facing_up:[RentalDetailDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/RentalDetailDto.cs)

- :page_facing_up:[UserDetailDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/UserDetailDto.cs)

- :page_facing_up:[UserForLoginDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/UserForLoginDto.cs)

- :page_facing_up:[UserForRegisterDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/UserForRegisterDto.cs)

- :page_facing_up:[UserForUpdateDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Entities/DTO's/UserForUpdateDto.cs)

## Data Access Layer ##

Veritabanı ile ilgili gerçekleşen operasyonlar ve veritabanı bağlantıları bu katmanda yer almaktadır. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

:package: **NuGet Packages** 

- :pushpin: Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)

:open_file_folder:[Abstract](https://github.com/hlmclgl/RentaCarProject/tree/master/DataAccess/Abstract)

- :page_facing_up:[IBrandDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
  
- :page_facing_up:[ICarDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/ICarDal.cs)

- :page_facing_up:[ICarImageDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/ICarImageDal.cs)

- :page_facing_up:[IColorDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/IColorDal.cs)

- :page_facing_up:[ICreditCardDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/ICreditCardDal.cs)

- :page_facing_up:[ICustomerDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/ICustomerDal.cs)

- :page_facing_up:[ICustomerFindeksScoreDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/ICustomerFindeksScoreDal.cs)

- :page_facing_up:[IRentaCarDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/IRentACarDal.cs)

- :page_facing_up:[IUserDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Abstract/IUserDal.cs)

:open_file_folder:[Concrete](https://github.com/hlmclgl/RentaCarProject/tree/master/DataAccess/Concrete)

- :open_file_folder:[Entity Framework](https://github.com/hlmclgl/RentaCarProject/tree/master/DataAccess/Concrete/EntityFramework)

  - :page_facing_up:[EfBrandDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)

  - :page_facing_up:[EfCarDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)

  - :page_facing_up:[EfCarImageDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarImageDal.cs)

  - :page_facing_up:[EfColorDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)

  - :page_facing_up:[EfCreditCardDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCreditCardDal.cs)

  - :page_facing_up:[EfCustomerDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)

  - :page_facing_up:[EfCustomerFindeksScoreDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerFindeksScoreDal.cs)

  - :page_facing_up:[EfRentaCarDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentACarDal.cs)

  - :page_facing_up:[EfUserDal](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)

  - :page_facing_up:[RentaCarContext](https://github.com/hlmclgl/RentaCarProject/blob/master/DataAccess/Concrete/EntityFramework/RentaCarContext.cs)
  
:link:InMemory klasörü içindekiler veritabanıyla bir bağlantısı olmayıp sadace başlangıç için test amacıyla oluşturulmuştur.


## Business Layer ##

DataAcess katmanında yer alan operasyonlara ait iş kuralları bu katmanda yer almıştır. Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.

:package:**NuGet Packages**

- :pushpin:Autofac(v6.1.0)

- :pushpin:Autofac.Extras.DynamicProxy(v6.0.0)

- :pushpin:FluentValidation(v9.5.1)

- :pushpin:Microsoft.AspNetCore.Http(v2.2.2)

- :pushpin:Microsoft.AspNetCore.Http.Abstractions(v2.2.0)

- :pushpin:Microsoft.AspNetCore.Http.Features(v5.0.3)

- :pushpin:Microsoft.Extensions.DependencyInjection(v5.0.1)


:open_file_folder: [Abstract](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/Abstract)

- :page_facing_up:[IAuthService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IAuthService.cs)

- :page_facing_up:[IBrandService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IBrandService.cs)

- :page_facing_up:[ICarImageService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/ICarImageService.cs)

- :page_facing_up:[ICarService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/ICarService.cs)

- :page_facing_up:[IColorService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IColorService.cs)

- :page_facing_up:[ICreditCardService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/ICreditCardService.cs)

- :page_facing_up:[ICustomerFindexScoreService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/ICustomerFindeksScoreService.cs)

- :page_facing_up:[ICustomerService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/ICustomerService.cs)

- :page_facing_up:[IPaymentService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IPaymentService.cs)

- :page_facing_up:[IRentaCarService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IRentACarService.cs)

- :page_facing_up:[IUserService](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Abstract/IUserService.cs)

:open_file_folder:[BusinessAspect/Autofac](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/BusinessAspect/Autofac)

- :page_facing_up:[SecuredOperation](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/BusinessAspect/Autofac/SecuredOperation.cs)

:open_file_folder:[Concrete](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/Concrete)

- :page_facing_up:[AuthManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/AuthManager.cs)

- :page_facing_up:[BrandManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/BrandManager.cs)

- :page_facing_up:[CarImageManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/CarImageManager.cs)

- :page_facing_up:[CarManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/CarManager.cs)

- :page_facing_up:[ColorManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/ColorManager.cs)

- :page_facing_up:[CreditCardManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/CreditCardManager.cs)

- :page_facing_up:[CustomerFindexScoreManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/CustomerFindeksScoreManager.cs)

- :page_facing_up:[CustomerManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/CustomerManager.cs)

- :page_facing_up:[PaymentManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/PaymentManager.cs)

- :page_facing_up:[RentaCarManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/RentACarManager.cs)

- :page_facing_up:[UserManager](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Concrete/UserManager.cs)

:open_file_folder:[Constants](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/Constants)

- :page_facing_up:[Messages](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/Constants/Messages.cs)

:open_file_folder:[DependencyResolvers/Autofac](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/DependencyResolvers/Autofac)

- :page_facing_up:[AutoFacBusinessModule](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)

:open_file_folder:[ValidationRules/FluentValidation](https://github.com/hlmclgl/RentaCarProject/tree/master/Business/ValidationRules/FluentValidation)

- :page_facing_up:[BrandValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs)

- :page_facing_up:[CarValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)

- :page_facing_up:[ColorValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs)

- :page_facing_up:[CustomerValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)

- :page_facing_up:[RentaCarValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/RentACarValidator.cs)

- :page_facing_up:[UserValidator](https://github.com/hlmclgl/RentaCarProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)


## Core Layer ##

Core katmanı operasyonların generic yapılarla genelleştirildiği, her proje için kullanılabilecek potansiyele sahip bir katmandır.

  
  
  :mag_right:Bellek yönetimi(Caching)
  
  :mag_right:Operasyonların performans kontrolü(Performance)
  
  :mag_right:Bir grup operasyonun sırayla, sağlıklı bir şekilde çalışması için transaction yönetimi
  
  :mag_right:CRUD operasyonlarının sadace IEntity interface'ne bağımlı olan nesneler için genelleştirilmesi
  
  :mag_right:Genel bağımlılık zincirleri oluşturulması (Bu zincirlerin oluşumunda Autofac ten yararlanılmıştır.)
  
  :mag_right:CUD(IResult) ve R(IDataResult) operasyonları için ayrı ayrı error ve success yönetimi yapılması
  
  
  
  
## WebAPI ##

:package:**NuGet Packages**

  - :pushpin:Autofac.Extensions.DependencyInjection(v7.1.0)
  
  - :pushpin:Microsoft.AspNetCore.Authentication.JwtBearer(v3.1.12)
  

:open_file_folder:[Controllers](https://github.com/hlmclgl/RentaCarProject/tree/master/WebAPI/Controllers)

- :page_facing_up:[AuthController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/AuthController.cs)

- :page_facing_up:[BrandsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/BrandsController.cs)

- :page_facing_up:[CarImageController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/CarImageController.cs)

- :page_facing_up:[CarsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/CarsController.cs)

- :page_facing_up:[ColorsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/ColorsController.cs)

- :page_facing_up:[CreditCardsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/CreditCardsController.cs)

- :page_facing_up:[CustomersController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/CustomersController.cs)

- :page_facing_up:[CustomerFindexScoreController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/CustomersFindeksScoresController.cs)

- :page_facing_up:[PaymentsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/PaymentsController.cs)

- :page_facing_up:[RentaCarsController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/RentACarsController.cs)

- :page_facing_up:[UsersController](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Controllers/UsersController.cs)

:page_facing_up:[Program](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Program.cs)

:page_facing_up:[StartUp](https://github.com/hlmclgl/RentaCarProject/blob/master/WebAPI/Startup.cs)


