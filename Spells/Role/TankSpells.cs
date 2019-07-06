﻿namespace ShinraCo.Spells.Role
{
    public class TankSpells
    {
        public Spell Rampart { get; } = new Spell
        {
            Name = "Rampart",
            ID = 7531,
            Level = 8,
            GCDType = GCDType.Off,
            SpellType = SpellType.Buff,
            CastType = CastType.Self
        };

        public Spell LowBlow { get; } = new Spell
        {
            Name = "Low Blow",
            ID = 7540,
            Level = 12,
            GCDType = GCDType.Off,
            SpellType = SpellType.Cooldown,
            CastType = CastType.Target
        };

        public Spell Provoke { get; } = new Spell
        {
            Name = "Provoke",
            ID = 7533,
            Level = 15,
            GCDType = GCDType.Off,
            SpellType = SpellType.Cooldown,
            CastType = CastType.Target
        };
        public Spell Interject { get; } = new Spell
        {
            Name = "Interject",
            ID = 7538,
            Level = 18,
            GCDType = GCDType.Off,
            SpellType = SpellType.Cooldown,
            CastType = CastType.Target
        };

        public Spell Reprisal { get; } = new Spell
        {
            Name = "Reprisal",
            ID = 7535,
            Level = 22,
            GCDType = GCDType.Off,
            SpellType = SpellType.Cooldown,
            CastType = CastType.Target
        };

        /*
        public Spell Awareness { get; } = new Spell
        {
            Name = "Awareness",
            ID = 7534,
            Level = 36,
            GCDType = GCDType.Off,
            SpellType = SpellType.Buff,
            CastType = CastType.Self
        };*/


        public Spell ArmsLength { get; } = new Spell
        {
            Name = "Arm's Length",
            ID = 7548,
            Level = 24,
            GCDType = GCDType.Off,
            SpellType = SpellType.Buff,
            CastType = CastType.Self
        };

        public Spell Anticipation { get; } = new Spell
        {
            Name = "Anticipation",
            ID = 7536,
            Level = 24,
            GCDType = GCDType.Off,
            SpellType = SpellType.Buff,
            CastType = CastType.Self,
        };

        /*
        public Spell Ultimatum { get; } = new Spell
        {
            Name = "Ultimatum",
            ID = 7539,
            Level = 44,
            GCDType = GCDType.Off,
            SpellType = SpellType.AoE,
            CastType = CastType.Self
        };*/

        public Spell Shirk { get; } = new Spell
        {
            Name = "Shirk",
            ID = 7537,
            Level = 48,
            GCDType = GCDType.Off,
            SpellType = SpellType.Buff,
            CastType = CastType.Target
        };
    }
}
 