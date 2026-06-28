# Onboarding UI

Unity scene: overlay inside early `GamePlay` levels.

## Purpose

Teach by pointing and highlighting, not by long text. Prompts should be short and disappear quickly.

## Prompt Types

| Prompt | Trigger | UI |
|---|---|---|
| Move | First level start | ghost drag line near player |
| Switch to Lang Phong | First Physical obstacle | cyan pulse around Lang portrait |
| Switch to Nguyet Dao | First Spirit obstacle | crimson pulse around Nguyet portrait |
| Skill | First skill lane | skill button pulse |
| Perfect Switch | After first correct switch | small `PERFECT` timing hint |

## Layout

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| TutorialPromptBubble | Bottom Center | `0, 235` | `640 x 86` |
| FingerDragGhost | World/Screen near player | dynamic | `180 x 180` |
| HighlightRing | Over target UI element | dynamic | target + 32 px |

## Text

Use only short prompts:

- `DRAG TO MOVE`
- `SWITCH NOW`
- `USE SKILL`
- `PERFECT TIMING`

## Behavior

- Prompt pauses or slows game only the first time.
- Prompt auto-dismisses when player performs action.
- If player ignores prompt for 2s, pulse target again.
- Do not show more than one prompt at a time.

