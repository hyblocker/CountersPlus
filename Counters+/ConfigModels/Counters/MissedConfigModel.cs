﻿using IPA.Config.Stores.Attributes;

namespace CountersPlus.ConfigModels
{
    public class MissedConfigModel : ConfigModel
    {
        [Ignore]
        public override string DisplayName => "Missed";

        public override bool Enabled { get; set; } = true;
        [UseConverter]
        public override CounterPositions Position { get; set; } = CounterPositions.BelowCombo;
        public override int Distance { get; set; } = 0;
    }
}
