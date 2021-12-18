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
            retu