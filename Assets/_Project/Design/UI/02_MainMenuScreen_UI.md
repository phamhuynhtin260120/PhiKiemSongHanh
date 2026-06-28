# MainMenuScreen UI

Unity scene: `Assets/Scenes/MainMenuScreen.unity`

## Purpose

Let the player start quickly while exposing Heroes, Level Select, and Settings. This is the first functional hub.

## Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| Background | Stretch | `0, 0` | full | Sky / floating city art |
| CurrencyGroup | Top Left | `96, -64` | `250 x 70` | `UI_CurrencyGroup` |
| SettingsIcon | Top Right | `-88, -88` | `96 x 96` | `button_round_icon_rice.svg` |
| Title | Top Center | `0, -120` | `880 x 150` | TMP text |
| CharacterDuoPreview | Center | `0, 10` | `980 x 420` | 3D render or UI illustration |
| PlayButton | Bottom Center | `0, 280` | `420 x 116` | `button_primary_gold.svg` |
| HeroesButton | Bottom Center | `-230, 155` | `340 x 96` | `button_secondary_rice.svg` |
| LevelsButton | Bottom Center | `230, 155` | `340 x 96` | `button_secondary_rice.svg` |

## Hierarchy

```text
MainMenuCanvas
  SafeArea
    Background
    TopBar
      CurrencyGroup
      SettingsButton
    TitleGroup
      TitleTop
      TitleBottom
    CharacterDuoPreview
    MainActions
      PlayButton
      HeroesButton
      LevelsButton
```

## Button Labels

- `PLAY`
- `HEROES`
- `LEVELS`

## States

- First launch: `PLAY` starts level 1.
- Returning player: `PLAY` starts latest unlocked level.
- `HEROES` opens Character Upgrade panel/scene.
- `LEVELS` opens Level Select.
- Settings can open as modal overlay.

## Animation

- CharacterDuoPreview: slow floating loop, 12-18 px vertical.
- PlayButton: subtle gold glow pulse.
- Menu entry: buttons slide up 40 px and fade in.

