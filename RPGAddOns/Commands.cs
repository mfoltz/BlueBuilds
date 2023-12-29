﻿using Bloodstone.API;
using System.Text.Json;
using Unity.Entities;
using VampireCommandFramework;

namespace RPGAddOns
{

    [CommandGroup(name: "rpg", shortHand: "rpg")]
    internal class Commands
    {
        [Command(name: "prestige", shortHand: "pr", adminOnly: false, usage: "Resets your prestige and grants a buff if eligible.", description: "Resets your prestige and grants a buff if eligible.")]
        public static void ResetPointsCommand(ChatCommandContext ctx)
        {
            var user = ctx.Event.User;
            string name = user.CharacterName.ToString();
            var SteamID = user.PlatformId;
            string StringID = SteamID.ToString();



            // Call the ResetPoints method from Prestige


            //PrestigeCommands.ResetPoints(ctx, name, SteamID, StringID);
        }
        [Command(name: "resetlevel", shortHand: "rl", adminOnly: false, usage: "Use this command to reset your level to 1 after reaching max level to receive extra stats.", description: "Reset your level for extra stats.")]

        public static void ResetLevelCommand(ChatCommandContext ctx)
        {
            var user = ctx.Event.User;
            string name = user.CharacterName.ToString();
            var SteamID = user.PlatformId;
            string StringID = SteamID.ToString();



            // Call the ResetLevel method from ResetLevelRPG

            //EntityManager entityManager = default;
            //ResetLevelRPG.ResetLevel(ctx, name, SteamID, StringID);


        }

        private static EntityManager entityManager = VWorld.Server.EntityManager;
        public static void LoadData()
        {

            if (!File.Exists(Plugin.PlayerPrestigeJson))
            {
                var stream = File.Create(Plugin.PlayerPrestigeJson);
                stream.Dispose();
            }

            string json = File.ReadAllText(Plugin.PlayerPrestigeJson);
            try
            {
                Databases.playerPrestige = JsonSerializer.Deserialize<Dictionary<string, PrestigeData>>(json);
                Plugin.Logger.LogWarning("Player Prestige Populated");
            }
            catch
            {
                Databases.playerPrestige = [];
                Plugin.Logger.LogWarning("Player Prestige Created");
            }
            if (!File.Exists(Plugin.PlayerResetCountsBuffsJson))
            {
                var stream = File.Create(Plugin.PlayerResetCountsBuffsJson);
                stream.Dispose();
            }

            json = File.ReadAllText(Plugin.PlayerResetCountsBuffsJson);
            try
            {
                Databases.playerResetCountsBuffs = JsonSerializer.Deserialize<Dictionary<string, ResetData>>(json);
                Plugin.Logger.LogWarning("Player ResetCountsBuffs Populated");
            }
            catch
            {
                Databases.playerResetCountsBuffs = [];
                Plugin.Logger.LogWarning("Player ResetCountsBuffs Created");
            }


        }

        public static void SavePlayerResets()
        {
            File.WriteAllText(Plugin.PlayerResetCountsBuffsJson, JsonSerializer.Serialize(Databases.playerResetCountsBuffs));

        }
        public static void SavePlayerPrestige()
        {
            File.WriteAllText(Plugin.PlayerPrestigeJson, JsonSerializer.Serialize(Databases.playerPrestige));

        }
    }
}