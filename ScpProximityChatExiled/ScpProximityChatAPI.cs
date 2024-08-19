using Exiled.API.Features;
using ScpProximityChatExiled.Features;
using System.Collections.Generic;
using System.Linq;

namespace ScpProximityChatExiled
{
    public static class ScpProximityChatAPI
    {
        /// <summary>
        /// Checks whether the SCP proximity chat is activated globally.
        /// </summary>
        public static bool IsProximityChatEnabled => ScpProximityChatModule.PluginConfig.ToggleChat;

        /// <summary>
        /// Checks whether a specific player has activated the SCP proximity chat.
        /// </summary>
        /// <param name="player">The player you want to check.</param>
        /// <returns>True, if the player has activated SCP proximity chat, otherwise False.</returns>
        public static bool IsPlayerUsingProximityChat(Player player)
        {
            return ScpProximityChatHandler.ToggledPlayers.Contains(player);
        }

        /// <summary>
        /// Checks whether the player is an SCP.
        /// </summary>
        /// <param name="player">The player you want to check.</param>
        /// <returns>True, if the player is an SCP, otherwise False.</returns>
        public static bool IsScp(Player player)
        {
            return ScpProximityChatHandler.IsScp(player.Role.Type);
        }
    }
}
