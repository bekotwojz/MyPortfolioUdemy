# 🧑‍💻 MyPortfolioUdemy

Murat Yücedağ eğitimleri kapsamında geliştirilen, ASP.NET Core MVC tabanlı kişisel portföy ve içerik yönetimi projesi.

![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)

## 📸 Projeden Görseller

<table>
	<tr>
		<td align="center"><strong>🌐 Portföy Ana Sayfası</strong><br><img src="wwwroot/proje%20g%C3%B6rselleri/Screenshot_1.png" alt="Portföy ana sayfası" width="100%"></td>
		<td align="center"><strong>🙋 Hakkımda</strong><br><img src="wwwroot/proje%20g%C3%B6rselleri/Screenshot_2.png" alt="Hakkımda ve yetenekler bölümü" width="100%"></td>
	</tr>
	<tr>
		<td align="center"><strong>📊 İstatistik Paneli</strong><br><img src="wwwroot/proje%20g%C3%B6rselleri/Screenshot_3.png" alt="Yönetim paneli istatistik ekranı" width="100%"></td>
		<td align="center"><strong>✅ Yapılacaklar Listesi</strong><br><img src="wwwroot/proje%20g%C3%B6rselleri/Screenshot_4.png" alt="Yönetim paneli yapılacaklar listesi" width="100%"></td>
	</tr>
</table>

## 🎯 Proje Hakkında

Proje, kişisel portföy içeriklerini ziyaretçilere sunarken bu içeriklerin ve gelen mesajların yönetilebildiği bir yönetim alanı da sağlar. Veriler Entity Framework Core üzerinden SQL Server'da saklanır.

## ✨ Özellikler

- Hakkımda, deneyim, yetenek, portföy, referans ve iletişim içerikleri
- Deneyim kayıtları için listeleme, ekleme, düzenleme ve silme
- Gelen mesajları görüntüleme, okundu durumunu değiştirme ve silme
- Yapılacaklar listesini oluşturma, güncelleme, silme ve tamamlandı durumunu değiştirme
- Yetenek ve mesaj sayılarını gösteren istatistik ekranı
- Entity Framework Core migration'larıyla veritabanı şeması yönetimi

## 🧰 Teknolojiler

- C# ve ASP.NET Core MVC (.NET 10)
- Razor Views ve View Components
- Entity Framework Core 10
- Microsoft SQL Server
- HTML, CSS ve JavaScript

## 📋 Gereksinimler

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server Express ve `SQLEXPRESS` adlı yerel instance
- Entity Framework Core CLI (`dotnet ef`)

> Veritabanı bağlantısı şu anda `DAL/Context/MyPortfolioContext.cs` içinde yapılandırılmıştır: `.\SQLEXPRESS` instance'ı ve `MyPortfolioDb` veritabanı kullanılır. Farklı bir SQL Server kurulumunuz varsa uygulamayı çalıştırmadan önce bağlantı ayarını kendi ortamınıza göre güncelleyin.

`dotnet ef` komutu bulunamazsa EF Core CLI aracını yükleyin:

```bash
dotnet tool install --global dotnet-ef --version 10.0.14
```

## 🚀 Kurulum ve Çalıştırma

```bash
git clone https://github.com/bekomeister/MyPortfolioUdemy.git
cd MyPortfolioUdemy
dotnet restore
dotnet ef database update
dotnet run
```

Uygulama başladıktan sonra terminalde gösterilen yerel adresi tarayıcıda açın. Geliştirme sırasında otomatik yeniden başlatma için `dotnet watch` komutunu kullanabilirsiniz.

## 🗂️ Proje Yapısı

```text
Controllers/     MVC controller'ları
DAL/             Entity Framework Core context'i ve entity sınıfları
Migrations/      Veritabanı migration'ları
Models/          Uygulama modelleri
ViewComponents/  Sayfa ve layout bileşenleri
Views/           Razor sayfaları
wwwroot/         CSS, JavaScript, görseller ve statik kütüphaneler
```

## ⚠️ Not

Bu çalışma bir eğitim projesidir. İnternete açık bir ortamda kullanmadan önce yönetim ekranları için kimlik doğrulama ve yetkilendirme ekleyin; veritabanı bağlantı bilgisini de güvenli yapılandırma veya ortam değişkenleri üzerinden yönetin.
