namespace IntelliPed.FiveM.Client.Models;

public record Color(int R, int G, int B, int A = 255)
{
    public static Color Red => new(255, 0, 0);
    public static Color Blue => new