# ⚔️ Phi Kiếm Song Hành

> Game casual hành động–giải đố theo màn, nơi người chơi điều khiển **hai kiếm khách** — **Lăng Phong** và **Nguyệt Dao** — bay qua một thế giới Đông Á huyền huyễn trên mây, chuyển đổi giữa hai nhân vật để xử lý đúng loại chướng ngại, thu thập linh khí và đánh bại boss.

**Trạng thái:** `v0.1 — Concept / Pre-production`  ·  **Nền tảng:** Mobile (Landscape)  ·  **Engine:** Unity 6 (6000.3.10f1)

---

## 🎮 Game là gì?

Trong vương quốc **Thiên Vân Quốc** trên mây, **Lưỡng Nghi Ngọc** bị vỡ khiến linh khí rò rỉ, phong ấn mất kiểm soát và thần thú trở nên hung dữ. Hai kiếm khách **Lăng Phong** và **Nguyệt Dao** lên đường truy tìm các mảnh ngọc để khôi phục cân bằng cho vùng đất.

Người chơi bay trên phi kiếm, **liên tục chuyển đổi giữa hai nhân vật** để vượt qua đúng loại chướng ngại trong những màn chơi ngắn 1–3 phút.

> **Fantasy cốt lõi:** Làm chủ một cặp kiếm khách bổ trợ lẫn nhau, lướt qua cảnh quan ngoạn mục và khôi phục cân bằng cho vùng đất trên mây.

### Thông tin sản phẩm
| Hạng mục | Chi tiết |
|---|---|
| Thể loại | Casual Action–Puzzle / Obstacle Runner |
| Nền tảng | Mobile |
| Hướng màn hình | Landscape |
| Chế độ | Single-player, level-based |
| Camera | Third-person, hơi nhìn từ trên xuống |
| Thời lượng/màn | 1–3 phút |
| Đối tượng | Người chơi casual từ ~10 tuổi |

---

## 🔁 Core Loop

```
Bay → Quan sát → Chuyển nhân vật → Né / Phá / Xuyên chướng ngại
   → Thu thập linh khí → Tích combo & kỹ năng → Cao trào / Boss
   → Nhận sao → Mở màn tiếp theo
```

---

## 🗡️ Cơ chế cốt lõi: Chuyển đổi Song Hành (USP)

Điểm nhận diện của game là **chuyển đổi hai nhân vật gắn trực tiếp với thiết kế chướng ngại**:

| | **Lăng Phong — Kiếm khách Dương** | **Nguyệt Dao — Pháp kiếm sư Âm** |
|---|---|---|
| Vai trò | Sức mạnh, phá hủy, tấn công vật lý | Linh hoạt, phép thuật, thu thập |
| Xử lý chướng ngại | Vật lý (đỏ/cam): cửa gỗ, đá nứt, giáp | Phép (tím/xanh): kết giới, pháp trận |
| Năng lực | Đánh bật enemy, sát thương điểm yếu vật lý | Xuyên kết giới, kích pháp trận, hút linh khí xa |
| Skill đề xuất | *Phá Không Trảm* (dash phá vật cản) | *Linh Ảnh Bộ* (hóa linh thể, làm chậm đạn) |
| Màu chủ đạo | Xanh lam · trắng · điểm vàng | Đỏ son · trắng · điểm hồng/tím |

> Tên *Lăng Phong* / *Nguyệt Dao* hiện là tên tạm và có thể thay đổi sau khi chốt lore.

**⚡ Perfect Switch:** Chuyển đúng nhân vật trong cửa sổ **0,3–0,5 giây** trước điểm tương tác → kích hoạt slow-motion rất ngắn, **+combo, +điểm, +linh khí**, nạp nhanh thanh Song Hành và tăng cường VFX/âm thanh. Hệ thống thưởng cho kỹ năng & timing, không chỉ phạt sai lầm.

**Năng lực Song Hành:** Khi thanh năng lượng đầy, cả hai cùng xuất hiện trong thời gian ngắn — dùng đồng thời hai loại năng lực, hút toàn bộ linh khí gần đó và miễn mất combo ở va chạm đầu tiên.

---

## 🕹️ Điều khiển & Hệ thống chơi

- **Kéo ngón tay:** di chuyển nhân vật theo mặt phẳng ngang và dọc giới hạn.
- **Chạm chân dung:** chuyển Lăng Phong ↔ Nguyệt Dao.
- **Chạm kỹ năng:** dash / năng lực nhân vật.
- **Tự động:** tiến về phía trước, thu thập khi chạm và tấn công mục tiêu hợp lệ.

**Hậu quả khi chuyển sai / trễ (theo mức độ — thân thiện với người chơi casual):**
- **Sai nhẹ:** bỏ lỡ coin/linh khí/đường thưởng — *không mất tim*.
- **Sai vừa:** mất combo hoặc giảm tốc ngắn; đòn không trúng điểm yếu boss — vẫn chơi tiếp.
- **Sai nặng:** mất 1 tim, reset combo, choáng ~0,5s rồi nhận **1–1,5s bất tử**.
- **Cổng bắt buộc & chống kẹt:** chọn sai ở cổng không né được → giữ lại rất ngắn rồi game tự chuyển sang nhân vật phù hợp; không bao giờ bị kẹt vô hạn.

**Health & Failure:** Bắt đầu với **3 tim**. Hết tim → thất bại (có thể hồi sinh 1 lần bằng vật phẩm/rewarded ad sau MVP).

**Hỗ trợ người chơi mới:** Ở các level đầu, portrait đúng nhấp nháy khi obstacle đến gần, có âm thanh cảnh báo, làm chậm 20–30% lần đầu gặp cơ chế và phóng to nút switch — trợ giúp giảm dần khi người chơi đã quen.

