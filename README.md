# 🏡 Magic Villa API & Web Application

**Magic Villa**, modern bir villa yönetim sistemi geliştirmek amacıyla hazırlanmış tam kapsamlı bir web uygulamasıdır. Proje; güçlü, güvenli ve ölçeklenebilir bir **RESTful API** ile kullanıcı dostu bir **web arayüzünü** bir araya getirir. Uygulama, .NET 8.0 altyapısı ile inşa edilmiştir.

📚 Bu proje, **DotNetMastery** tarafından sağlanan eğitim serisi takip edilerek başarıyla tamamlanmıştır.  
👉 Eğitimi incelemek istersen: [DotNetMastery Udemy Eğitimi](https://www.udemy.com/course/restful-api-with-asp-dot-net-core-web-api/learn/lecture/33346038?start=0#overview)

---

## 🚀 Teknolojiler

### 🔧 Backend (MagicVilla_VillaAPI)
- .NET 8.0  
- Entity Framework Core 8.0  
- SQL Server  
- AutoMapper 11.0.1  
- JWT Authentication  
- Swagger / OpenAPI  
- API Versioning  
- Newtonsoft.Json  
- ASP.NET Identity  

### 💻 Frontend (MagicVilla_Web)
- ASP.NET Core MVC  
- Razor Views  
- Bootstrap 5  
- jQuery  
- JWT Authentication  

### 🔁 Ortak Kütüphaneler (MagicVilla_Utility)
- Shared DTOs  
- Common Models  
- Yardımcı Sınıflar ve Sabitler  

---

## ✨ Başlıca Özellikler

- ✅ Villa Yönetimi  
- ✅ Villa Numarası Yönetimi  
- ✅ Kullanıcı Kaydı ve Girişi (JWT ile)  
- ✅ Admin / User Yetkilendirme Sistemi  
- ✅ Swagger UI ile API Dokümantasyonu  
- ✅ API Versiyonlama  
- ✅ HTTPS Zorunluluğu  
- ✅ Mobil Uyumlu Web Arayüzü  

---

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
  
```
  
## Projeden Örnek Ekran Görüntüleri
![Image](https://github.com/user-attachments/assets/ebb57cf0-c738-4c9e-be5d-6ac91541bbf0)
