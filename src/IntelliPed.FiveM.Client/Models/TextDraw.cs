using CitizenFX.Core.Native;
using CitizenFX.Core;

namespace IntelliPed.FiveM.Client.Models;

public class TextDraw
{
    protected Vector3 Position;
    protected string Text;
    protected Color Color;

    public TextDraw(Vector3 position, string text, Color? color = null)
    {
        Position = position;
        Text = tex