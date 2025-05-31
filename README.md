# GrenadeThrowSoundPlugin for Counter-Strike 2

## Overview

**GrenadeThrowSoundPlugin** is a custom plugin for Counter-Strike 2 servers that enhances the gameplay experience by playing a custom sound whenever a player throws a grenade. This plugin adds an additional layer of immersion and excitement to the game, making grenade throws more impactful and noticeable to all players on the server.

## Key Features

- **Custom Grenade Throw Sounds:** Automatically play a random sound from a predefined list when a player throws a grenade.
- **Configurable Sound List:** Administrators can easily customize the list of grenade throw sounds via a configuration file.
- **Localized Chat Messages:** The plugin supports localized chat messages, allowing for multilingual server communication.
- **Team-Based Chat Colors:** Display chat messages with team-specific colors (e.g., blue for Counter-Terrorists, red for Terrorists).
- **Event-Driven:** The plugin triggers sounds based on the `EventGrenadeThrown` event, ensuring seamless integration with the game's mechanics.

## Identifiers

- **ModuleName:** GrenadeThrowSoundPlugin  
- **ModuleVersion:** 0.0.1  
- **ModuleAuthor:** hlymcn  
- **ModuleDescription:** Play a custom sound when a player throws a grenade.

## Usage

To utilize the GrenadeThrowSoundPlugin, follow these steps:

1. **Installation:** Acquire the plugin from the [GitHub repository](https://github.com/hlymcn/GrenadeThrowSoundPlugin) and place it in your server's plugin directory.
2. **Configuration:** Customize the plugin by editing the `GrenadeThrowSoundsConfig` file to add or modify grenade throw sounds.
3. **Activation:** Upon activation, the plugin will automatically play a random grenade throw sound whenever a player throws a grenade and display a localized chat message.

## Requirements

- CounterStrikeSharp: [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)  
- MetaMod: [MetaMod](https://www.metamodsource.net/downloads.php?branch=dev)

## Installation

1. Clone the repository or download the latest release from [GitHub](https://github.com/hlymcn/GrenadeThrowSoundPlugin).
2. Copy the plugin files to `...\addons\counterstrikesharp\plugins\GrenadeThrowSoundPlugin`.
3. Edit the configuration file `...\addons\counterstrikesharp\configs\plugins\GrenadeThrowSoundPlugin\GrenadeThrowSoundsConfig.json` to set up your grenade throw sounds.
4. Ensure your server meets the API version requirements and adjust settings as necessary.

## Contribution and Support

We encourage community contributions. 
For suggestions or to report issues, please submit a pull request or open an issue on the [GitHub repository](https://github.com/hlymcn/GrenadeThrowSoundPlugin). Your input is crucial for the ongoing development of the plugin.

## License

This project is licensed under the GPL3.0 License - see the LICENSE file for details.

## Conclusion

The GrenadeThrowSoundPlugin is a fun and engaging addition to Counter-Strike 2 servers, adding a unique auditory element to the game. Its easy setup and customizable features make it an excellent choice for server administrators looking to enhance their players' experience and create a more immersive environment.
