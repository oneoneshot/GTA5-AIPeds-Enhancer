
﻿using System.ComponentModel;
using IntelliPed.Core.Agents;
using IntelliPed.Messages.Navigation;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.SemanticKernel;

namespace IntelliPed.Core.Plugins;

public class NavigationPlugin
{
    [KernelFunction]
    [Description("Navigates to the specified co-ordinates.")]
    public async Task<string> NavigateTo(
        Kernel kernel,
        [Description("The co-ordinates.")] Coordinates coordinates)
    {
        Agent agent = kernel.GetRequiredService<Agent>();

        await agent.HubConnection.InvokeAsync("MoveToPosition", new MoveToPositionRequest
        {