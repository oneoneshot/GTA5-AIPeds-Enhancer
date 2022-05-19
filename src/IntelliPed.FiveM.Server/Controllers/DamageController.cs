using System;
using CitizenFX.Core;
using IntelliPed.FiveM.Server.Hubs;
using IntelliPed.Messages.Signals;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

namespace IntelliPed.FiveM.Server.Controllers;

public class DamageController : BaseScript
{
    [EventHandler("PedDamaged")]
    private async void OnPedDamaged([FromSource] Player player, int pedNetworkId, int previousHealth, int currentHealth)
    {
        try
        {
            IHubContext<AgentHub> agentHub = Program.ScopedServices.GetRequiredService<IHubContext<AgentHub>>();

        