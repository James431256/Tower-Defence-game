# Tower Defence Game

This is the tower defence game I made for my A level Computer Science coursework (2022–2023). It's written in C# using Windows Forms.

The idea is pretty simple: enemies walk towards your main building and you have to place towers to stop them before they get there. If the building runs out of health, you lose.

## How to play

When you start the game you'll need to read the How To Play screen first before it lets you play. After that:

- Pick up coins as they appear and use them to buy towers
- Put towers around the map to shoot the enemies
- Get through all three levels to win, then type in a name (up to 5 letters) to save your score

There are three towers:

- **Basic Tower** (10 coins) shoots in every direction
- **Clicker Tower** (20 coins) shoots wherever you click
- **Mortar** (70 coins) always hits an enemy, but it's expensive

And two types of enemy, a small one with 50 health and a big one with 100. They don't attack your towers, they just go straight for the building, and they speed up the further you get.

## What's in it

- Main menu, How To Play and High Scores screens
- Three levels, each with a countdown timer
- Coins to collect and spend on towers
- A health bar for the building
- High scores saved to a `Player Stats.csv` file

## Running it

You'll need Windows and Visual Studio with the .NET desktop development workload installed (it uses .NET Framework 4.7.2).

1. Clone the repo
2. Open `TowerDefence.sln` in Visual Studio
3. Press F5 to build and run
