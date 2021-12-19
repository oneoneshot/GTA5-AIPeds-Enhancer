using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace IntelliPed.FiveM.Client;

public class Program : BaseScript
{
    [EventHandler("onClientResourceStart")]
    public void OnClientResourceStart(string resourceName)
    {
        if (API.GetCurrentResourceName() != resourceName)
        {
            return;
        }

        API.SetPoliceIgnorePlayer(API.PlayerId(), true);
        API.SetDispatchCopsForPlayer(API.PlayerId(), false);
        API.SetMaxWantedLevel(0);
        API.SetEntityCoords(API.PlayerPedId(), 0f, 0f, 72f, fal