# API Tabanlı Dinamik NPC ve Hikaye Motoru

Unity 6 URP içinde, oyuncu bağlamına göre diyalog ve görev üreten bir prototip. TÜBİTAK 2209-A kapsamında planlanan bitirme projesinin yazılım iskeletidir.

LLM çıktısı bir öneridir. Oyun durumunu değiştiren son karar, doğrulama katmanındadır. Geçersiz JSON, izinsiz eylem veya API kesintisi oyun durumunu değiştirmez; sistem yedek diyaloğa geçer.

İlk dikey dilim: tek köy bölgesi, en az bir NPC, dinamik diyalog ve bir görev zinciri. PC üzerinde ölçüm hedeflenir. Akıcılık hedefi, istek sırasında 60 FPS (kare süresi 16,7 ms) civarını korumaktır. Gecikme için literatür referansı, p95 yanıt süresinde 4 saniyedir.

## Mimari

Olaydan oyun eylemine giden zincir beş bileşenden oluşur.

| Bileşen | Sözleşme | Sorumluluk |
|---|---|---|
| Event Manager | `IEventManager` | Konuşma, bölgeye giriş ve eşya teslimini ilgili NPC’ye iletir. |
| NPC Brain | `INPCBrain` | Algılama, hafıza, karar ve prompt üretimini yönetir. |
| LLM Client | `ILLMClient` | Aracı sunucu üzerinden asenkron HTTP. Zaman aşımı, sınırlı yeniden deneme ve iptal. API anahtarı istemcide tutulmaz. |
| Action Validator | `IActionValidator` | Şema, izinli eylem, hedef, görev ve ön koşulları denetler. |
| Game Executor | `IGameExecutor` | Doğrulanan eylemi uygular. Hata durumunda yedek diyaloğu oynatır. |

JSON eylem sözleşmesi:

```json
{
  "dialogue": "İlacı nöbetçiye ulaştır.",
  "action": "offer_quest",
  "quest_id": "deliver_medicine",
  "target_id": "village_guard"
}
```

## Klasörler

```
llmContextualNpcSystem/Assets/Scripts/
  Core/     IEventManager, IGameExecutor
  NPC/      INPCBrain
  LLM/      ILLMClient, IActionValidator
  Models/   JSON ve oyun durumu sözleşmeleri
```

Somut sınıflar bu arayüzlere bağlanır. Ağ çağrıları `Task` ve `CancellationToken` kullanır; Unity ana iş parçacığı bekletilmez.

## Kurulum

1. Unity 6000.6 (URP şablonu) ile `llmContextualNpcSystem` klasörünü açın.
2. Editor derlemesi bitince `Assets/Scripts` altındaki sözleşmeler `Assembly-CSharp` içine girer.
3. LLM sağlayıcısı bu depoya eklenmez. İstemci, anahtarın durduğu bir aracı sunucuya istek atar.
4. Play Mode’da ilk kabul senaryoları: envanterde ot varken teslim görevi, ot yokken toplama görevi, tekrar teslimde ödülün bir kez verilmesi, geçersiz JSON’da yedek diyalog, API kesintisinde yerel yanıt.

## Ölçüm

Her istek için uçtan uca süre, token ve sonuç kodu kaydedilir. Karşılaştırma koşulları: sabit diyalog, yalnız LLM, LLM + doğrulama + önbellek.
