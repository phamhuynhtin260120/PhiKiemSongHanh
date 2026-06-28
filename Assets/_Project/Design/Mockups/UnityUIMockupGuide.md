# Phi Kiem Song Hanh - Unity UI Mockup Guide

Reference resolution: **1920 x 1080**, landscape mobile.

Unity Canvas setup:

- Canvas Scaler: `Scale With Screen Size`
- Reference Resolution: `1920 x 1080`
- Screen Match Mode: `Match Width Or Height`
- Match: `0.5`
- Safe Area: keep important controls inside ~`80px` from left/right and ~`60px` from top/bottom.
- Recommended font: use current project TMP font first, then replace with a Vietnamese-capable display/body pair later.

## Color Tokens

| Token | Hex | Use |
|---|---|---|
| Sky Deep | `#4B93C8` | Background sky gradient top |
| Sky Pale | `#D9F3FF` | Background sky gradient bottom |
| Jade | `#49C7A3` | Linh Khi, progress, positive state |
| Gold | `#F4C95D` | Stars, primary CTA, rewards |
| Ink | `#1C2632` | Main dark text / dark panels |
| Rice | `#FFF7E5` | Light panel fill |
| Cyan | `#41D9FF` | Lang Phong / Physical |
| Crimson | `#E94F72` | Nguyet Dao / Spirit |
| Violet | `#8D6CFF` | Spirit accent |
| Danger | `#F05A45` | Damage, warning |

## Shared UI Rules

- Buttons should be at least `170 x 64` for touch.
- Primary gameplay buttons should be at least `118 x 118`.
- Keep icon shape stronger than text where possible.
- Gameplay HUD must never cover the flight lane center.
- Use color + icon + shape for gameplay tags, not color alone.
- Main CTA uses Gold, gameplay states use Cyan/Crimson.

## Mockup Files

- `01_Splash_MainMenu.svg`
- `02_GameplayHUD.svg`
- `03_CharacterUpgrade.svg`
- `04_LevelSelect.svg`
- `05_Results.svg`

Each SVG uses a 1920x1080 viewBox, so values map directly to Unity reference pixels.

## Suggested Unity Hierarchy

### MainMenuCanvas

```text
MainMenuCanvas
  SafeArea
    TopBar
      CurrencyGroup
      SettingsButton
    HeroLayer
      LogoTitle
      CharacterDuo
    MainActions
      PlayButton
      HeroesButton
      SettingsButton
```

### GameplayCanvas

```text
GameplayCanvas
  SafeArea
    TopLeftStatus
      HeartGroup
      PauseButton
    TopCenterScore
      ScoreText
      ComboBadge
    LeftCharacterPanel
      LangPhongPortrait
      NguyetDaoPortrait
    BottomCenterMeter
      SongHanhMeter
    RightActions
      SwitchButton
      SkillButton
```

### CharacterCanvas

```text
CharacterCanvas
  SafeArea
    Header
      BackButton
      Title
      CurrencyGroup
    CharacterPreview
    CharacterTabs
    StatsPanel
    SkillPanel
    UpgradeButton
    EquipButton
```

### LevelSelectCanvas

```text
LevelSelectCanvas
  SafeArea
    Header
      BackButton
      ChapterTitle
      StarTotal
    ChapterMap
      LevelNodes
      BossNode
    BottomInfoPanel
      LevelName
      StarGoals
      PlayButton
```

### ResultsCanvas

```text
ResultsCanvas
  SafeArea
    ResultTitle
    StarGroup
    RewardStats
    ProgressRewards
    ReplayButton
    NextButton
```

