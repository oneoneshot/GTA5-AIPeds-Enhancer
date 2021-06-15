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
    public HubConnection HubConnection { get; }
    private readonly SignalProcessor _signalProcessor;

    public Agent(OpenAiOptions openAiOptions)
    {
        _signalProcessor = new(this);

        HubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/agent-hub")
            .Build();

        IKernelBuilder kernelBuilder = Kernel.CreateBuilder();

        