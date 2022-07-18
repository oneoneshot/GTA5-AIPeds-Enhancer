namespace IntelliPed.Messages.Signals;

public record DamageSignal : Signal
{
    public required int DamageAmount { get; init; }
    public required string Source { get; init; }