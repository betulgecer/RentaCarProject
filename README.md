# RentaCarProject

## English Below ##

RentaCarProject, SOLID prensiplerine bağlı kalınarak ve N-Katmalı mimari yapısıyla C# programlama diline ait; henüz geliştirilme aşamasında olan bir araç kiralama projesidir. Şu anda projenin back-end kısmını incelemektesiniz.

***:link:Projenin front-end kısmına [buradan](https://github.com/hlmclgl/RentaCarProject-Frontend) ulaşabilirsiniz.***

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

  
  
  :star:Bellek yönetimi(Caching)
  
  :star:Operasyonların performans kontrolü(Performance)
  
  :star:Bir grup operasyonun sırayla, sağlıklı bir şekilde çalışması için transaction yönetimi
  
  :star:CRUD operasyonlarının sadace IEntity interface'ne bağımlı olan nesneler için genelleştirilmesi
  
  :star:Genel bağımlılık zincirleri oluşturulması (Bu zincirlerin oluşumunda Autofac ten yararlanılmıştır.)
  
  :star:CUD(IResult) ve R(IDataResult) operasyonları için ayrı ayrı error ve success yönetimi yapılması
  
  Alt kısımdaki bağlantıları kullanarak detayları inceleyebilirsiniz.
  
  :package:**NuGet Packages**
  
 - :pushpin:Autofac(v6.1.0)

 - :pushpin:Autofac.Extras.DynamicProxy(v6.0.0)

 - :pushpin:FluentValidation(v9.5.1)

 - :pushpin:Microsoft.AspNetCore.Http(v2.2.2)

 - :pushpin:Microsoft.AspNetCore.Http.Features(v5.0.3)

 - :pushpin:Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)

 - :pushpin:Microsoft.IdentityModel.Tokens(v6.8.0)

 - :pushpin:System.IdentityModel.Tokens.Jwt(v6.8.0)

:open_file_folder: [Aspects/Autofac](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac)
- :open_file_folder:[Caching](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Caching)
 
  - :page_facing_up:[Cache Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs)

  - :page_facing_up:[Cache Remove Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs)

- :open_file_folder:[Performance](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Performance)

  - :page_facing_up:[PerformanceAspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)

- :open_file_folder:[Transaction](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Transaction)

  - :page_facing_up:[Transaction Scope Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs)

- :open_file_folder:[Validation](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Validation)

  - :page_facing_up:[Validation Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)

:open_file_folder:[Cross Cutting Conserns](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns)

- :open_file_folder:[Caching](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Caching)

  - 📂[Microsoft](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Caching/Microsoft)
    
       - :page_facing_up:[Memory Cache Manager](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)

  - 📄[ICache Manager](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Caching/ICacheManager.cs)

- :open_file_folder:[Validation](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Validation)

  - 📄[Validation Tool](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)

:open_file_folder:[Data Access](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DataAccess)

- :open_file_folder:[EntityFramework](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DataAccess/EntityFramework)

  - :page_facing_up:[EfEntity Repository Base](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)

- 📄[IEntity Repository](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DataAccess/IEntityRepository.cs)

📂[Dependency Resolvers](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DependencyResolvers)

 - 📄[Core Module](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DependencyResolvers/CoreModule.cs)

📂[Entities](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities)

 - 📂[Abstract](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities/Abstract)

   - 📄[IEntity](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Abstract/IEntity.cs)

   - 📄[IDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Abstract/IDto.cs)

 - 📂[Concrete](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities/Concrete) 📌Login, register işlemleri ve bir kullacıya atanan roller genel olarak her projede olmasından dolayı bu işlemlere ait nesneler Core katmanın da oluşturulmutur.

   - 📄[Operation Claim](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/OperationClaim.cs)

   - 📄[User](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/User.cs)

   - 📄[User Operation Claim](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/UserOperationClaim.cs)

📂[Extensions](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Extensions)

 - 📄[Claim Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ClaimExtensions.cs)

 - 📄[Claims Principal Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs)

 - 📄[Error Details](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ErrorDetails.cs)

 - 📄[Exception Middleware](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ExceptionMiddleware.cs)

 - 📄[Exception Middleware Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ExceptionMiddlewareExtensions.cs)

 - 📄[Service Collection Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ServiceCollectionExtensions.cs)

