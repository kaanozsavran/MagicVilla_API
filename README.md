# Magic Villa API Project

Magic Villa, villa yönetimi için geliştirilmiş modern bir web uygulamasıdır. Bu proje, .NET 8.0 kullanılarak geliştirilmiş bir RESTful API ve web arayüzünden oluşmaktadır.

## 🚀 Teknolojiler

### Backend (MagicVilla_VillaAPI)
- **.NET 8.0**
- **Entity Framework Core 8.0**
- **SQL Server**
- **AutoMapper 11.0.1**
- **JWT Authentication**
- **Swagger/OpenAPI**
- **API Versioning**
- **Newtonsoft.Json**
- **Identity Framework**

### Frontend (MagicVilla_Web)
- **ASP.NET Core MVC**
- **Bootstrap**
- **jQuery**
- **AutoMapper**
- **JWT Authentication**

### Ortak Kütüphaneler (MagicVilla_Utility)
- **Shared DTOs**
- **Common Models**
- **Utility Classes**

## 📋 Özellikler

- Villa ve Villa Numarası yönetimi
- Kullanıcı kimlik doğrulama ve yetkilendirme
- JWT tabanlı güvenlik
- API versiyonlama
- Swagger UI ile API dokümantasyonu
- Responsive web arayüzü
- Role-based yetkilendirme (Admin/User)

## 🏗️ Proje Yapısı

```
MagicVilla_VillaAPI/
├── Controllers/         # API Controllers
├── Data/               # Database Context
├── Models/             # Domain Models
├── Repository/         # Repository Pattern Implementation
├── DTOs/               # Data Transfer Objects
└── Program.cs         # Application Configuration

MagicVilla_Web/
├── Controllers/        # MVC Controllers
├── Models/            # View Models
├── Views/             # Razor Views
├── Service/           # API Service Layer
└── wwwroot/           # Static Files

MagicVilla_Utility/
├── DTOs/              # Shared DTOs
└── Models/            # Shared Models
```

## 🚀 Başlangıç

### Gereksinimler
- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 veya VS Code

### Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/yourusername/MagicVilla_VillaAPI.git
```

2. Veritabanı bağlantı dizesini güncelleyin:
```json
// appsettings.json
{
  "ConnectionStrings": {
    "DefaultSQLConnection": "Server=your_server;Database=MagicVilla;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

3. Migration'ları uygulayın:
```bash
cd MagicVilla_VillaAPI
dotnet ef database update
```

4. Projeyi çalıştırın:
```bash
# API projesini başlatın
cd MagicVilla_VillaAPI
dotnet run

# Web projesini başlatın
cd MagicVilla_Web
dotnet run
```

## 🔐 API Güvenliği

- JWT tabanlı kimlik doğrulama
- Role-based yetkilendirme
- API versiyonlama
- HTTPS zorunluluğu

## 📚 API Dokümantasyonu

Swagger UI üzerinden API dokümantasyonuna erişebilirsiniz:
```
https://localhost:7001/swagger
```

## 🛠️ Geliştirme

### API Versiyonlama
Proje, API versiyonlamayı desteklemektedir. Yeni bir versiyon eklemek için:

1. Yeni bir controller oluşturun:
```csharp
[Route("api/v{version:apiVersion}/VillaAPI")]
[ApiController]
[ApiVersion("2.0")]
public class VillaAPIControllerV2 : ControllerBase
```

2. Program.cs'de versiyonlama ayarlarını güncelleyin.

### Repository Pattern
Proje, Repository Pattern kullanmaktadır. Yeni bir entity için:

1. Model oluşturun
2. Repository interface ve implementasyonu ekleyin
3. DTO'ları tanımlayın
4. Controller'ı oluşturun

## 🤝 Katkıda Bulunma

1. Fork'layın
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 👥 İletişim

Proje Sahibi - [@yourusername](https://github.com/yourusername)

Proje Linki: [https://github.com/yourusername/MagicVilla_VillaAPI](https://github.com/yourusername/MagicVilla_VillaAPI)
