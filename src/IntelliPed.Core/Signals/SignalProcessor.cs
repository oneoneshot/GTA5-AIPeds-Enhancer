using System.Collections.Concurrent;
using IntelliPed.Core.Agents;
using IntelliPed.Messages.Signals;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace IntelliPed.Core.Signals;

public class SignalProcessor
{
    public bool IsProcessing { get; private set; }
    private readonly Agent _agent;
    private readonly ConcurrentQueue<Signal> _signalQueue = [];
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public SignalProcessor(Agent agent)
    {
        _agent = agent;
    }

    public void Start()
    {
        if (IsProcessing) throw new InvalidOperationException("Signal processor is already running.");
        IsProcessing = true;
        Task.Run(() => ProcessSignals(_cancellationTokenSource.Token));
    }

    public void Stop()
    {
        if (!IsProcessing) throw new InvalidOperati