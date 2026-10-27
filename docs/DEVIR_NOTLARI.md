# Devir Notları (HANDOVER)

Bu dosya, sohbet veya yapay zeka değiştiğinde nereden devam edileceğini bulmak içindir. Her çalışma oturumunun sonunda "Durum" ve "Sıradaki adım" bölümlerini güncelleyin.

Son güncelleme: 2026-10-22

## Kaynak belge

Tasarım kaynağı: `docs/API_Tabanli_Dinamik_NPC_v2.pptx` (23 slayt). Slaytta olmayan özellik eklenmez; belirsizlikte kullanıcıya sorulur.

2209-A başvuru taslağı: `docs/2209-A_Arastirma_Onerisi.md` (kaynak metin). Aynı metin, şablondaki yönergeler korunarak `docs/2209-A_Arastirma_Onerisi.docx` dosyasına aktarıldı; şekiller `docs/figures/` altındadır. 2026-10-22'de danışman değerlendirme notuna (19.10.2026) ve 2026 çağrısı "Araştırma Önerisi İçeriğinde Dikkat Edilecek Hususlar" notuna göre yeniden yazıldı. Word ile açıldığında 14 sayfa, 13 tablo, 2 şekil. Kapak sayfası kaldırıldı (form başlığı üç kez tekrarlanıyordu); üstbilgi duruyor. Başlıkta "Unity" geçmez ve NPC kısaltması başlıkta açılır; anahtar kelimelerin baş harfleri büyüktür. Kısaltmalar Özet'te ve gövdede ilk geçtiği yerde parantezle açılır, sonra tekrar açılmaz. Ürün adları (Unity, Convai, NVIDIA ACE vb.) şimdilik duruyor (kullanıcı kararı). Sunum notlarındaki "kullanıcının sağladığı proje açıklaması" cümleleri forma girmez. Docx, md'den bir betikle üretildi ve betik depoda tutulmuyor; md değişirse docx'in de elle ya da yeniden üretilerek eşitlenmesi gerekir.

Taslakta bilinçli duran kararlar: tutarlılık 1–5 öznel puan değil, sayılan yedi maddelik kontrol listesidir (K1–K4 yapısal, K5–K7 anlamsal). Ana soru, yapısal doğrulamanın anlamsal tutarsızlıkların ne kadarını yakaladığıdır. Hipotezler: H1 bağlam ödünleşimi, H2 C1'de doğal geçersiz eylem oranı, H3 anlamsal tutarlılık, H4 kare süresi oranı (p95, en çok 1,5 kat). Önbellek ve 4 saniye referansı betimsel raporlanır; hata enjeksiyonu (S4, S5) hipotez değil kabul testidir. İkinci model (M2, açık ağırlıklı) ana tasarımdadır ve ölçüm bilgisayarından ayrı, kiralanan GPU'lu bir çıkarım sunucusunda çalışır; böylece çıkarım yükü kare süresini bozmaz ve H4 iki modelde ölçülür. 270 doğrulayıcı koşu. Takvim: İP1 2, İP2 3, İP3 4, İP4 3 ay. Üç boyutlu üretim ve mobil ölçüm hipotez dışındadır. Sonuç tablosu boştur. Bütçe 12.000 TL (çağrının üst sınırı; kullanılmayan tutar iade edilir, md. 6.2): API 2.000, GPU sunucu kiralama 8.000, fiyat/kur/yeniden koşu payı 2.000. Kalemler TYBS'ye ayrıca girilir; 5. bölümde Tablo 5 (token) ve Tablo 6 (kalemler) dayanak olarak durur. Birim fiyatlar varsayımdır: 500 ve 2.000 TL / milyon token (çıktı ×4), 50 TL / saat GPU (160 saat). Üretken yapay zekâ kullanım beyanı 5. bölümün sonunda yer alır. Aday ve danışman, grupta kullanılan bilgilerle dolduruldu: Muhammet Furkan Bilici, Arş. Gör. Dr. Hakan Aydın, Karadeniz Teknik Üniversitesi. Yanlışsa yalnız bu üç satır düzeltilir.

Biçim kuralları: Arial 9, ekler hariç en fazla 20 sayfa; 2026 çağrısında içerik TYBS'deki metin kutularına yapıştırılır ve "Proje Önerisini Önizle" ile kontrol edilir. Özet 25–450 kelime (şu an 393); 1.1, 1.2 ve 2. bölüm en az 350 karakter; çalışma takvimindeki katkı puanları 100; DOI'si olan kaynakta DOI zorunlu; tüm kaynaklara metinde atıf gerekir. Tarihler çağrıdaki proje başlangıcına göre kaydırılabilir, sıra değişmez.

