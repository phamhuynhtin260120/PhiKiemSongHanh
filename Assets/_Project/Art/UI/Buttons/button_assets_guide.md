# Button Asset Guide

These are Unity-ready SVG button sprites for `Phi Kiem Song Hanh`.

Unity can import them because the project already includes `com.unity.vectorgraphics`.

## Files

| File | Suggested Use | Base Size |
|---|---|---:|
| `button_primary_gold.svg` | Play, Next, Upgrade, Confirm | `512 x 160` |
| `button_secondary_rice.svg` | Heroes, Settings, Replay, Cancel | `512 x 160` |
| `button_disabled_ink.svg` | Locked/disabled button | `512 x 160` |
| `button_danger_crimson.svg` | Quit, Delete, Defeat action | `512 x 160` |
| `button_round_icon_gold.svg` | Main circular CTA icon button | `192 x 192` |
| `button_round_icon_rice.svg` | Secondary icon button | `192 x 192` |
| `button_switch_dual.svg` | Gameplay switch button | `256 x 256` |
| `button_skill_slash.svg` | Lang Phong skill button | `256 x 256` |
| `button_skill_spirit.svg` | Nguyet Dao skill button | `256 x 256` |
| `button_pause.svg` | Pause button | `160 x 160` |
| `button_back.svg` | Back button | `160 x 160` |
| `portrait_frame_cyan.svg` | Lang Phong portrait frame | `192 x 192` |
| `portrait_frame_crimson.svg` | Nguyet Dao portrait frame | `192 x 192` |

## Unity Setup

For each imported SVG:

- Texture Type / SVG Type: use as UI sprite.
- Preserve Aspect: enabled for icon buttons.
- RectTransform size should match the base size or scale proportionally.
- Put TMP text above rectangular button backgrounds rather than baking text into the image.

Recommended text colors:

- Gold button: `#1C2632`
- Rice button: `#1C2632`
- Crimson button: `#FFFFFF`
- Disabled button: `#C8D7D9`

## Notes

- These are intentionally textless so one image can serve many buttons.
- Use rectangular buttons for menu commands and circular buttons for gameplay actions.
- For pressed state, tint image to `#E8EEF0` at 90% or scale RectTransform to `0.96` briefly.
- For selected/active state, add an outer glow Image behind the button using Cyan or Crimson.
