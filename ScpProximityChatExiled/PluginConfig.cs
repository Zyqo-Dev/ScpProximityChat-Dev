using System.Collections.Generic;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace ScpProximityChatExiled;

public class PluginConfig : IConfig
{
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; } = false;

    public bool ToggleChat { get; set; } = true;

    public float MaxProximityDistance { get; set; } = 7f;

    public HashSet<RoleTypeId> AllowedRoles { get; set; } = new()
    {
        RoleTypeId.Scp049,
        RoleTypeId.Scp096,
        RoleTypeId.Scp106,
        RoleTypeId.Scp173,
        RoleTypeId.Scp0492,
        RoleTypeId.Scp939
    };

    public bool SendBroadcastOnRoleChange { get; set; } = false;
}
