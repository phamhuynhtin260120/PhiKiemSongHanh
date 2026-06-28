# Phi Kiem Song Hanh - UI System

Reference resolution: **1920 x 1080 landscape**.

Canvas setup:

- `Canvas Scaler`: Scale With Screen Size
- `Reference Resolution`: 1920 x 1080
- `Match`: 0.5
- Important touch targets stay inside safe area: left/right 80 px, top/bottom 60 px.

## Visual Direction

UI should feel like a light fantasy adventure game, not a dense RPG inventory. Use parchment/rice panels for menus, gold for main actions, cyan for Lang Phong/Physical, crimson-violet for Nguyet Dao/Spirit.

## Color Tokens

| Token | Hex | Use |
|---|---|---|
| Ink | `#1C2632` | Main text, dark overlays |
| Rice | `#FFF7E5` | Menu panel fill |
| Gold | `#F4C95D` | Primary CTA, stars |
| Jade | `#49C7A3` | Progress, Linh Khi, success |
| Cyan | `#41D9FF` | Lang Phong, Physical |
| Crimson | `#E94F72` | Nguyet Dao |
| Violet | `#8D6CFF` | Spirit/magic accent |
| Danger | `#F05A45` | Damage, quit, warning |
| Sky | `#D9F3FF` | Light background |

## Button Asset Mapping

| UI Purpose | Asset |
|---|---|
| Primary CTA | `Assets/_Project/Art/UI/Buttons/button_primary_gold.svg` |
| Secondary command | `Assets/_Project/Art/UI/Buttons/button_secondary_rice.svg` |
| Disabled/locked | `Assets/_Project/Art/UI/Buttons/button_disabled_ink.svg` |
| Dangerous action | `Assets/_Project/Art/UI/Buttons/button_danger_crimson.svg` |
| Pause | `Assets/_Project/Art/UI/Buttons/button_pause.svg` |
| Back | `Assets/_Project/Art/UI/Buttons/button_back.svg` |
| Switch | `Assets/_Project/Art/UI/Buttons/button_switch_dual.svg` |
| Lang Phong skill | `Assets/_Project/Art/UI/Buttons/button_skill_slash.svg` |
| Nguyet Dao skill | `Assets/_Project/Art/UI/Buttons/button_skill_spirit.svg` |
| Lang Phong portrait frame | `Assets/_Project/Art/UI/Buttons/portrait_frame_cyan.svg` |
| Nguyet Dao portrait frame | `Assets/_Project/Art/UI/Buttons/portrait_frame_crimson.svg` |

## Text Rules

- Do not bake text into button images.
- Use TextMeshPro text on top of button sprites.
- Button labels: 32-42 px depending on button size.
- Gameplay text: short, numeric, icon-led.
- Vietnamese display names are allowed in UI, but file names should stay ASCII.

## Shared Prefabs To Build

```text
Assets/_Project/Prefabs/UI/Common/
  UI_Button_Primary.prefab
  UI_Button_Secondary.prefab
  UI_Button_Danger.prefab
  UI_Button_Back.prefab
  UI_Button_Pause.prefab
  UI_Panel_Rice.prefab
  UI_StatRow.prefab
  UI_CurrencyGroup.prefab
  UI_StarGroup.prefab
```

## Motion Rules

- Button press: scale to 0.96 for 0.08s, then return.
- Panel open: fade 0 -> 1 and scale 0.96 -> 1 over 0.18s.
- Primary CTA idle: very subtle glow pulse every 2s.
- Gameplay warning: use world-space telegraph before HUD text.

