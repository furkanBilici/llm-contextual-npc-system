# Devir Notları (HANDOVER)

Bu dosya, sohbet veya yapay zeka değiştiğinde nereden devam edileceğini bulmak içindir. Her çalışma oturumunun sonunda "Durum" ve "Sıradaki adım" bölümlerini güncelleyin.

Son güncelleme: 2026-10-08

## Kaynak belge

`docs/API_Tabanli_Dinamik_NPC_v2.pptx` (23 slayt). Tek doğruluk kaynağı budur. Belgede olmayan özellik eklenmez; belirsizlikte kullanıcıya sorulur.

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

Kök `.gitignore` (Unity yolları `llmContextualNpcSystem/` önekli) ve `README.md` hazır.

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
