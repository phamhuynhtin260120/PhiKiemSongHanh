# Phi Kiem Song Hanh - MVP Backlog

## Goal

Tao vertical slice 60-90 giay chung minh core mechanic:

**Bay -> doc obstacle -> switch Lang Phong/Nguyet Dao -> duoc thuong neu dung thoi diem.**

## Milestone 1 - Movement Prototype

**Outcome:** Player bay tien ve truoc, drag de di chuyen, camera theo on dinh.

Tasks:

- Tao `PlayerFlightController` trong `Assets/_Project/Scripts/Movement`.
- Tao flight bounds theo truc X/Y va auto-forward theo truc Z.
- Gan Input System hoac fallback touch/mouse drag cho prototype.
- Tao prefab player tam voi model hien co.
- Tao test scene trong `Assets/_Project/Scenes/Levels`.

Done when:

- Player di chuyen muot tren mobile landscape simulator.
- Khong vuot khoi bounds.
- Camera giu nhan vat va lane gameplay de doc.

## Milestone 2 - Switch Prototype

**Outcome:** Hai mode player co tag gameplay rieng va UI switch co feedback.

Tasks:

- Tao enum `CharacterForm`: `LangPhong`, `NguyetDao`.
- Tao `CharacterSwitchController` trong `Assets/_Project/Scripts/Characters`.
- Tao event khi switch de HUD/VFX/SFX lang nghe.
- Tao state visual tam: doi material color/trail/mesh active.
- Tao HUD portrait switch trong `Assets/_Project/Prefabs/UI`.

Done when:

- Tap nut switch doi form trong duoi 100ms.
- Active form doc duoc tren man hinh.
- Switch co cooldown neu can, mac dinh 0.15-0.25s de tranh spam loi input.

## Milestone 3 - Obstacles and Feedback

**Outcome:** Obstacle nhan biet dung/sai nhan vat, co fail va reward.

Tasks:

- Tao enum `ObstacleAffinity`: `Physical`, `Spirit`, `Neutral`.
- Tao `ObstacleDefinition` ScriptableObject trong `Assets/_Project/ScriptableObjects/Obstacles`.
- Tao `ObstacleInteraction` MonoBehaviour trong `Assets/_Project/Scripts/Obstacles`.
- Tao 6 obstacle prototype: 3 Physical, 3 Spirit.
- Tao damage, combo reset, invincibility frame.
- Tao VFX/SFX placeholder cho clear/damage.

Done when:

- Lang Phong xu ly Physical, sai voi Spirit.
- Nguyet Dao xu ly Spirit, sai voi Physical.
- Va cham sai khong gay fail kho hieu; co blink, knockback/slow va invincible window.

## Milestone 4 - Perfect Switch and Scoring

**Outcome:** Timing window tao skill expression va replay value.

Tasks:

- Tao trigger warning zone truoc obstacle.
- Track time tu switch gan nhat den contact.
- Tao result `Perfect`, `Good`, `Late`, `Wrong`.
- Tao `ComboScorer` trong `Assets/_Project/Scripts/Scoring`.
- Tao meter Song Hanh ban dau.
- Tao HUD score/combo/meter.

Done when:

- Perfect Switch thay khac Good Switch bang slow motion/VFX/score.
- Combo tang/rot ro rang.
- Meter day co reward tam thoi.

## Milestone 5 - First Level

**Outcome:** 1 level 60-90 giay co nhịp day hoc, luyen tap, cao trao.

Tasks:

- Tao `LevelSegmentDefinition` ScriptableObject cho spawn pattern.
- Tao level path hoac timeline spawn don gian.
- Dat collectibles theo route dung.
- Tao mini-boss 3 weak point doi tag.
- Tao result screen voi 3 sao.

Done when:

- Level co the hoan thanh trong 60-90 giay.
- Nguoi moi co the thang du sai 1-2 lan.
- 3-star yeu cau replay tot hon.

## Milestone 6 - Polish Pass

**Outcome:** Vertical slice du de playtest.

Tasks:

- Replace placeholder with selected character/environment assets.
- Add camera shake nhe, hit stop ngan, animation triggers.
- Balance speed, spacing, bounds va warning distance.
- Add onboarding prompts bang highlight/icon, khong dung text dai.
- Build Android test hoac Unity playtest recording.

Done when:

- 80% playtester hieu switch mechanic trong lan dau.
- Feedback sai/dung ro rang.
- FPS on dinh tren target test device.

## Suggested ScriptableObject Data

### CharacterDefinition

- Display name
- Form enum
- Gameplay affinity
- Portrait
- Model prefab
- Trail/VFX references
- Skill definition
- SFX references

### ObstacleDefinition

- Display name
- Affinity
- Damage on wrong
- Score on clear
- Energy gain
- Perfect switch bonus
- Telegraph distance
- Clear VFX/SFX
- Hit VFX/SFX

### LevelDefinition

- Display name
- Chapter
- Duration target
- Forward speed curve
- Star thresholds
- Segment list
- Boss reference

## First Playtest Questions

- Nguoi choi co nhan ra minh can doi nhan vat truoc khi cham obstacle khong?
- Mau/tag nao dang gay nham lan?
- Perfect Switch co du "da" de muon lap lai khong?
- Speed co lam doc obstacle bi stress qua som khong?
- Loi that bai co du cong bang khong?

## Implementation Priority

1. Movement.
2. Switch state.
3. Obstacle compatibility.
4. Damage/health.
5. Combo/score.
6. Perfect Switch.
7. First level.
8. Result screen.
9. Art pass.
10. Playtest balance.
