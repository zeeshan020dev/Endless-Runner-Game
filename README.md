<div align="center">

# 🏃‍♂️ Endless Runner Game

*A high-octane 3D endless runner built in Unity. Survive the track by switching lanes, sliding under barriers, and leaping over obstacles while collecting coins in a dynamically generated world.*

<p align="center">
	<img alt="Unity Version" src="https://img.shields.io/badge/Unity-6.4.5f1-000000?style=for-the-badge&logo=unity" />
	<img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" />
	<img alt="Platform" src="https://img.shields.io/badge/Platform-PC%20%7C%20WebGL-2ea44f?style=for-the-badge" />
	<img alt="URP" src="https://img.shields.io/badge/Render_Pipeline-URP-8b5cf6?style=for-the-badge" />
</p>
<p align="center">
	<img alt="Stars" src="https://img.shields.io/github/stars/zeeshan020dev/Endless-Runner-Game?style=for-the-badge&logo=github&color=eab308" />
	<img alt="Forks" src="https://img.shields.io/github/forks/zeeshan020dev/Endless-Runner-Game?style=for-the-badge&logo=github&color=3b82f6" />
	<img alt="License" src="https://img.shields.io/badge/License-MIT-gray?style=for-the-badge&logo=github" /> <!-- Update if different -->
</p>

[Gameplay Video](#-media--previews) • [Installation](#-getting-started) • [Architecture](#-project-architecture) • [Contributing](#-contributing)

</div>

---

## 📖 Overview

**Endless Runner Game** is a lightweight, highly modular 3D endless runner designed to showcase clean code architecture and core gameplay loops in Unity. Players must navigate a continuously spawning, accelerating track utilizing a three-lane movement system. 

Built with the **Universal Render Pipeline (URP)**, this project features robust audio management, dynamic object pooling (tile spawning), and a clean, responsive UI system. It serves as an excellent foundational template for portfolio presentation, rapid prototyping, or expanding into a full-scale mobile/PC release.

---

## ✨ Key Features

| Feature | Description |
| :--- | :--- |
| **🛣️ Dynamic Lane Control** | Smooth, responsive transition mechanics between three distinct lanes. |
| **🦘 Parkour Mechanics** | Context-sensitive jump and slide actions to dodge varying obstacle heights. |
| **♾️ Infinite Generation** | Optimized dynamic tile spawning and cleanup system for infinite, memory-efficient gameplay. |
| **📈 Progressive Difficulty** | Automatic forward movement with a gradual speed acceleration cap to increase tension. |
| **🪙 Risk/Reward Economy** | Collectible coins strategically placed to challenge player routing and increase scores. |
| **🔊 Immersive Audio** | Persistent singleton-based audio manager for seamless BGM and distinct SFX. |

---

## 🎮 Gameplay Mechanics & Controls

| Action | Control Input | System Response |
| :--- | :--- | :--- |
| **Start Game** | `Left Mouse Click` | Transitions from Main Menu to gameplay state. |
| **Lane Switch** | `Left/Right Arrows` | Smoothly interpolates the player's X-axis to the adjacent lane. |
| **Jump** | `Up Arrow` / `Space` | Applies vertical force (only if grounded) to clear low obstacles. |
| **Slide** | `Down Arrow` | Triggers slide animation and dynamically shrinks the character's collider. |

> **Objective:** Survive as long as possible, maximize your coin count, and adapt to the increasing speed without colliding with any track obstacles.

---

## 🛠️ Tech Stack & Environment

- **Game Engine:** Unity 6.4.5f1 (6000.4.5f1 LTS recommended)
- **Render Pipeline:** Universal Render Pipeline (URP)
- **Scripting:** C# (Object-Oriented Design)
- **UI Framework:** Unity UI & TextMeshPro
- **Target Platforms:** Windows / macOS / WebGL

---

## 🏗️ Project Architecture

The codebase is structured for readability, making it highly extensible for future mechanics (like power-ups or enemies).

### Core Scripts

*   `PlayerMovement.cs`: The core state machine handling physics, input parsing, lane logic, and collision detection.
*   `TileManager.cs`: Handles procedural level generation. Spawns new track prefabs ahead of the player and destroys trailing ones to maintain optimal performance.
*   `PlayerManager.cs`: Controls the high-level game state (Start, Pause, Game Over) and manages the UI score updates.
*   `AudioManager.cs` & `Sounds.cs`: A scalable, persistent audio system utilizing arrays of custom sound classes for easy inspector tweaking.

### Directory Structure

```text
Assets/
├── Animations/       # Player state animations (Run, Jump, Slide, Crash)
├── Materials/        # URP-compatible materials
├── Models/           # 3D meshes for player, obstacles, and environment
├── Prefabs/          # Reusable GameObjects (Track Tiles, Coins, Obstacles)
├── Scenes/           # MainMenu, Level (Gameplay)
├── Scripts/          # Core logic, divided by responsibility
└── Sounds/           # BGM and SFX audio clips

```

---

## 🚀 Getting Started

### Prerequisites

* [Unity Hub](https://unity.com/download) installed.
* **Unity Editor version 6000.4.5f1** (or a closely compatible Unity 6 build).

### Installation

1. **Clone the repository:**

```bash
   git clone [https://github.com/zeeshan020dev/Endless-Runner-Game.git](https://github.com/zeeshan020dev/Endless-Runner-Game.git)

```

2. **Open in Unity:** Add the project folder via Unity Hub and open it. Allow Unity to resolve packages from `manifest.json`.
3. **Configure Build Settings:**

* Go to `File > Build Settings`.
* Ensure `Assets/Scenes/MainMenu.unity` is at index `0`.
* Ensure `Assets/Scenes/Level.unity` is at index `1`.

4. **Play:** Open the `MainMenu` scene and press the Play button in the editor.

---

## 📸 Media & Previews

### 🎥 Full Gameplay Recording

[](https://www.google.com/search?q=Recordings/Shot-1.mp4)
*Click the image above to view the raw gameplay recording, or [download it here](https://www.google.com/search?q=Recordings/Shot-1.mp4).*

*(Note: For the best GitHub experience, consider uploading your recording to YouTube and replacing `YOUR_YOUTUBE_VIDEO_ID` in the image URL above, linking directly to the video).*

---

## 🔮 Roadmap

* [ ] **Power-up System:** Invincibility shields, coin magnets, and score multipliers.
* [ ] **Mobile Optimization:** Implement touch/swipe gesture controls for iOS/Android builds.
* [ ] **Environment Biomes:** Dynamic visual swapping of tiles as the run progresses.
* [ ] **Data Persistence:** Local saving for High Scores and Total Coins using PlayerPrefs or JSON.
* [ ] **Game Feel Polish:** Camera shake on near-misses, particle bursts on coin pickup.

---

## 🤝 Contributing

Contributions, issues, and feature requests are highly encouraged! This is a great project for learning Unity mechanics.

1. **Fork** the project.
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the Branch (`git push origin feature/AmazingFeature`).
5. Open a **Pull Request**.

---

## 📄 License

This project currently does not have an explicit open-source license.
*(If you intend for others to use/modify this code, consider adding an `MIT` or `Apache-2.0` license file to the root directory.)*

---

## 👤 Author

**[Muhammad Zeeshan Islam](https://github.com/zeeshan020dev)**  

<a href="https://github.com/zeeshan020dev">
  <img src="https://img.shields.io/badge/GitHub-zeeshan020dev-ffffff?style=for-the-badge&logo=github&logoColor=white&labelColor=0d1117" />
</a>