2209-A 2026 Yılı Çağrı Duyurusu'ndan (tubitak.gov.tr, 2026-10-22'de okundu): başvuru 7 Ekim – 11 Kasım 2026 saat 17.30, kuruluş yetkilisi e-imzası 16–23 Kasım. Destek üst sınırı 12.000 TL; istenen bütçe başvuru kapandıktan sonra değiştirilemez (md. 2.2), bu yüzden 12.000 TL talebi sonradan artırılamaz. Proje süresi sonuçların ilanından itibaren en fazla 12 aydır (md. 6.1); takvimdeki gün/ay/yıl tarihleri bu nedenle tahmindir. Harcamalar fatura ile belgelenir ve fatura yürütücü adına kesilmelidir (md. 6.2); yabancı API sağlayıcısının fatura düzenleyip düzenlemediği önceden kontrol edilmeli. Başlıkta ve metinde kurum, firma, ticari ürün veya marka öne çıkarılmamalıdır (md. 4.1.8); EK-1'deki dört ticari araç ve metindeki ürün adları bu açıdan gözden geçirilmeli. Üretken yapay zekâ kullanımı TÜBİTAK ÜYZ Rehberi'ne uygun olmalı ve rehberdeki eşiğe göre beyan edilmelidir (md. 8.4–8.5); danışman metnin doğruluğundan sorumludur. Danışman aynı dönemde en fazla 5 projede görev alabilir (md. 4.1.7). Etik kurul yalnızca değerlendirmede gerekli görülürse istenir; projede insan katılımcı yoktur.

Kısa özet: Unity içinde LLM destekli NPC. Zincir: olay, NPC beyni, API katmanı, doğrulama, oyun eylemi. LLM çıktısı bir öneridir; son karar oyun kurallarındadır. İlk kapsam: tek köy bölgesi, iki NPC, bir görev zinciri (slayt 17).

## Çalışma kuralları (kullanıcı kararı)

- Kullanıcı onay vermeden branch açılmaz, commit atılmaz, push yapılmaz.
- Değişiklik öncesi onay beklenir; bilgi eksikse sorulur.
- Unity ana iş parçacığı bloklanmaz: `Task` + `CancellationToken`.
- API anahtarı istemcide tutulmaz (aracı sunucu).
- JSON sözleşmesi slayt 7 örneğine sadık kalır: `dialogue`, `action`, `quest_id`, `target_id`.
- Geçersiz yanıt oyun durumunu değiştirmez; yedek diyalog devreye girer.
- Durum sürümü (`StateVersion`) JSON'da değil, istek/olay tarafında tutulur.

## Ortam

- Unity 6000.6.0f1, URP 17.6.0. Proje: `llmContextualNpcSystem/`.
- Unity MCP: `user-unity-mcp` çalışıyor (`Unity_RunCommand`, `Unity_GetConsoleLogs`). `user-unityMCP` hata durumunda, kullanılmıyor.
- Shell komutları sandbox nedeniyle `required_permissions: all` gerektirebilir.
- Git: dal `main`. `.gitignore` ve `README.md` değişti. `docs/` ve `llmContextualNpcSystem/` henüz izlenmiyor (commit bekliyor).

## Durum (yapılanlar)

`docs/2209-A_Arastirma_Onerisi.md` yazıldı (2026-10-17) ve 2026-10-22'de danışman notuna göre yeniden kuruldu. Kök `.gitignore` (Unity yolları `llmContextualNpcSystem/` önekli) ve `README.md` hazır.

`llmContextualNpcSystem/Assets/Scripts/` altında yalnızca arayüz ve veri sözleşmesi var (somut sınıf yok):

| Klasör | Dosyalar | Namespace |
|---|---|---|
| Core | `IEventManager`, `IGameExecutor` | `LlmContextualNpc.Core` |
| NPC | `INPCBrain`, `NpcDecision` | `LlmContextualNpc.Npc` |
| LLM | `ILLMClient`, `IActionValidator` | `LlmContextualNpc.Llm` |
| Models | `LlmActionResponse`, `LlmPrompt`, `LlmTransportPolicy`, `GameEvent`, `GameStateSnapshot`, `ActionValidationResult`, `FallbackReason` | `LlmContextualNpc.Models` |

Doğrulama: Unity derlemesi temiz, konsolda hata yok (2026-10-08).

## Bilinen riskler ve açık noktalar

1. `LlmActionResponse` `System.Text.Json` kullanıyor. Editor'de derleniyor; Player (Windows) build'inde çalıştığı henüz denenmedi. Sorun çıkarsa `com.unity.nuget.newtonsoft-json` veya `JsonUtility` düşünülür (kullanıcıya sorulur).
2. Slayt 8 (S3 tekrar teslim): "işlem kimliği" gerekiyor, ama `IGameExecutor.ApplyAsync` bir `OperationId` almıyor. Executor yazılmadan önce arayüze eklenmesi önerilir (kullanıcı onayı gerekir).
3. Asmdef yok. Testler ve ileride Asset Store paketi için ayrı derleme birimi gerekir.
4. `Assets/TutorialInfo` Unity şablonundan gelen örnek dosyalar; silinip silinmeyeceği kullanıcıya sorulmadı.

