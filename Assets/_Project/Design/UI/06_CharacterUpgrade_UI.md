# Character Upgrade UI

Unity scene: can be a separate scene later, or a panel opened from `MainMenuScreen`.

## Purpose

Let the player understand the two heroes, equip one as active display, and upgrade stats/skills.

## Layout

| Element | Anchor | Position | Size | Asset |
|---|---|---:|---:|---|
| BackButton | Top Left | `96, -88` | `88 x 88` | `button_back.svg` |
| Title | Top Left | `220, -105` | flexible | TMP |
| CurrencyGroup | Top Right | `-110, -54` | `300 x 72` | currency prefab |
| CharacterPreview | Middle Left | `120, 190` | `760 x 760` | 3D preview or portrait |
| CharacterTabs | Left Bottom | `240, 820` | `520 x 120` | portrait frames |
| RolePanel | Top Right | `-120, -190` | `840 x 150` | Rice panel |
| StatsPanel | Middle Right | `-120, -370` | `840 x 250` | Rice panel |
| SkillPanel | Middle Right | `-120, -650` | `840 x 150` | Rice panel |
| UpgradeButton | Bottom Right | `-570, 154` | `390 x 96` | `button_primary_gold.svg` |
| EquipButton | Bottom Right | `-120, 154` | `390 x 96` | `button_secondary_rice.svg` |

## Hierarchy

```text
CharacterUpgradeCanvas
  SafeArea
    Header
      BackButton
      Title
      CurrencyGroup
    CharacterPreview
    CharacterTabs
      LangPhongTab
      NguyetDaoTab
    InfoColumn
      RolePanel
      StatsPanel
      SkillPanel
      UpgradeButton
      EquipButton
```

## Character States

Lang Phong selected:

- Cyan accents.
- Skill icon: `button_skill_slash.svg`
- Role: `Physical Sword`

Nguyet Dao selected:

- Crimson/Violet accents.
- Skill icon: `button_skill_spirit.svg`
- Role: `Spirit Sword`

## Stat Rows

MVP stats:

- `Power`
- `Energy`
- `Cooldown`

Do not add too many RPG stats yet. This screen should stay casual.

