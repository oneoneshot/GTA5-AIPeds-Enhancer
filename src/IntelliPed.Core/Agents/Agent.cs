using IntelliPed.Core.Plugins;
using IntelliPed.Core.Signals;
using IntelliPed.Messages.Signals;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;

namespace IntelliPed.Core.Agents;

public class Agent
{
    public Kernel Kernel { get; }
    public HubConnection HubConnection { get