📂[Utilities](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities)

 - 📂[Business](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Business)

   - 📄[Business Rules](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Business/BusinessRules.cs) :pushpin:İş kurallarının genel bir yapıdan geçmesi sağlanılmıştır.

 - 📂[Helpers](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Helpers)

   - 📄[File Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Helpers/FileHelper.cs) 📌Dosya işlemleri CRUD operasyonları için genel hale getirilmiştir.

 - 📂[IOC](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/IOC)

   - 📄[ICore Module](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/IOC/ICoreModule.cs)

   - 📄[Service Tool](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/IOC/ServiceTool.cs)

 - 📂[Interceptors](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Interceptors)

   - 📄[Aspect Interceptor Selector](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)

   - 📄[Method Interception](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)

   - 📄[Method Interception Base Attribute](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)

 - 📂[Results](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Results) 📌Kullanıcıya yansıyacak sonuçlar kontrol altına alınmıştır.

   - 📄[Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/DataResult.cs)

   - 📄[Error Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs)

   - 📄[Error Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/ErrorResult.cs)

   - 📄[IData Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/IDataResult.cs)

   - 📄[IResult](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/IResult.cs)

   - 📄[Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/Result.cs)

   - 📄[Success Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs)

   - 📄[Success Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/SuccessResult.cs)

 - 📂[Security](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security) 📌Kullanıcıyla ilgili güvenlik işlemleri aşağıda gerçekleşmiştir.

   - 📂[Encyption](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/Encyption)

      - 📄[Security Key Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Encyption/SecurityKeyHelper.cs)

      - 📄[Signing Credentials Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Encyption/SigningCredentialsHelper.cs)

   - 📂[Hashing](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/Hashing)

      - 📄[Hashing Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs)

   - 📂[JWT](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/JWT)

      - 📄[Access Token](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/AccessToken.cs)

      - 📄[IToken Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs)

      - 📄[JWT Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs)

      - 📄[Token Options](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs)


  
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

 ### :pushpin:***LinkedIn hesabıma [buradan](https://www.linkedin.com/in/ahmet-hilmi-%C3%A7ilo%C4%9Flu-884012203/) ulaşabilirsiniz.*** ###
 
 ### :e-mail:***E-mail: hlmclgl@gmail.com*** ###

# RentaCarProject

## English Description ##

RentaCarProject is a car rental project that belongs to the C# programming language, adhering to SOLID principles and with an N-layer architecture structure; it is still under development. You are currently studying the back-end part of the project.

