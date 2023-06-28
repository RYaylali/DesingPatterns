# DesingPatterns
# Chain Of Responsibility --> Zincir sistemi. En son kişi onaylayıp null dönene kadar devam eder
# CQRS Desing Paterns --> Okuma ve yazma işlemlerini birbirinden ayırma (Command,Resume,Query,Handler)
# Template Methot --> Tek bir abstract class üzerinden türeyen classlara farklı görevler vermek.Override methotları ile abstract class daki methotların görevleri classlara göre değişir. Örn(Çalıan abstractından türeyen classlar İtfyeci, Hemşire, Yönetici dir. Çalışan abstract class ındaki görev metotunun gövdesinin override edilişine göre farklı sonuçlar veren classlar türer)
# Observer -->Gözlemci. Abonelik sitemidir. Örn(Kayıt olunduğunda hoşgeldin mesajı, gazete listesi ve kayıt tarihlerini atılması sistematik olarak atılması isteniyorsa observerObject ile bu işlemler belirlenip metotlar ile kayıt olan kişilere ulaştırılması sağlanır. Bir telefon almak istediğinizde stoklarda bulunduğunda bilgi mesajı atılması)
# Unit Of Work ---> Save metotunu daha verimli kullanmak için ayrı bir repositoride sadece save metotunun kullanıldığı yerlere implemente etmek için bir repo oluşturulur ve kullanılan yerlere miras verilir. Save metotunu verimli kullanarak daha az veri tabanı ile iletişim kurulur
# Repository --> Crud metotları gibi sürekli tekrar eden metotlardaki tekrarlı yapının önüne geçmek için entity yerine generic yapı kullanılarak repositori yapıları oluşturulur.
