# Tower Defence Game

A 2D tower defence game I made in C# with Windows Forms for my college Computer Science coursework (2022–2023).

Enemies run towards your main building. Place towers to stop them before they reach it. If your building loses all its health, you lose.

## How to play

1. Start the game from the main menu. Read **How To Play** first, because the game asks you to before it lets you start.
2. Collect coins as they appear and spend them on towers.
3. Place towers around the map to shoot enemies before they reach the building.
4. Survive all three levels to win, then enter a name (up to 5 characters) to save your score.

### Towers

| Tower | Cost | What it does |
| --- | --- | --- |
| Basic Tower | 10 | Shoots a bullet in every direction |
| Clicker Tower | 20 | Shoots a bullet wherever you click |
| Mortar | 70 | Fires a shot that always hits an enemy |

### Enemies

- **Small enemy**: weaker (50 health)
- **Big enemy**: tougher (100 health)

Enemies ignore your towers and head straight for the building. They get faster as the game goes on.

## Features

- Main menu, How To Play screen and High Scores screen
- Three levels with a countdown timer
- Coin pickups to buy towers
- Health bar for the main building
- High scores saved to a local `Player Stats.csv` file

## Running it

Requirements: Windows, and Visual Studio with the .NET desktop development workload (.NET Framework 4.7.2).

1. Clone the repo.
2. Open `TowerDefence.sln` in Visual Studio.
3. Press **F5** to build and run.

## Built with

- C#
- Windows Forms (.NET Framework 4.7.2)