***:link:You can arrive at the front-end section [from here](https://github.com/hlmclgl/RentaCarProject-Frontend).***

The database was created based on the SQL Server Object Explorer section in Visual Studio 2019. At the bottom, you can see the field names and data types of some tables belonging to this database.

:open_file_folder:[Database](https://github.com/hlmclgl/RentaCarProject/tree/master/DB)

RentaCarProject consists of Entities, DataAccess, and Business layers. Initially, the ConsoleUI layer was used to simulate operations on these layers. Later, Postman was used to test operations with WebAPI configuration in the project. Let's examine these layers closely:

## Entities Layer ##
This layer is created for database objects. In the Concrete folder, there are only 'classes 'created for tables, while in the DTOs folder section, there are 'classes' created to combine properties in different tables. You can review the details using the links at the bottom.

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

Database-related operations and database connections are located on this layer. You can review the details using the links at the bottom.

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
  
:link:The InMemory Folder is not a connection to the contents database, but was created for testing purposes only for startup.


## Business Layer ##

Business rules for Operations contained in the DataAcess layer are included in this layer. You can review the details using the links at the bottom.

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

The Core layer is a layer where operations are generalized with generic structures, with potential that can be used for each project.

  :star:Memory management(Caching)
  
  :star:Performance control of operations(Performance)
  
  :star:Transaction management for a group of operations to work sequentially, in a healthy way
  
  :star:Generalization of CRUD operations for objects that depend only on the IEntity interface
  
  :star:Creating general dependency chains ( Was used in the formation of these chains from Autofac.)
  
  :star:CUD(IResult) and R(IDataResult) individual error and success management for operations
  
  You can review the details using the links at the bottom.
  
  :package:**NuGet Packages**
  
 - :pushpin:Autofac(v6.1.0)

 - :pushpin:Autofac.Extras.DynamicProxy(v6.0.0)

 - :pushpin:FluentValidation(v9.5.1)

 - :pushpin:Microsoft.AspNetCore.Http(v2.2.2)

 - :pushpin:Microsoft.AspNetCore.Http.Features(v5.0.3)

 - :pushpin:Microsoft.EntityFrameworkCore.SqlServer(v3.1.11)

 - :pushpin:Microsoft.IdentityModel.Tokens(v6.8.0)

 - :pushpin:System.IdentityModel.Tokens.Jwt(v6.8.0)

:open_file_folder: [Aspects/Autofac](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac)
- :open_file_folder:[Caching](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Caching)
 
  - :page_facing_up:[Cache Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs)

  - :page_facing_up:[Cache Remove Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs)

- :open_file_folder:[Performance](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Performance)

  - :page_facing_up:[PerformanceAspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)

- :open_file_folder:[Transaction](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Transaction)

  - :page_facing_up:[Transaction Scope Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs)

- :open_file_folder:[Validation](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Aspects/Autofac/Validation)

  - :page_facing_up:[Validation Aspect](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)

:open_file_folder:[Cross Cutting Conserns](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns)

- :open_file_folder:[Caching](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Caching)

  - 📂[Microsoft](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Caching/Microsoft)
    
       - :page_facing_up:[Memory Cache Manager](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)

  - 📄[ICache Manager](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Caching/ICacheManager.cs)

- :open_file_folder:[Validation](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/CrossCuttingConcerns/Validation)

  - 📄[Validation Tool](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)

:open_file_folder:[Data Access](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DataAccess)

- :open_file_folder:[EntityFramework](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DataAccess/EntityFramework)

  - :page_facing_up:[EfEntity Repository Base](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)

- 📄[IEntity Repository](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DataAccess/IEntityRepository.cs)

📂[Dependency Resolvers](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/DependencyResolvers)

 - 📄[Core Module](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/DependencyResolvers/CoreModule.cs)

📂[Entities](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities)

 - 📂[Abstract](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities/Abstract)

   - 📄[IEntity](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Abstract/IEntity.cs)

   - 📄[IDto](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Abstract/IDto.cs)

 - 📂[Concrete](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Entities/Concrete) 📌Because Login, register operations, and roles assigned to a user are usually in each project, objects belonging to these operations are also created in the Core layer.

   - 📄[Operation Claim](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/OperationClaim.cs)

   - 📄[User](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/User.cs)

   - 📄[User Operation Claim](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Entities/Concrete/UserOperationClaim.cs)

📂[Extensions](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Extensions)

 - 📄[Claim Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ClaimExtensions.cs)

 - 📄[Claims Principal Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs)

 - 📄[Error Details](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ErrorDetails.cs)

 - 📄[Exception Middleware](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ExceptionMiddleware.cs)

 - 📄[Exception Middleware Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ExceptionMiddlewareExtensions.cs)

 - 📄[Service Collection Extensions](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Extensions/ServiceCollectionExtensions.cs)

📂[Utilities](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities)

 - 📂[Business](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Business)

   - 📄[Business Rules](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Business/BusinessRules.cs) :pushpin:Business rules are provided to pass through a general structure.

 - 📂[Helpers](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Helpers)

   - 📄[File Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Helpers/FileHelper.cs) 📌File operations are generalised for CRUD operations.

 - 📂[IOC](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/IOC)

   - 📄[ICore Module](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/IOC/ICoreModule.cs)

   - 📄[Service Tool](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/IOC/ServiceTool.cs)

 - 📂[Interceptors](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Interceptors)

   - 📄[Aspect Interceptor Selector](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)

   - 📄[Method Interception](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)

   - 📄[Method Interception Base Attribute](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)

 - 📂[Results](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Results) 📌The results that will be reflected to the user are under control.

   - 📄[Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/DataResult.cs)

   - 📄[Error Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/ErrorDataResult.cs)

   - 📄[Error Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/ErrorResult.cs)

   - 📄[IData Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/IDataResult.cs)

   - 📄[IResult](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/IResult.cs)

   - 📄[Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/Result.cs)

   - 📄[Success Data Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/SuccessDataResult.cs)

   - 📄[Success Result](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Results/SuccessResult.cs)

 - 📂[Security](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security) 📌User-related security operations are performed below.

   - 📂[Encyption](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/Encyption)

      - 📄[Security Key Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Encyption/SecurityKeyHelper.cs)

      - 📄[Signing Credentials Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Encyption/SigningCredentialsHelper.cs)

   - 📂[Hashing](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/Hashing)

      - 📄[Hashing Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs)

   - 📂[JWT](https://github.com/hlmclgl/RentaCarProject/tree/master/Core/Utilities/Security/JWT)

      - 📄[Access Token](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/AccessToken.cs)

      - 📄[IToken Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs)

      - 📄[JWT Helper](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs)

      - 📄[Token Options](https://github.com/hlmclgl/RentaCarProject/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs)


  
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

 ### :pushpin:***You can access my LinkedIn account [from here](https://www.linkedin.com/in/ahmet-hilmi-%C3%A7ilo%C4%9Flu-884012203/).*** ###
 
 ### :e-mail:***E-mail: hlmclgl@gmail.com*** ###
 
 ## **License** ##

:balance_scale: [MIT :copyright: 2021 Ahmet Hilmi Çiloğlu](https://github.com/hlmclgl/RentaCarProject/blob/master/LICENSE.md)
