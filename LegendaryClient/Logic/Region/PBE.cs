﻿using System;
using System.Net;

namespace LegendaryClient.Logic.Region
{
    public sealed class PBE : BaseRegion
    {
        public override bool Garena
        {
            get { return false; }
        }

        public override string Server
        {
            get { return "prod.pbe1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.pbe1.lol.riotgames.com/"; }
        }

        public override string RegionName
        {
            get { return "PBE"; }
        }

        public override string InternalName
        {
            get { return "PBE1"; }
        }

        public override string ChatName
        {
            get { return "pbe1"; }
        }

        public override string Locale
        {
            get { return "en_US"; }
        }

        public override System.Uri NewsAddress
        {
            get { return new System.Uri("http://na.leagueoflegends.com/en/rss.xml"); }
        }

        public override IPAddress[] PingAddresses
        {
            get
            {
                return new[]
                {
                    IPAddress.Parse("216.52.241.254"),
                    IPAddress.Parse("64.7.194.1"),
                    IPAddress.Parse("66.150.148.1")
                };
            }
        }

        public override string Location
        {
            get { return null; }
        }

        public override System.Uri SpectatorLink
        {
            get { return new System.Uri("http://spectator.pbe1.lol.riotgames.com:8088/observer-mode/rest/"); }
        }

        public override string SpectatorIpAddress
        {
            get { return "spectator.pbe1.lol.riotgames.com:80"; }
            set { }
        }

        public void NASqlite()
        {
            Client.sqlite = "gameStats_en_US.sqlite";
        }
    }
}