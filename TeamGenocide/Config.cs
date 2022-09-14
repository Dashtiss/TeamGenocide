﻿using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using TeamGenocide.API.Entities;
using UnityEngine;

namespace TeamGenocide
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("These are the announcements that will be made for each team that dies.")]
        public Dictionary<Team, Announcement> Announcements { get; set; } = new Dictionary<Team, Announcement>()
        {
            [Team.CDP] = new Announcement()
            {
                Cassie = "All class D personnel have been secured .",
                Subtitle = "All Class D Personnel have been secured.",
                Broadcast = "All Class D Personnel have been secured.",
                Hint = "All Class D Personnel have been secured.",
                DisplayTime = 15,
                Lights = new Lights()
                {
                    Color = Color.black,
                    Duration = 5f,
                    Zones = new List<ZoneType>()
                    {
                        ZoneType.Surface,
                        ZoneType.Entrance,
                        ZoneType.HeavyContainment,
                        ZoneType.LightContainment
                    }
                }
            },
            [Team.SCP] = new Announcement()
            {
                Cassie = "All S C P subjects have been secured .",
                Subtitle = null,
                Broadcast = null,
                Hint = "All SCP Subjects have been secured.",
                DisplayTime = 10,
                Lights = new Lights()
                {
                    Color = Color.red,
                    Duration = 5f,
                    Zones = new List<ZoneType>()
                    {
                        ZoneType.Surface,
                        ZoneType.Entrance,
                        ZoneType.HeavyContainment,
                        ZoneType.LightContainment
                    }
                }
            }
        };
    }
}
