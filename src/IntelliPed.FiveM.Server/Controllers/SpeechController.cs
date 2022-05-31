
﻿using CitizenFX.Core;
using IntelliPed.FiveM.Server.Hubs;
using IntelliPed.Messages.Signals;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IntelliPed.FiveM.Server.Controllers;

public class SpeechController : BaseScript
{
    [EventHandler("chatMessage")]
    private void OnChatMessage(int source, string name, string message)
    {
        try