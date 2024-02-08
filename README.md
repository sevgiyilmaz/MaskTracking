
# Mikroservis Odaklı Maske Yönetim Sistemi
Proje, mikroservis mimarisini temel alarak geliştirilen bir maske takip sistemini içermektedir. Örnek olarak, dış SOAP servisin sisteme entegre edilmesi süreci gösterilmiştir. Mernis servisi entegrasyonu sayesinde kullanıcıların kimlik doğrulaması, kişisel bilgiler kullanılarak gerçekleştirilmekte ve bu doğrulama üzerinden maske başvuruları işlenmektedir.

Sistem, katmanlı bir mimariye sahiptir ve bu katmanlar arasında abstraction (soyutlama), dependency injection (bağımlılık enjeksiyonu) gibi kavramlar bulunmaktadır.

- Entities katmanında, kişi bilgilerinin bulunduğu bir entity olan Person örneği yer alır. 
- Business katmanında, iş kurallarının tanımlandığı bir katman bulunmaktadır. Örneğin, Mernis servisi entegrasyonu ile ilgili iş kuralları bu katmanda yer alabilir.
- Adapters katmanında ise Mernis sisteminin, adapter pattern kullanılarak sisteme entegre edildiği katman bulunmaktadır. Bu sayede dış servisin sisteme uyum sağlaması sağlanmaktadır.
