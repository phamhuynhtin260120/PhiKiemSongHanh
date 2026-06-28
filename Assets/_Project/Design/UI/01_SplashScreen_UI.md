# SplashScreen UI

Unity scene: `Assets/Scenes/SplashScreen.unity`

## Purpose

Show logo/title quickly, establish sky fantasy mood, then move to main menu. This screen should last 1.5-2.5 seconds unless the user taps to skip.

## Layout

| Element | Anchor | Position | Size | Notes |
|---|---|---:|---:|---|
| Background | Stretch | `0, 0` | full | Use `Assets/_Project/Art/UI/bg-splash.png` if available |
| CloudOverlay | Bottom Stretch | `0, 0` | full width x 360 | Soft white clouds, low opacity |
| GameTitle | Center | `0, 30` | `900 x 190` | Two-line title: `PHI KIEM` / `SONG HANH` |
| LoadingHint | Bottom Center | `0, 95` | `480 x 48` | Optional: `Tap to continue` |

## Hierarchy

```text
SplashCanvas
  SafeArea
    BackgroundImage
    CloudOverlay
    TitleGroup
      TitleLineTop
      TitleLineBottom
    LoadingHint
```

## Visual Notes

- Title should be large and clean, not overly ornate.
- Use Gold/Jade title accents over Sky background.
- Avoid menu buttons on Splash; keep it calm.

## Animation

- Background fade in: 0.25s.
- Title scale 0.94 -> 1 and alpha 0 -> 1: 0.45s.
- LoadingHint appears after 1.0s.
- Tap or timeout transitions to Main Menu.

