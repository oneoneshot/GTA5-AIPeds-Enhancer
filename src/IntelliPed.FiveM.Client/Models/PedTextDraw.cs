using CitizenFX.Core;

namespace IntelliPed.FiveM.Client.Models;

public class PedTextDraw : TextDraw
{
    private readonly Ped _ped;

    public PedTextDraw(Ped ped, string text, Color? color = null) : base(ped.Position, text, color)
    {
        _ped = ped