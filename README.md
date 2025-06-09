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

## 🔐 API Güvenliği

- JWT tabanlı kimlik doğrulama
- Role-based yetkilendirme
- API versiyonlama
- HTTPS zorunluluğu
