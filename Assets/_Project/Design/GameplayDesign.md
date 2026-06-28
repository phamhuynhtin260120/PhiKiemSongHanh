# Phi Kiem Song Hanh - Gameplay Design

## Design Pillars

1. **Doc duoc trong 1 giay:** Obstacle, nhan vat dung, reward va nguy co phai nhin ra ngay tren man hinh mobile.
2. **Chuyen doi la niem vui:** Switch dung thoi diem tao cam giac "da tay" bang slow motion ngan, VFX, SFX va diem combo.
3. **Sai van choi tiep:** Game phat sai lam bang mat combo, mat route thuong hoac mat tim, nhung tranh ket cung va tranh fail bat ngo.
4. **Moi man co mot cau nho:** Level 60-90 giay nen co mo bai, bien tau, cao trao, ket thuc ro rang.
5. **Song hanh la fantasy:** Nguoi choi khong chi doi skin; ho dang dieu khien hai nang luc bo sung nhau.

## Player Fantasy

Nguoi choi la cap kiem khach bay tren phi kiem, doc tinh huong trong toc do cao va lap tuc doi giua **Lang Phong** va **Nguyet Dao** de pha can bang bi nhieu loan trong Thien Van Quoc.

## Core Loop

```text
Bay toi -> Doc vat can -> Chuyen nhan vat -> Xu ly dung -> Thu linh khi
-> Tang combo / nap skill -> Gap bien tau -> Ket man / boss -> Nhan sao
```

## Controls

| Action | Mobile Input | Gameplay Result |
|---|---|---|
| Move | Drag left/right/up/down | Di chuyen trong flight lane gioi han |
| Switch | Tap portrait hoac nut switch | Doi Lang Phong <-> Nguyet Dao |
| Skill | Tap skill button | Dung skill rieng cua nhan vat hien tai |
| Pause | Tap pause icon | Mo pause menu |

## Characters

### Lang Phong - Duong Kiem

- **Role:** Pha vat can vat ly, sat thuong thang, bao ve combo.
- **Readability color:** Cyan/white with gold spark.
- **Gameplay tag:** `Physical`.
- **Basic interaction:** Tu dong chem/phat luc khi di qua obstacle vat ly hop le.
- **Skill:** `Pha Khong Tram` - dash ngan ve phia truoc, pha lien tiep vat can vat ly trong 0.6s.
- **Weakness:** Bi chan boi ket gioi phep va dan linh the.

### Nguyet Dao - Am Kiem

- **Role:** Xu ly ket gioi phep, hut linh khi xa, vuot vung nguy hiem mem.
- **Readability color:** Crimson/white with violet glow.
- **Gameplay tag:** `Spirit`.
- **Basic interaction:** Xuyen/vo hieu hoa obstacle phep hop le khi di qua.
- **Skill:** `Linh Anh Bo` - hoa linh the 0.8s, giam toc dan va hut collectible trong ban kinh lon.
- **Weakness:** Khong pha duoc cua/da/giap vat ly.

## Switch System

### Timing Windows

| Window | Time before interaction | Result |
|---|---:|---|
| Perfect Switch | 0.30s - 0.50s | Slow motion 0.15s, +combo, +score, +energy, strong VFX |
| Good Switch | 0.50s - 1.25s | Xu ly dung, +combo nho |
| Late Switch | 0.00s - 0.30s | Xu ly dung nhung khong thuong timing |
| Wrong Character | On contact | Mat combo hoac mat tim tuy obstacle |

### Song Hanh Meter

- Tang khi thu linh khi, perfect switch, near miss va pha obstacle dung.
- Day meter kich hoat **Song Hanh Mode** trong 4-6 giay.
- Trong Song Hanh Mode:
  - Ca hai tag `Physical` va `Spirit` deu hop le.
  - Hut collectible gan.
  - Lan va cham sai dau tien chi mat Song Hanh, khong mat tim.
  - VFX hai duong kiem trail xoan quanh player.

## Obstacle Taxonomy

| Type | Tag | Correct Character | Fail Result | Example Prefab Direction |
|---|---|---|---|---|
| Cracked Gate | Physical | Lang Phong | Mat 1 tim, slow 0.5s | Cong go nut sang cam |
| Stone Seal | Physical | Lang Phong | Mat combo, day lech lane | Da phong an co vet nut |
| Armored Wisp | Physical | Lang Phong | Mat 1 tim neu cham than | Linh the mac giap |
| Spirit Barrier | Spirit | Nguyet Dao | Mat 1 tim, knockback nhe | Man ket gioi tim/xanh |
| Spell Ring | Spirit | Nguyet Dao | Mat combo, mat route thuong | Vong phap tran xoay |
| Soul Projectile | Spirit | Nguyet Dao | Mat 1 tim | Dan linh khi cham, co telegraph |
| Neutral Gap | Any | Any | Mat tim neu roi/va | Khoang trong, cot da |

## Collectibles

| Item | Purpose | Placement Rule |
|---|---|---|
| Linh Khi | Score + energy | Dat theo duong doc obstacle dung |
| Dong Co | Economy | Dat o route phu, khong bat buoc |
| Manh Luong Nghi Ngoc | Story/progression | 1-3 manh moi chapter hoac boss |
| Khien Linh Luc | Protection | Truoc doan kho, it xuat hien |
| Nam Cham | Comfort reward | Sau perfect chain hoac route bi mat |

## Scoring

- Base score from distance, collectibles, obstacle clears.
- Combo tang khi:
  - Thu linh khi lien tiep.
  - Switch dung nhan vat.
  - Perfect Switch.
  - Near miss trong khoang an toan.
- Combo reset khi mat tim hoac cham obstacle sai nang.
- Star conditions per level:
  - 1 star: Hoan thanh.
  - 2 stars: Dat score/linh khi target.
  - 3 stars: Khong mat tim hoac dat combo target.

## Level Structure

### 90-second MVP Level

| Segment | Duration | Purpose |
|---|---:|---|
| Warm-up | 0-15s | Day move + collectible line |
| Teach Physical | 15-30s | 2 vat can vat ly, portrait Lang Phong nhap nhe |
| Teach Spirit | 30-45s | 2 ket gioi phep, portrait Nguyet Dao nhap nhe |
| Mix | 45-65s | Vat ly/phep xen ke, 1 perfect switch bait |
| Skill Moment | 65-78s | Day obstacle hop cho skill hien tai |
| Mini-boss | 78-90s | 3 weak point doi tag, ket thuc man |

## Difficulty Curve

| Chapter | New Lesson | Difficulty Flavor |
|---|---|---|
| Co Thanh Thien Dang | Switch co ban | Cong/cua/decor ro mau |
| Truc Lam Linh Vu | Gio ngang + route phu | Obstacle lech lane, collectible zigzag |
| Van Son Tu | Vertical movement | Thac nuoc, cot da, projectile cham |
| Hoang Thanh Nhat Thuc | Pattern doc nhanh | Tag gia/doi mau, boss phase |

## MVP Acceptance Criteria

- Nguoi choi hieu vi sao dung/sai trong lan choi dau.
- Switch co feedback trong 100ms sau tap.
- Perfect Switch co cam giac khac Good Switch.
- Level dau co the thang ngay ca khi sai 2 lan.
- 3-star replay co muc tieu ro: score, combo hoac no-hit.
