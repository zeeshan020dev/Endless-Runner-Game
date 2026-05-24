<div align="center">

# Endless Runner Game

3D endless runner built in Unity with lane switching, jump and slide mechanics, coin collection, and endless tile spawning.

<p>
  <img alt="Unity" src="https://img.shields.io/badge/Unity-6.4.5f1-000000?logo=unity" />
  <img alt="C#" src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp" />
  <img alt="Platform" src="https://img.shields.io/badge/Platform-PC%20%7C%20WebGL-2ea44f" />
  <img alt="URP" src="https://img.shields.io/badge/Render%20Pipeline-URP-8b5cf6" />
  <img alt="Input System" src="https://img.shields.io/badge/Input%20System-Enabled-0ea5e9" />
  <img alt="Open Source" src="https://img.shields.io/badge/GitHub-Open%20Source-181717?logo=github" />
</p>

</div>

> A polished 3D endless runner built in Unity with lane switching, jump and slide mechanics, coin collection, and endless tile spawning.

---

## Table of Contents

- [Overview](#overview)
- [Repository Highlights](#repository-highlights)
- [Feature Cards](#feature-cards)
- [Features](#features)
- [Gameplay Mechanics](#gameplay-mechanics)
- [Technologies Used](#technologies-used)
- [Unity Version Compatibility](#unity-version-compatibility)
- [Folder Structure](#folder-structure)
- [Scripts and Modules](#scripts-and-modules)
- [Installation and Setup](#installation-and-setup)
- [How to Play](#how-to-play)
- [Gameplay GIF](#gameplay-gif)
- [Screenshots](#screenshots)
- [Future Improvements](#future-improvements)
- [Contribution Guidelines](#contribution-guidelines)
- [License](#license)
- [Author](#author)

## Overview

**Endless Runner Game** is a 3D endless runner built in Unity where the player survives by switching lanes, jumping, and sliding to avoid obstacles while collecting coins. The game features a continuously spawning track, accelerating forward movement, audio feedback, and a simple menu-driven flow that is well suited for a clean portfolio presentation.

The repository is structured as a lightweight Unity project with clear separation between gameplay scripts, assets, scenes, and project configuration. Core mechanics are handled through a small set of focused scripts, making the project easy to understand, extend, and showcase.

## Repository Highlights ✨

| Highlight | Details |
| --- | --- |
| Gameplay loop | Endless runner with auto-movement, lane swapping, jumping, sliding, and coin pickup |
| Code structure | Small set of focused scripts with clear responsibilities |
| UX flow | Start menu, in-game HUD, and game over panel |
| Audio | Persistent audio manager with music and sound effects |
| Build readiness | Configured for desktop and WebGL-friendly development |

## Feature Cards 🚀

<table>
	<tr>
		<td width="33%">
			<h3 align="center">🏃 Endless Run</h3>
			<p align="center">Automatic forward movement with increasing speed keeps the run tense and fast-paced.</p>
		</td>
		<td width="33%">
			<h3 align="center">🛣️ Lane Control</h3>
			<p align="center">Shift left, center, and right to dodge obstacles and stay alive longer.</p>
		</td>
		<td width="33%">
			<h3 align="center">🪙 Coin Collection</h3>
			<p align="center">Collect pickups to increase your score and reinforce risk-reward routing.</p>
		</td>
	</tr>
	<tr>
		<td width="33%">
			<h3 align="center">🦘 Jump & Slide</h3>
			<p align="center">Use jump and slide mechanics to clear barriers and low obstacles.</p>
		</td>
		<td width="33%">
			<h3 align="center">🧱 Endless Tiles</h3>
			<p align="center">Tiles spawn and recycle dynamically so the level feels infinite.</p>
		</td>
		<td width="33%">
			<h3 align="center">🔊 Audio Feedback</h3>
			<p align="center">Persistent music and effects improve pacing, clarity, and impact.</p>
		</td>
	</tr>
</table>

## Features

- 3D endless runner gameplay with automatic forward motion
- Lane-based movement across three tracks
- Jump and slide mechanics for obstacle avoidance
- Coin collection with live UI counter
- Game over detection on obstacle collision
- Endless tile spawning and cleanup system
- Main menu with Play and Quit actions
- Persistent audio manager with background music and sound effects
- UI built with TextMeshPro

## Gameplay Mechanics 🎮

| Mechanic | Description |
| --- | --- |
| Auto-run movement | The player moves forward automatically and gradually accelerates until reaching the speed cap. |
| Lane switching | Left and right arrow keys move the player between three lanes. |
| Jumping | Up Arrow or Space triggers a jump when the character is grounded. |
| Sliding | Down Arrow starts a timed slide animation and shrinks the collider to pass under obstacles. |
| Coin collection | Triggering a coin increases the coin counter and plays a pickup sound. |
| Obstacle collision | Hitting an obstacle ends the run, pauses time, and shows the game over panel. |
| Endless track | New tiles spawn ahead of the player while older tiles are removed behind the camera. |

## Technologies Used 🛠️

| Category | Stack |
| --- | --- |
| Engine | Unity 6.4.5f1 (6000.4.5f1) |
| Render Pipeline | Universal Render Pipeline (URP) |
| Scripting Language | C# |
| Input | Unity Input System and keyboard input |
| UI | TextMeshPro, Unity UI |
| Audio | Unity AudioSource-based manager |
| Scene Management | Unity SceneManager |
| Build Targets | PC and WebGL-friendly setup |

## Unity Version Compatibility 🧩

This project was created and validated with:

- **Unity Editor:** 6000.4.5f1
- **Unity Stream:** Unity 6

Recommended compatibility range:

- **Best match:** Unity 6.4.x
- **Likely compatible:** Other Unity 6 LTS / 6000.x builds with the same packages installed

## Folder Structure 📁

| Folder | Purpose |
| --- | --- |
| `Assets/Animations` | Animation assets used by the player and related gameplay objects |
| `Assets/GUI` | UI assets, menus, panels, and interface elements |
| `Assets/Material` | Materials used by the environment and characters |
| `Assets/Model` | Imported 3D models and meshes |
| `Assets/Prefabs` | Reusable prefabs for tiles, obstacles, coins, and gameplay objects |
| `Assets/Scenes` | Unity scenes such as the menu and gameplay level |
| `Assets/Scripts` | Core gameplay, audio, menu, and support scripts |
| `Assets/Settings` | Unity project and rendering settings assets |
| `Assets/Shaders` | Custom shaders or shader-related assets |
| `Assets/Sounds` | Music and sound effect clips |
| `Assets/TextMesh Pro` | TextMeshPro resources and presets |
| `Assets/Textures` | Texture files used by environment and assets |
| `Packages/` | Package manifest and dependency lock files |
| `ProjectSettings/` | Unity project configuration files |

## Scripts and Modules 🧠

| Script | Responsibility |
| --- | --- |
| `PlayerMovement.cs` | Controls forward movement, lane switching, jumping, sliding, and obstacle collision handling |
| `PlayerManager.cs` | Tracks game state, coin count, start flow, and game over UI |
| `TileManager.cs` | Spawns and deletes track tiles to keep the run endless |
| `Coin.cs` | Handles coin rotation, pickup detection, score increment, and pickup audio |
| `AudioManager.cs` | Provides persistent sound playback across scenes |
| `Sounds.cs` | Defines sound metadata such as clip, volume, pitch, and loop settings |
| `CameraController.cs` | Smoothly follows the player along the Z axis |
| `MainMenu.cs` | Loads the gameplay scene and exits the application |

## Installation and Setup ⚙️

1. Install **Unity 6.4.5f1** or a compatible Unity 6 version through Unity Hub.
2. Clone or download this repository.
3. Open the project folder in Unity Hub.
4. Let Unity import all assets and packages listed in `Packages/manifest.json`.
5. Open the main gameplay scene from `Assets/Scenes`.
6. Press **Play** in the Unity Editor to test the game.

If you plan to build the project:

- Open **File > Build Settings**
- Add the menu and gameplay scenes to the build list
- Choose your target platform, such as Windows or WebGL
- Build and run the project

## How to Play 🕹️

| Action | Control |
| --- | --- |
| Start the game | Left mouse click on the main menu / start screen |
| Move left | Left Arrow |
| Move right | Right Arrow |
| Jump | Up Arrow or Space |
| Slide | Down Arrow |
| Collect coins | Run through coin pickups |

Goal: survive as long as possible, avoid obstacles, and collect as many coins as you can before crashing.

## Gameplay GIF 🎬

<p align="center">
	<img src="assets/gifs/gameplay.gif" alt="Gameplay GIF" width="900" />
</p>

> Replace the placeholder GIF with a short gameplay capture for the best GitHub presentation.

## Screenshots 📸

Add your best in-game images here to make the repository more portfolio-ready.

### Main Menu

![Main Menu Screenshot](assets/screenshots/main-menu.png)

### Gameplay

![Gameplay Screenshot](assets/screenshots/gameplay.png)

### Game Over

![Game Over Screenshot](assets/screenshots/game-over.png)

Suggested screenshot set:

| Shot | Recommended content |
| --- | --- |
| Main menu | Title screen, start button, and branding |
| Gameplay | Player in motion with obstacles and coin pickups |
| Game over | Failure state with restart or menu UI |

## Future Improvements 🔮

- Add a persistent high score system
- Introduce increasing difficulty with dynamic obstacle density
- Add power-ups such as shields, magnet coins, and speed boosts
- Support mobile touch controls and swipe gestures
- Expand the obstacle and tile variety
- Add pause, settings, and restart menus
- Save player progress and stats locally
- Add visual polish with particle effects and camera shake

## Contribution Guidelines 🤝

Contributions are welcome. If you want to improve the project, please:

1. Fork the repository.
2. Create a feature branch for your changes.
3. Keep gameplay changes focused and easy to review.
4. Test the project in Unity before opening a pull request.
5. Submit a clear PR description with screenshots or short clips when relevant.

## License 📄

This repository does not currently include a license file.

If you plan to distribute or reuse this project, add an appropriate open-source license such as MIT, Apache 2.0, or GPL, depending on your intended usage.

Adding a license file is recommended before treating the project as fully open source.

## Author 👤

- **Muhammad Zeeshan Islam**

## Notes

- The project is built around a small, modular script set, which makes it a good candidate for portfolio demonstrations, gameplay iteration, and future expansion.
- The scene name referenced by the menu script is `Level`, so make sure that scene exists in the build settings before building the game.
- The README is intentionally written to work as a GitHub portfolio landing page and can be expanded with badges, GIFs, and gameplay clips.
