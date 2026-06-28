# Phi Kiem Song Hanh - Art and Content Bible

## Creative Direction

**Tone:** Dong A huyen huyen, sang, bay bong, de doc gameplay. The gioi la hu cau nen tranh mo phong lich su/cu dan toc cu the qua sat.

**Visual promise:** Hai vet kiem sang cat qua may, den long, nui noi va phap tran. Moi thu dep nhung khong lam mat dau hieu gameplay.

## Art Pillars

1. **Gameplay first:** Mau obstacle phai co nghia truoc khi dep.
2. **Airborne elegance:** Nhieu duong cong, trail, lua chon camera rong de thay cam giac bay.
3. **Clear silhouettes:** Vat can vat ly co dang nang, vuong, nut vo; vat can phep co dang tron, mong, phat sang.
4. **Soft fantasy light:** Nen sang, may, suong, anh vang/lam nhe; tranh qua toi trong level gameplay.
5. **Mobile performance:** It material hon, modular environment, VFX ngan va co gioi han particle.

## Color Language

| Meaning | Color Direction | Usage |
|---|---|---|
| Lang Phong / Physical | Cyan, white, gold accent | Player trail, physical success, sword slash |
| Nguyet Dao / Spirit | Crimson, white, violet accent | Spirit phase, barriers, magic success |
| Danger | Warm orange/red with hard edge | Heavy damage, boss attack telegraph |
| Reward | Jade green/gold | Linh khi, coins, completion |
| Neutral world | Pale sky, ink stone, moss green | Environment background |

## Existing Asset Fit

Project da co:

- `Cartoon Characters_Japanese style18/19`: dung cho player, enemy va boss prototype.
- `Chinese Painting URP`: dung lam environment modular cho chapter 1-3.
- `SoftTouch_UI`: dung nhanh cho menu/result trong MVP, nhung can reskin mau va icon de hop identity game.

Khuyen nghi map asset:

| Need | Existing Asset Candidate | Note |
|---|---|---|
| Lang Phong | Tengu hoac human-like character co animation fly/run | Can trail kiem cyan de khac vai tro |
| Nguyet Dao | Aosaginohi hoac character co silhouette thanh/manh | Can glow crimson/violet |
| Mini-boss chapter 1 | Red Monster / Altar of Penance / stone-like model | Gan weak point tag vat ly/phep |
| Chapter 1 set dressing | Bridge, lantern-like props, stage/rock from Chinese Painting | Tao duong bay ro, it clutter |
| Collectible | Coin/gem sprites tu SoftTouch hoac model orb don gian | Doi thanh linh khi jade/gold |

## Character Content

### Lang Phong

- **Archetype:** Kiem khach tre, nhanh, thang than, tin vao hanh dong.
- **Personality:** Tu tin, bao ve nguoi khac, hay lao toi truoc.
- **Combat read:** Slash manh, am thanh sac va tram.
- **Short barks:**
  - "Mo duong!"
  - "De ta pha!"
  - "Dung luc!"

### Nguyet Dao

- **Archetype:** Phap kiem su binh tinh, doc linh mach va phong an.
- **Personality:** Tram, thong minh, cham ma chinh xac.
- **Combat read:** Phase, bell shimmer, spirit ripple.
- **Short barks:**
  - "Theo mach linh khi."
  - "Ket gioi mo roi."
  - "Dung khoanh khac."

## World Content

### Chapter 1 - Co Thanh Thien Dang

- **Mood:** Am ap, de tiep can, den long va cong go tren may.
- **Gameplay lesson:** Switch co ban Physical/Spirit.
- **Obstacles:** Cong go nut, da phong an, man ket gioi, phap tran.
- **Boss:** Su Tu Da giu cong thanh.
- **Story beat:** Hai nhan vat tim duoc manh ngoc dau tien trong den co.

### Chapter 2 - Truc Lam Linh Vu

- **Mood:** Suong xanh, gio ngang, am thanh la tre.
- **Gameplay lesson:** Lane shifting, route phu, near miss.
- **Obstacles:** Than tre roi, ao anh suong, linh the bay.
- **Boss:** Ho Ly Linh tao illusion.
- **Story beat:** Nguyet Dao nhan ra ngoc bi nhieu hon la bi vo tinh.

### Chapter 3 - Van Son Tu

- **Mood:** Nui noi, thac nuoc, chua cao.
- **Gameplay lesson:** Vertical movement va projectile cham.
- **Obstacles:** Cot da, thac linh khi, cau gay, phap dan.
- **Boss:** Van Long.
- **Story beat:** Lang Phong gap thu thach ve su nong voi.

### Chapter 4 - Hoang Thanh Nhat Thuc

- **Mood:** Trang nghiem, eclipse, vang toi va tim den.
- **Gameplay lesson:** Pattern nhanh, boss phase, Song Hanh mastery.
- **Obstacles:** Tag doi mau, cua hai lop, projectile nhieu nhịp.
- **Boss:** Nguoi Canh Giu Luong Nghi Ngoc.
- **Story beat:** Can bang khong phai xoa bo bong toi ma la song hanh voi no.

## UI Direction

- HUD landscape: tim trai tren, score/combo gan giua tren, meter Song Hanh duoi nhan vat hoac tren skill cluster.
- Portrait switch: hai portrait lon vua du cham, co ring mau va cooldown/active state ro.
- Skill button: dat ben phai, icon kiem dash / spirit phase.
- Results: 3 sao, score, linh khi, combo max, nut replay/next.
- Avoid text tutorial dai; dung highlight, ghost path va icon tag.

## VFX Language

| Event | VFX |
|---|---|
| Switch | Flash ring quanh player, trail doi mau, 2 frame smear |
| Perfect Switch | Short time warp, radial line, sparkle theo tag dung |
| Physical clear | Crack burst, splinter/stone particle it, hit stop 0.04s |
| Spirit clear | Ripple dissolve, glyph fade, bell shimmer |
| Damage | Red edge blink, character flinch, invincible shimmer |
| Song Hanh | Dual spiral trails, soft aura, collectible magnet streak |

## Audio Direction

- **Music:** Dan day + sao + percussion nhe + pad fantasy hien dai.
- **Lang Phong SFX:** Sword whoosh, low impact, wood/stone break.
- **Nguyet Dao SFX:** Bell, wind chime, airy reverse, magic ripple.
- **UI:** Soft tap, star chime, meter fill pulse.
- **Mix rule:** Gameplay warning and switch feedback uu tien hon music.

## Content Naming

Use Vietnamese display names, ASCII file names.

Examples:

| Display | File-friendly |
|---|---|
| Lang Phong | LangPhong |
| Nguyet Dao | NguyetDao |
| Pha Khong Tram | PhaKhongTram |
| Linh Anh Bo | LinhAnhBo |
| Co Thanh Thien Dang | CoThanhThienDang |
| Linh Khi | LinhKhi |
