# GamePlay UI

Unity scene: `Assets/_Project/Scenes/Levels/GamePlay.unity`

## Purpose

Support moment-to-moment play without covering the flight lane. The player must always know health, score, combo, active character, switch, skill, and Song Hanh meter.

## Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| HeartGroup | Top Left | `80, -58` | `280 x 72` | heart icons |
| PauseButton | Top Left | `420, -92` | `88 x 88` | `button_pause.svg` |
| ScorePanel | Top Center | `0, -54` | `390 x 78` | rice mini panel |
| ComboBadge | Top Center | `310, -62` | `170 x 64` | Jade badge |
| PortraitStack | Middle Left | `90, 0` | `132 x 286` | portrait frames |
| SongHanhMeter | Bottom Center | `0, 118` | `600 x 38` | custom fill |
| SwitchButton | Bottom Right | `-200, 300` | `156 x 156` | `button_switch_dual.svg` |
| SkillButton | Bottom Right | `-320, 150` | `146 x 146` | skill icon by active character |

## Hierarchy

```text
GameplayCanvas
  SafeArea
    TopLeftStatus
      HeartGroup
      PauseButton
    TopCenterStatus
      ScorePanel
      ComboBadge
    CharacterStatus
      LangPhongPortrait
      NguyetDaoPortrait
    BottomCenter
      SongHanhLabel
      SongHanhMeter
    RightActions
      SwitchButton
      SkillButton
    FeedbackLayer
      PerfectSwitchText
      DamageVignette
      TutorialPrompt
```

## Active Character Feedback

Lang Phong active:

- Cyan ring around portrait.
- Skill button uses `button_skill_slash.svg`.
- Song Hanh meter fill can lean Cyan/Jade.

Nguyet Dao active:

- Crimson/Violet ring around portrait.
- Skill button uses `button_skill_spirit.svg`.
- Spirit interactions glow Crimson/Violet.

## Feedback Text

Keep gameplay text short:

- `PERFECT`
- `COMBO x20`
- `SONG HANH`

Text appears near center-top of the player but not over obstacles.

## Animation

- Switch button press: rotate icon 90 degrees over 0.12s.
- Portrait active ring pulse once on switch.
- Perfect Switch: HUD briefly slows, text scale 0.8 -> 1.08 -> 1.
- Damage: red vignette 0.25s, hearts shake.
