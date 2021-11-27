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
        Text = text;
        Color = color ?? Color.White;
    }

    public virtual void Draw()
    {
        float screenX = 0f;
        float screenY = 0f;

        bool isOnScreen = API.World3dToScreen2d(
            Position.X,
            Position.Y,
            Position.Z,
            ref screenX,
            ref screenY);

        Vector3 gameplayCamCoords = API.GetGameplayCamCoords();

        float distance = API.GetDistanceBetweenCoords(
            gameplayCamCoords.X,
            gameplayCamCoords.Y,
            gameplayCamCoords.Z,
            Position.X,
            Position.Y,
            Position.Z,
            t