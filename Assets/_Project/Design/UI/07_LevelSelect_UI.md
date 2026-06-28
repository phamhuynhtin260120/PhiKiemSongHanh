# Level Select UI

Unity scene: can be separate later, or a panel opened from `MainMenuScreen`.

## Purpose

Show chapter progression, star completion, locked levels, and quick entry into the next playable level.

## Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| BackButton | Top Left | `96, -88` | `88 x 88` | `button_back.svg` |
| ChapterTitle | Top Left | `220, -105` | flexible | TMP |
| StarTotal | Top Right | `-110, -54` | `300 x 72` | Rice pill |
| ChapterMap | Center | `0, -30` | `1500 x 620` | UI map layer |
| LevelNodes | Center | manual | `116 x 116` each | node prefabs |
| BossNode | Upper Right | manual | `150 x 150` | danger/gold node |
| InfoPanel | Bottom Center | `0, 150` | `1420 x 180` | Rice panel |
| PlayButton | Bottom Right in panel | `-340, 0` | `260 x 96` | `button_primary_gold.svg` |

## Hierarchy

```text
LevelSelectCanvas
  SafeArea
    Header
      BackButton
      ChapterTitle
      StarTotal
    ChapterMap
      PathLine
      LevelNode01
      LevelNode02
      LevelNode03
      LevelNode04
      LevelNode05
      BossNode
    InfoPanel
      LevelName
      GoalList
      PlayButton
```

## Node States

Completed:

- Jade fill.
- Star count visible.

Current:

- Rice fill, Jade outline, subtle pulse.

Locked:

- Ink/gray fill, lock icon, no stars.

Boss:

- Danger/Gold fill, bigger than normal nodes.

## MVP Content

Chapter 1: `Co Thanh Thien Dang`

Level nodes:

- `1-1 First Flight`
- `1-2 Cracked Gate`
- `1-3 Spirit Ring`
- `1-4 Lantern Gate Trial`
- `1-5 Song Hanh Chain`
- `Boss - Stone Lion`