**Collectibles:** Linh khí (điểm/năng lượng) · Đồng cổ (tiền nâng cấp) · Mảnh Lưỡng Nghi Ngọc (mở cốt truyện) · Khiên linh lực · Nam châm.

**Combo:** Tăng khi thu thập liên tục, chuyển đúng nhân vật, né sát, phá chướng ngại — `x10` nhân điểm, `x20` tăng nạp kỹ năng, `x30` kích hoạt Song Hành.

**Chấm sao:** ⭐ Hoàn thành màn · ⭐⭐ Đạt mục tiêu linh khí/điểm · ⭐⭐⭐ Không mất tim hoặc đạt combo yêu cầu.

---

## 🗺️ Thế giới & Chapter

Trải dài qua các vùng đất nổi của **Thiên Vân Quốc**:

1. **Cổ Thành Thiên Đăng** — phố cổ, đèn lồng, cổng gỗ. Boss: *Sư Tử Đá*.
2. **Trúc Lâm Linh Vụ** — rừng trúc, sương, gió ngang. Boss: *Hồ Ly Linh*.
3. **Vân Sơn Tự** — núi cao, thác nước, chùa trên mây. Boss: *Vân Long*.
4. **Hoàng Thành Nhật Thực** — cung điện bị linh khí tối bao phủ. Boss: *Người canh giữ Lưỡng Nghi Ngọc*.

---

## 🎨 Định hướng Nghệ thuật & Âm thanh

- **Art:** Đông Á huyền huyễn, stylized và sáng rõ; thế giới hư cấu, tránh gán ghép lịch sử cụ thể.
- **Ưu tiên đọc được (readability):** màu gameplay ưu tiên khả năng đọc hơn tính hiện thực; tuyến bay và obstacle luôn sạch.
- **VFX là ngôn ngữ cơ chế:** trail phi kiếm, switch burst, physical break, spirit phase, combo milestone, boss weak point.
- **Audio:** nhạc cụ dây, sáo, percussion nhẹ kết hợp âm fantasy hiện đại; Lăng Phong = hit sắc/trầm, Nguyệt Dao = chuông/gió/âm ngân.
- **Kỹ thuật:** ưu tiên hiệu năng mobile, environment modular, LOD/culling, giới hạn overdraw.

---

## 🛠️ Phạm vi MVP

**Mục tiêu:** Kiểm chứng rằng *bay → đọc obstacle → chuyển đổi Lăng Phong/Nguyệt Dao* tạo thành trải nghiệm vui trong một level 90 giây.

**Bắt buộc:** 2 nhân vật (fly/hit/switch) · 1 environment modular · điều khiển di chuyển + auto-forward · cơ chế switch · 3 obstacle vật lý + 3 obstacle phép · thu thập linh khí · 3 tim & fail state · combo cơ bản · 1 level 60–90s · 1 mini-boss · HUD + results screen.

**Lộ trình:** `M1 Movement Prototype` → `M2 Switch Prototype` → `M3 Vertical Slice` → `M4 Playtest & Iterate`.

**Exit criteria:** ≥ 80% người thử hiểu switch mechanic ngay lần chơi đầu; người chơi tự nhận diện được nguyên nhân thất bại; điều khiển không bị trễ/trượt; người chơi tự nguyện replay để cải thiện sao.

---

## 🚀 Bắt đầu (Getting Started)

### Yêu cầu
- **Unity 6 — `6000.3.10f1`** (cài đúng phiên bản qua Unity Hub để tránh lỗi tương thích).
- Module build cho nền tảng mục tiêu (Android / iOS).
- Git (kèm Git LFS được khuyến nghị cho asset nặng).

### Mở dự án
```bash
git clone <repo-url>
cd PhiKiemSongHanh
```
1. Mở **Unity Hub** → **Add** → trỏ tới thư mục dự án.
2. Mở bằng đúng phiên bản Unity `6000.3.10f1`.
3. Scene khởi đầu: `Assets/Scenes/SampleScene.unity`.

### Cấu trúc thư mục
```
PhiKiemSongHanh/
├── Assets/                # Mã nguồn, scene, asset của game
│   ├── Scenes/            # Các scene Unity
│   └── InputSystem_Actions.inputactions   # Input System (mới)
├── Packages/              # Khai báo package (manifest.json)
├── ProjectSettings/       # Cấu hình dự án Unity
└── README.md
```

> Các thư mục `Library/`, `Temp/`, `Logs/`, `UserSettings/` do Unity sinh ra và đã được `.gitignore` bỏ qua — không cần commit.

---

## 📚 Tài liệu thiết kế (GDD)

Tài liệu thiết kế đầy đủ được duy trì trên Notion, gồm 10 phần: Overview, Gameplay & Controls, Characters, Obstacles/Enemies/Bosses, World & Level Design, UI/UX, Progression & Monetization, Art & Audio, MVP Scope và Decision Log.

➡️ [**Phi Kiếm Song Hành — Game Design Document (Notion)**](https://app.notion.com/p/384985fa7bc4810f86e8de1e219da5aa)

---

## ❓ Quyết định còn để mở

- Engine render cuối cùng (3D stylized / anime / semi-realistic).
- Business model (Premium hay Free-to-play).
- Lăng Phong & Nguyệt Dao là tên tạm hay tên chính thức (sau khi chốt lore).
- Switch tự do hay có cooldown; auto-forward cố định hay biến thiên theo level.
- Boss tự động tấn công hay yêu cầu nút attack riêng.

---

## 👤 Tác giả

**Phạm Huỳnh Tín** — Game Design & Development.

---

*README này được tạo dựa trên GDD phiên bản 0.1 (19/06/2026). Khi thiết kế thay đổi, hãy cập nhật cả tài liệu Notion lẫn file này.*
