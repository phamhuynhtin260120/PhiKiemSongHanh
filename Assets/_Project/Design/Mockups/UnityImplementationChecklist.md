# Unity Implementation Checklist

## 1. Main Menu

Scene target: `Assets/Scenes/MainMenuScreen.unity`

Prefabs to create:

- `Assets/_Project/Prefabs/UI/MainMenuCanvas.prefab`
- `TopBar.prefab`
- `PrimaryButton.prefab`
- `SecondaryButton.prefab`

Key RectTransforms at 1920x1080:

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| CurrencyGroup | Top Left | `96, -64` | `250 x 70` |
| SettingsButton | Top Right | `-88, -98` | `84 x 84` |
| LogoTitle | Top Center | `0, -120` | `880 x 150` |
| HeroLayer | Middle Center | `0, 20` | `1100 x 430` |
| PlayButton | Bottom Center | `0, 275` | `360 x 86` |
| HeroesButton | Bottom Center | `0, 185` | `360 x 74` |
| SettingsButtonLarge | Bottom Center | `0, 95` | `360 x 74` |

## 2. Gameplay HUD

Scene target: first playable level.

Prefabs to create:

- `Assets/_Project/Prefabs/UI/GameplayHUDCanvas.prefab`
- `HeartGroup.prefab`
- `CharacterPortraitButton.prefab`
- `RoundActionButton.prefab`
- `SongHanhMeter.prefab`

Key RectTransforms:

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| HeartGroup | Top Left | `78, -54` | `280 x 76` |
| PauseButton | Top Left | `420, -92` | `84 x 84` |
| ScorePanel | Top Center | `0, -52` | `380 x 78` |
| ComboBadge | Top Center | `305, -60` | `170 x 62` |
| PortraitStack | Middle Left | `82, 0` | `118 x 258` |
| SwitchButton | Bottom Right | `-200, 300` | `156 x 156` |
| SkillButton | Bottom Right | `-320, 150` | `140 x 140` |
| SongHanhMeter | Bottom Center | `0, 120` | `560 x 34` |

Notes:

- Gameplay center lane must stay mostly free.
- Put warning arrows/telegraphs in world space, not HUD, when possible.
- HUD should listen to gameplay events instead of polling every frame.

## 3. Character Upgrade

Scene target: menu scene or separate hero scene.

Prefabs to create:

- `CharacterUpgradeCanvas.prefab`
- `StatBar.prefab`
- `HeroTab.prefab`
- `UpgradeButton.prefab`

Key RectTransforms:

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| BackButton | Top Left | `96, -88` | `88 x 88` |
| Title | Top Left | `220, -105` | flexible |
| CurrencyGroup | Top Right | `-110, -54` | `300 x 72` |
| CharacterPreviewPanel | Middle Left | `120, 190` | `760 x 760` |
| RolePanel | Top Right | `-120, -190` | `840 x 150` |
| StatsPanel | Middle Right | `-120, -370` | `840 x 250` |
| SkillPanel | Middle Right | `-120, -650` | `840 x 150` |
| UpgradeButton | Bottom Right | `-570, 154` | `390 x 86` |
| EquipButton | Bottom Right | `-120, 154` | `390 x 86` |

## 4. Level Select

Scene target: menu scene.

Prefabs to create:

- `LevelSelectCanvas.prefab`
- `LevelNode.prefab`
- `BossNode.prefab`
- `LevelInfoPanel.prefab`

Implementation notes:

- Level nodes can be normal UI buttons placed manually for MVP.
- Later, drive them from `LevelDefinition` ScriptableObjects.
- Use locked, unlocked, completed states.

## 5. Results

Scene target: overlay after playable level.

Prefabs to create:

- `ResultsCanvas.prefab`
- `StarGroup.prefab`
- `RewardStatRow.prefab`

Key RectTransforms:

| Element | Anchor | Position | Size |
|---|---|---:|---:|
| ResultPanel | Center | `0, 0` | `1080 x 820` |
| ResultTitle | Top Center | `0, -170` | flexible |
| StarGroup | Top Center | `0, -310` | `520 x 130` |
| StatRows | Center | `0, -40` | `800 x 264` |
| ReplayButton | Bottom Center | `-210, 275` | `380 x 86` |
| NextButton | Bottom Center | `210, 275` | `380 x 86` |

## Recommended Build Order

1. Create shared UI tokens: colors, TMP text styles, button prefabs.
2. Build `GameplayHUDCanvas` first because it affects gameplay readability.
3. Build `ResultsCanvas` second so playtest loop feels complete.
4. Build `MainMenuCanvas`.
5. Build `CharacterUpgradeCanvas`.
6. Build `LevelSelectCanvas`.

