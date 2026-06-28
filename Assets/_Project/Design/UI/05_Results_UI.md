# Results UI

Unity scene: overlay shown after `Assets/_Project/Scenes/Levels/GamePlay.unity`

## Purpose

Celebrate completion, show why the player earned stars, and push either replay or next level.

## Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| DimOverlay | Stretch | `0, 0` | full | dark alpha 35% |
| ResultPanel | Center | `0, 0` | `1080 x 820` | Rice panel |
| Title | Top Center | `0, -170` | `700 x 80` | TMP |
| StarGroup | Top Center | `0, -310` | `560 x 130` | star sprites |
| ScoreRow | Center | `0, -40` | `800 x 74` | stat row |
| LinhKhiRow | Center | `0, 55` | `800 x 74` | stat row |
| ComboRow | Center | `0, 150` | `800 x 74` | stat row |
| ReplayButton | Bottom Center | `-220, 275` | `380 x 96` | `button_secondary_rice.svg` |
| NextButton | Bottom Center | `220, 275` | `380 x 96` | `button_primary_gold.svg` |

## Hierarchy

```text
ResultsCanvas
  DimOverlay
  ResultPanel
    Title
    StarGroup
      Star01
      Star02
      Star03
    StatRows
      ScoreRow
      LinhKhiRow
      ComboRow
    Actions
      ReplayButton
      NextButton
```

## States

Victory:

- Title: `VICTORY`
- Stars animate one by one.
- Next button active.

Defeat:

- Title: `DEFEAT`
- StarGroup hidden or dim.
- Primary button becomes `RETRY`.
- Secondary button: `MENU`.

## Animation

- ResultPanel pops in after 0.25s.
- Stars appear with 0.18s spacing.
- Reward numbers count up over 0.5s.
