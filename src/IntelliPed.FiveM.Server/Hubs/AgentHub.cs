
﻿using System.Linq;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using CitizenFX.Core;
using FxMediator.Server;
using IntelliPed.FiveM.Server.Extensions;
using IntelliPed.FiveM.Server.Util;
using IntelliPed.FiveM.Shared.Requests.Puppets;
using IntelliPed.FiveM.Shared.Requests.Navigation;
using IntelliPed.Messages;
using IntelliPed.Messages.Navigation;
using IntelliPed.Messages.Speech;

namespace IntelliPed.FiveM.Server.Hubs;

public class AgentHub : Hub<IAgentHub>, IAgentHub
{
    private readonly ServerMediator _mediator;
    private readonly BaseScriptProxy _baseScriptProxy;

    public AgentHub(ServerMediator mediator, BaseScriptProxy baseScriptProxy)
    {