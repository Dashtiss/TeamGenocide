﻿using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using TeamGenocide.API.Entities;
using TeamGenocide.API.Enums;

namespace TeamGenocide
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("It is recommended to come up with your own announcements for your server, these are just crappy examples.")]
        public IEnumerable<Announcement> Announcements { get; set; } = new List<Announcement>()
        {
            new Announcement()
            {
                Team = Team.CDP,
                AnnouncementCassie = "All class D personnel have been secured .",
                AnnouncementSubtitle = "All Class D Personnel have been secured.",
                AnnouncementBroadcast = "All Class D Personnel have been secured.",
                AnnouncementHint = "All Class D Personnel have been secured.",
                AnnouncementType = AnnouncementType.Cassie | AnnouncementType.Broadcast | AnnouncementType.Hint
            },
            new Announcement()
            {
                Team = Team.SCP,
                AnnouncementCassie = "All S C P subjects have been secured .",
                AnnouncementSubtitle = null,
                AnnouncementBroadcast = null,
                AnnouncementHint = "All SCP Subjects have been secured.",
                AnnouncementType = AnnouncementType.Cassie | AnnouncementType.Hint
            }
        };
    }
}
