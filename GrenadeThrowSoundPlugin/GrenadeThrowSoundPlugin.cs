using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Localization;
using static GrenadeThrowSoundPlugin.GrenadeThrowSoundPlugin;
namespace GrenadeThrowSoundPlugin
{
    [MinimumApiVersion(80)]
    public class GrenadeThrowSoundPlugin : BasePlugin, IPluginConfig<GrenadeThrowSoundsConfig>
    {
        public override string ModuleName => "GrenadeThrowSoundPlugin";
        public override string ModuleVersion => "0.0.1";
        public override string ModuleAuthor => "hlymcn";
        public override string ModuleDescription => "Play a custom sound when a player throws a grenade.";
        public required GrenadeThrowSoundsConfig Config { get; set; }
        public readonly IStringLocalizer<GrenadeThrowSoundPlugin> _localizer;
        public GrenadeThrowSoundPlugin(IStringLocalizer<GrenadeThrowSoundPlugin> localizer)
        {
            _localizer = localizer;
        }

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventGrenadeThrown>(OnGrenadeThrown);
        }

        private HookResult OnGrenadeThrown(EventGrenadeThrown @event, GameEventInfo info)
        {
            var player = @event.Userid;
            if (player == null || !player.IsValid || player.IsBot)
                return HookResult.Continue;

            if (@event.Weapon == "hegrenade")
            {
                var sound = Config.GrenadeThrowSounds[Random.Shared.NextDistinct(Config.GrenadeThrowSounds.Count)];
                foreach (var onlinePlayer in Utilities.GetPlayers())
                {
                    onlinePlayer.ExecuteClientCommand($"play \"{sound}\"");
                }

                var teamColor = player?.Team switch
                {
                    CsTeam.CounterTerrorist => ChatColors.Blue,
                    CsTeam.Terrorist => ChatColors.Red,
                    _ => ChatColors.White
                };

                var playerName = player?.PlayerName ?? "Console";
                Server.PrintToChatAll($"{this._localizer["lang.chatall.grenade", playerName, teamColor]}");
            }
               return HookResult.Continue;
        }

        public void OnConfigParsed(GrenadeThrowSoundsConfig config)
        {
            Config = config;
            if (config.GrenadeThrowSounds.Count == 0)
            {
                Server.PrintToConsole("音源文件未设置!");
            }
            else
            {
                Server.PrintToConsole($"载入 {config.GrenadeThrowSounds.Count} 音源文件!");
            }
        }

        public class GrenadeThrowSoundsConfig : BasePluginConfig
        {
            public List<string> GrenadeThrowSounds { get; set; } =[];
        }
    }
}
