# UI Scene Design Index

Use these files as the source of truth when building UI in Unity.

Recommended order:

1. `00_UI_System.md` - shared colors, Canvas setup, button mapping, common prefabs.
2. `03_GamePlay_UI.md` - most important screen for playability.
3. `05_Results_UI.md` - completes the playable loop.
4. `02_MainMenuScreen_UI.md` - first hub screen.
5. `01_SplashScreen_UI.md` - startup polish.
6. `04_Pause_Settings_UI.md` - pause/settings overlays.
7. `06_CharacterUpgrade_UI.md` - hero upgrade screen.
8. `07_LevelSelect_UI.md` - chapter progression.
9. `08_Onboarding_UI.md` - early tutorial prompts.

Current Unity scenes:

- `Assets/Scenes/SplashScreen.unity`
- `Assets/Scenes/MainMenuScreen.unity`
- `Assets/_Project/Scenes/Levels/GamePlay.unity`

Panel-style screens can initially live inside Main Menu or GamePlay as Canvas prefabs before becoming separate scenes.
