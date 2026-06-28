# Pause and Settings UI

Unity scene: overlay used inside `Assets/_Project/Scenes/Levels/GamePlay.unity` and menu scenes.

## Purpose

Pause should be fast and readable during play. Settings should expose only important mobile options for MVP.

## Pause Modal Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| DimOverlay | Stretch | `0, 0` | full | `#1C2632`, alpha 55% |
| PausePanel | Center | `0, 0` | `680 x 620` | Rice panel |
| Title | Top Center | `0, -250` | `520 x 70` | TMP |
| ResumeButton | Center | `0, -80` | `420 x 108` | `button_primary_gold.svg` |
| RestartButton | Center | `0, 50` | `420 x 96` | `button_secondary_rice.svg` |
| SettingsButton | Center | `0, 165` | `420 x 96` | `button_secondary_rice.svg` |
| QuitButton | Center | `0, 280` | `420 x 96` | `button_danger_crimson.svg` |

## Settings Modal Layout

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| SettingsPanel | Center | `0, 0` | `760 x 640` |
| MusicSlider | Center | `0, -90` | `560 x 54` |
| SfxSlider | Center | `0, -5` | `560 x 54` |
| VibrationToggle | Center | `0, 90` | `560 x 64` |
| QualitySegment | Center | `0, 185` | `560 x 70` |
| CloseButton | Top Right of panel | `-36, 36` | `80 x 80` |

## Hierarchy

```text
PauseCanvas
  DimOverlay
  PausePanel
    Title
    ResumeButton
    RestartButton
    SettingsButton
    QuitButton

SettingsModal
  DimOverlay
  SettingsPanel
    Title
    MusicSlider
    SfxSlider
    VibrationToggle
    QualitySegment
    CloseButton
```

## Button Labels

Pause:

- `RESUME`
- `RESTART`
- `SETTINGS`
- `QUIT`

Settings:

- `MUSIC`
- `SFX`
- `VIBRATION`
- `QUALITY`
