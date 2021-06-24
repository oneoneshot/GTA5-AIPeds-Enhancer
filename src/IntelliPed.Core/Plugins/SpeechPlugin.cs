using System.ComponentModel;
using IntelliPed.Core.Agents;
using IntelliPed.Messages.Speech;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.SemanticKernel;

namespace IntelliPed.Core.Plugins;

public class SpeechPlugin
{
    [KernelFunction]
    