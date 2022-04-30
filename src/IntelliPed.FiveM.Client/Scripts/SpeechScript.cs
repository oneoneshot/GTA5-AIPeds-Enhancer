
﻿using CitizenFX.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntelliPed.FiveM.Client.Models;

namespace IntelliPed.FiveM.Client.Scripts;

public class Speech : BaseScript
{
    private readonly List<SpeechData> _speechData = [];

    [Tick]
    public Task OnTick()
    {
        foreach (SpeechData speechData in _speechData.ToList())
        {
            if (Game.GameTime - speechData.TimeStarted > speechData.DurationMs
                || speechData.Ped.Exists() == false)
            {
                _speechData.Remove(speechData);
                continue;
            }

            if (Game.PlayerPed.Position.DistanceToSquared(speechData.Ped.Position) <= 75)
            {
                speechData.PedTextDraw.Draw();
            }
        }