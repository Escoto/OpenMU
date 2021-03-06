﻿// <copyright file="ChaosCastle2.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Maps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MUnique.OpenMU.AttributeSystem;
    using MUnique.OpenMU.DataModel.Configuration;
    using MUnique.OpenMU.GameLogic.Attributes;

    /// <summary>
    /// Initialization for the Chaos Castle 2.
    /// </summary>
    internal class ChaosCastle2 : BaseMapInitializer
    {
        /// <summary>
        /// The default number of the Chaos Castle 2 map.
        /// </summary>
        public static readonly byte Number = 19;

        /// <inheritdoc/>
        protected override byte MapNumber => Number;

        /// <inheritdoc/>
        protected override string MapName => "Chaos Castle 2";

        /// <inheritdoc/>
        protected override IEnumerable<MonsterSpawnArea> CreateSpawns(IContext context, GameMapDefinition mapDefinition, GameConfiguration gameConfiguration)
        {
            var npcDictionary = gameConfiguration.Monsters.ToDictionary(npc => npc.Number, npc => npc);

            // Monsters:
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 105, 105); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 028, 028, 090, 090); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 028, 028, 082, 082); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 034, 034, 078, 078); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 039, 039, 078, 078); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 080, 080); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 086, 086); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 082, 082); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 032, 032, 091, 091); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 090, 090); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 078, 078); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 040, 040, 098, 098); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 033, 033, 103, 103); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 105, 105); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 035, 035, 105, 105); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 028, 028, 097, 097); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 028, 028, 079, 079); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 025, 025, 082, 082); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 033, 033, 076, 076); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 031, 031, 080, 080); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 076, 076); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 039, 039, 082, 082); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 094, 094); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 034, 034, 090, 090); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 105, 105); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 028, 028, 100, 100); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 035, 035, 102, 102); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 096, 096); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 025, 025, 091, 091); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 098, 098); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 089, 089); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 039, 039, 095, 095); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 103, 103); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 025, 025, 097, 097); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 027, 027, 088, 088); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 032, 032, 089, 089); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 037, 037, 089, 089); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 099, 099); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 081, 081); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 075, 075); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 024, 024, 080, 080); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 024, 024, 089, 089); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 024, 024, 101, 101); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 096, 096); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 076, 076); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 096, 096); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 032, 032, 078, 078); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 027, 027, 104, 104); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 044, 044, 102, 102); // Chaos Castle 3
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[164], 1, 0, SpawnTrigger.AutomaticDuringEvent, 039, 039, 093, 093); // Chaos Castle 3

            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 098, 098); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 027, 027, 086, 086); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 079, 079); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 033, 033, 081, 081); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 077, 077); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 077, 077); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 084, 084); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 027, 027, 094, 094); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 084, 084); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 044, 044, 087, 087); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 092, 092); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 101, 101); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 089, 089); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 099, 099); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 093, 093); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 084, 084); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 076, 076); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 035, 035, 079, 079); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 079, 079); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 036, 036, 081, 081); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 086, 086); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 035, 035, 092, 092); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 101, 101); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 102, 102); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 106, 106); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 042, 042, 102, 102); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 088, 088); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 091, 091); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 093, 093); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 091, 091); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 032, 032, 101, 101); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 033, 033, 105, 105); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 024, 024, 094, 094); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 032, 032, 094, 094); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 036, 036, 092, 092); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 040, 040, 091, 091); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 040, 040, 101, 101); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 036, 036, 076, 076); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 026, 026, 075, 075); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 082, 082); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 024, 024, 086, 086); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 037, 037, 104, 104); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 039, 039, 087, 087); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 038, 038, 084, 084); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 030, 030, 095, 095); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 029, 029, 086, 086); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 040, 040, 104, 104); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 043, 043, 098, 098); // Chaos Castle 4
            yield return this.CreateMonsterSpawn(context, mapDefinition, npcDictionary[165], 1, 0, SpawnTrigger.AutomaticDuringEvent, 041, 041, 084, 084); // Chaos Castle 4
        }

        /// <inheritdoc/>
        protected override void CreateMonsters(IContext context, GameConfiguration gameConfiguration)
        {
            {
                var monster = context.CreateNew<MonsterDefinition>();
                gameConfiguration.Monsters.Add(monster);
                monster.Number = 164;
                monster.Designation = "Chaos Castle 3";
                monster.MoveRange = 50;
                monster.AttackRange = 1;
                monster.ViewRange = 7;
                monster.MoveDelay = new TimeSpan(400 * TimeSpan.TicksPerMillisecond);
                monster.AttackDelay = new TimeSpan(2000 * TimeSpan.TicksPerMillisecond);
                monster.RespawnDelay = new TimeSpan(10 * TimeSpan.TicksPerSecond);
                monster.Attribute = 2;
                monster.NumberOfMaximumItemDrops = 1;
                new Dictionary<AttributeDefinition, float>
                {
                    { Stats.Level, 40 },
                    { Stats.MaximumHealth, 1600 },
                    { Stats.MinimumPhysBaseDmg, 132 },
                    { Stats.MaximumPhysBaseDmg, 135 },
                    { Stats.DefenseBase, 75 },
                    { Stats.AttackRatePvm, 225 },
                    { Stats.DefenseRatePvm, 60 },
                    { Stats.WindResistance, 0 },
                    { Stats.PoisonResistance, 2 },
                    { Stats.IceResistance, 2 },
                    { Stats.WaterResistance, 0 },
                    { Stats.FireResistance, 2 },
                    { Stats.LightningResistance, 2 },
                }.Select(kvp =>
                {
                    var attribute = context.CreateNew<MonsterAttribute>();
                    attribute.AttributeDefinition = gameConfiguration.Attributes.First(a => a == kvp.Key);
                    attribute.Value = kvp.Value;
                    return attribute;
                }).ToList().ForEach(monster.Attributes.Add);
            } // 164 Chaos Castle 3

            {
                var monster = context.CreateNew<MonsterDefinition>();
                gameConfiguration.Monsters.Add(monster);
                monster.Number = 165;
                monster.Designation = "Chaos Castle 4";
                monster.MoveRange = 50;
                monster.AttackRange = 6;
                monster.ViewRange = 7;
                monster.MoveDelay = new TimeSpan(400 * TimeSpan.TicksPerMillisecond);
                monster.AttackDelay = new TimeSpan(1600 * TimeSpan.TicksPerMillisecond);
                monster.RespawnDelay = new TimeSpan(10 * TimeSpan.TicksPerSecond);
                monster.Attribute = 2;
                monster.NumberOfMaximumItemDrops = 1;
                new Dictionary<AttributeDefinition, float>
                {
                    { Stats.Level, 45 },
                    { Stats.MaximumHealth, 2700 },
                    { Stats.MinimumPhysBaseDmg, 150 },
                    { Stats.MaximumPhysBaseDmg, 150 },
                    { Stats.DefenseBase, 90 },
                    { Stats.AttackRatePvm, 250 },
                    { Stats.DefenseRatePvm, 70 },
                    { Stats.WindResistance, 0 },
                    { Stats.PoisonResistance, 2 },
                    { Stats.IceResistance, 2 },
                    { Stats.WaterResistance, 0 },
                    { Stats.FireResistance, 2 },
                    { Stats.LightningResistance, 2 },
                }.Select(kvp =>
                {
                    var attribute = context.CreateNew<MonsterAttribute>();
                    attribute.AttributeDefinition = gameConfiguration.Attributes.First(a => a == kvp.Key);
                    attribute.Value = kvp.Value;
                    return attribute;
                }).ToList().ForEach(monster.Attributes.Add);
            } // 165 Chaos Castle 4
        }
    }
}
