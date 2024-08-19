using CommandSystem;
using Exiled.API.Features;
using PlayerRoles;
using ScpProximityChatExiled.Features;
using System;

namespace ScpProximityChatExiled
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class ChatCommand : ICommand
    {
        public string Command => "chat";
        public string[] Aliases => new string[] { };
        public string Description => "Toggles SCP proximity chat on or off";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var player = Player.Get(sender);


            if (!IsScp(player.Role.Type))
            {
                response = "Only SCP players can use this command.";
                return false;
            }

            if (ScpProximityChatHandler.ToggledPlayers.Contains(player))
            {
                ScpProximityChatHandler.ToggledPlayers.Remove(player);
                response = "Proximity chat disabled.";
            }
            else
            {
                ScpProximityChatHandler.ToggledPlayers.Add(player);
                response = "Proximity chat enabled.";
            }
            return true;
        }

        private bool IsScp(RoleTypeId role)
        {
            return role == RoleTypeId.Scp049 ||
                   role == RoleTypeId.Scp096 ||
                   role == RoleTypeId.Scp106 ||
                   role == RoleTypeId.Scp173 ||
                   role == RoleTypeId.Scp0492 ||
                   role == RoleTypeId.Scp939;
        }
    }
}
