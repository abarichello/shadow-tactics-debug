# shadow-tactics-debug

Enhanced debug mode for Shadow Tactics: Blades of The Shogun.<br>
Currently supports Steam/Windows release on version **2.2.10.F**.

<!-- <a href="https://www.youtube.com/watch?v=J8ee1b1XuMg"><img src="https://i.imgur.com/So7J885.png" width="400"></a> -->

# Changes

The mod has better keybinds that don't conflict when multiple debug options are used together, more convenient camera settings for video recording and overlay text showing all the available functions.

#### TODO:

- Add screenshots and video

# Setup

## Install

1. Download `Assembly-CSharp.dll` from the releases tab in this repository.
2. Drop the downloaded DLL into `X:\SteamLibrary\steamapps\common\Shadow Tactics\Shadow Tactics_Data\Managed\` replacing the original file.
3. Add the following launch argument to the game 'thisisnotsupported' or type that with the game's Option panel open.

To uninstall the mod simply ask for Steam to check the files on the game's property panel.

## Compiling

To generate this DLL yourself first you need to download [dnSpy](https://github.com/0xd4d/dnSpy), decompile the game's `Assembly-CSharp.dll` and apply the patch file to the decompiled sources. After that use 'Save Module' to generate a new DLL replacing the game's original one.

# Keybinds

<a><img src="https://i.imgur.com/IcNUnc6.png" width="500"></a>

# Notes about the game

## Dev mode on console

Dev mode by typing 'thisisnotsupported' during the Options menu is available on the Retail release and possibly on consoles too (needs a plugged keyboard).

## Gameplay

The 'When Cut Across the Neck' achievement can be obtained by shooting Noboru with your matchlock pistol (when using the teleport cheat with F10) instead of making the soldier misfire.<br>
More dev options are available for spawning/killing/teleporting but they are undocumented, check the game's source code for the rest.

## Character development names:

- Hayato - Ninja
- Yuki - Trapper
- Mugen - Warrior
- Ayko - Geisha
- Takuma - Alchemist

# License

The `src` folder contains the code that I've added/altered to make the mod possible. The three dots indicate sections of code that I decided to remove since I can't redistribute the codebase.
