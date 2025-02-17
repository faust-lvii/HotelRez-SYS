$content = @"
>> # 🏨 HotelRez-SYS - Otel Rezervasyon ve Yönetim Sistemi
>> 
>> Modern ve kapsamlı otel yönetimi için geliştirilmiş profesyonel bir rezervasyon ve yönetim sistemi.
>> 
>> ## 🚀 Özellikler
>> 
>> ### Müşteri Yönetimi
>> - Müşteri kayıt ve profil yönetimi
>> - Detaylı müşteri bilgi saklama (TC No, İletişim, Adres)
>> - Müşteri geçmişi ve rezervasyon takibi
>> 
>> ### Oda Yönetimi
>> - Farklı oda tiplerinin yönetimi
>> - Oda durumu takibi (Müsait, Dolu, Temizlik, Bakım)
>> - Dinamik fiyatlandırma sistemi
>> - Kat ve oda numarası bazlı organizasyon
>> 
>> ### Rezervasyon Sistemi
>> - Gelişmiş rezervasyon oluşturma ve yönetimi
>> - Check-in/Check-out takibi
>> - Özel isteklerin kaydı
>> - Rezervasyon durumu izleme
>> - Çoklu misafir kaydı
>> 
>> ### Fatura ve Ödeme
>> - Otomatik fatura oluşturma
>> - Ödeme takibi
>> - Detaylı fiyatlandırma
>> - Fatura durumu yönetimi
>> 
>> ## 🛠 Teknoloji Stack
>> 
>> - **.NET 8.0**
>> - **Windows Forms**
>> - **Entity Framework Core**
>> - **MS SQL Server**
>> - **C# 12**
>> 
>> ## 📋 Sistem Gereksinimleri
>> 
>> - Windows 10/11
>> - .NET 8.0 Runtime
>> - MS SQL Server 2019+
>> - Minimum 4GB RAM
>> - 1GB disk alanı
>> 
>> ## ⚙️ Kurulum
>> 
>> 1. Repoyu klonlayın:
>> \`\`\`bash
>> git clone https://github.com/faust-lvii/HotelRez-SYS.git
>> \`\`\`
>> 
>> 2. Veritabanını oluşturun:
>> \`\`\`bash
>> dotnet ef database update
>> \`\`\`
>> 
>> 3. Projeyi derleyin ve çalıştırın:
>> \`\`\`bash
>> dotnet build
>> dotnet run
>> \`\`\`
>>
>> ## 🗄️ Veritabanı Yapısı
>>
>> ### Ana Tablolar
>> - **Customers**: Müşteri bilgileri
>> - **Rooms**: Oda bilgileri
>> - **RoomTypes**: Oda tipleri
>> - **Reservations**: Rezervasyon kayıtları
>> - **Invoices**: Fatura bilgileri
>>
>> ## 👥 Katkıda Bulunma
>>
>> 1. Fork yapın
>> 2. Feature branch oluşturun
>> 3. Değişikliklerinizi commit edin
>> 4. Branch'inizi push edin
>> 5. Pull Request oluşturun
>>
>> ## 📝 Lisans
>>
>> Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasını inceleyiniz.
>>
>> ## 📞 İletişim
>>
>> Proje Sorumlusu: [Faust LVII](https://github.com/faust-lvii)
>>
>> ## 🔄 Versiyon Geçmişi
>>
>> - **v1.0.0** - İlk kararlı sürüm
>>   - Temel rezervasyon sistemi
>>   - Müşteri yönetimi
>>   - Oda yönetimi
>>   - Fatura sistemi
>> "@