## Başvuru metninde başvuru öncesi kontrol

1. Metni sesli okuyup kendi cümlesi olmayan yerleri yeniden yazmak.
2. On beş kaynağın DOI veya yayımcı sayfasını tek tek açmak. Gallotta vd. (2024) erken görünümde; cilt ve sayfa IEEE Xplore’da netleşmişse künyeye eklenir.
3. TYBS'deki metin kutularına aktarıp "Proje Önerisini Önizle" ile kontrol etmek; ekler hariç 20 sayfayı aşmadığına bakmak.
4. Danışman ve aday bilgisini çağrı metniyle karşılaştırmak.
5. Danışmanla netleştirmek: H1–H3 ön eşikleri (%25 ve 0,10; %10; 0,95), H4 oranı (1,5), doğal senaryo kümesi (10 söylem × 3 durum), takvim dağılımı (2/3/4/3 ay), M2'nin ayrı GPU sunucusunda çalışması ve 12.000 TL bütçe kalemleri.
6. Token birim fiyatını ve GPU saatlik bedelini seçilecek model ve sağlayıcının güncel fiyatıyla değiştirip Tablo 5 ve 6'yı yeniden hesaplamak. Ekim 2026'da 24 GB'lık GPU'lar için bulut liste fiyatı saatte yaklaşık 0,3–0,75 USD (kur ≈ 49,4 TL); belgedeki 50 TL/saat bunun üzerinde bir üst sınırdır. Kaynak ikincil karşılaştırma siteleridir, sağlayıcı sayfasından doğrulanmadı.
11. H2 ölçütü danışmana sorulacak: gözlenen oran ≥ eşik biçimindeki ölçüt, gerçek oran eşiğe eşitse yaklaşık %50–60 güçle çalışır (30 koşuda gerçek %10 ise ≥3 ihlal olasılığı 0,59); alternatif, oranı güven aralığıyla kestirmek ve "en az bir ihlal" ölçütünü kullanmaktır.
7. GPU sunucu sağlayıcısını seçmek (fatura yürütücü adına ve belgelenebilir olmalı, md. 6.2) ve M2 için model/sürüm denemesi yapmak; olmazsa risk tablosundaki B planı geçerlidir.
8. 1.1'deki Kalkınma Planı bağı yapay zekâ ve dijital ekonomi üzerinden kuruldu; planın metninde "dijital oyun" ifadesi doğrulanmadı. Bulunursa [16]'ya sayfa/ölçü numarasıyla eklenir.
9. Şekil 2, depodaki kaynak dosyalardan üretilmiş bir kod görünümüdür; Unity Editor'dan Project ve Console penceresi ekran görüntüsü alınıp yerine konabilir.
10. Üretken yapay zekâ beyanı iki aracı kapsar (kullanıcı teyidiyle): Cursor üzerinden xAI Grok 4.7 proje tabanını (Unity iskeleti, sözleşmeler) ve başlangıç belgelerini, önerinin ilk yazımı dahil, hazırladı; Claude Sonnet 5.5 (Claude Code) 22 Ekim 2026 sürümünde danışman notuna göre hipotez, yöntem ve bütçeyi yeniden kurdu, metni yazıp düzenledi, tablo ve şekilleri hazırladı. Başka bir araç kullanıldıysa eklenmeli; TÜBİTAK ÜYZ Rehberi okunmalı ve beyan TYBS'deki alanla uyumlu tutulmalıdır.

## Sıradaki adım (öneri, onay bekliyor)

Belge planına göre şu an 1–3. hafta çıktıları ("senaryo, olay modeli, JSON sözleşmesi") tamamlanıyor. Önerilen sonraki dilim:

1. Asmdef: `LlmContextualNpc.Runtime` ve `LlmContextualNpc.Tests.EditMode`. Test Framework 1.8.0 projede zaten var.
2. Karar: `OperationId` arayüze eklensin mi (risk 2).
3. İlk somut sınıf: `ActionValidator` (saf C#, Unity'ye bağımlı değil). Kontroller: şema, izinli eylem, hedef/görev varlığı, ön koşul (envanter).
4. EditMode testleri: S1 ot var, S2 ot yok, S4 bozuk JSON / izinsiz eylem (H1 ölçütü: geçersiz eylem durumu değiştirmez).
5. Sonra (4–7. hafta bloğu): `EventManager`, sahte `ILLMClient` ile uçtan uca, ardından gerçek HTTP istemcisi ve aracı sunucu.

Her adımdan önce kullanıcıdan onay alın.

## Sonraki oturum için hızlı kontrol

1. `git status` ve bu dosyayı okuyun.
2. Unity konsolunda derleme hatası olmadığını doğrulayın.
3. "Sıradaki adım" listesinden onaylanan maddeyi yapın, sonra bu dosyayı güncelleyin.
