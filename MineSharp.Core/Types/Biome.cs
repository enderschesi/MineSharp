﻿using MineSharp.Core.Types.Enums;

namespace MineSharp.Core.Types
{
    public class Biome
    {

        public Biome(int id, string name, string displayName, int biomeCategory, float temperature, string precipitation, float depth, Dimension dimension, int color, float rainfall)
        {
            this.Id = id;
            this.Name = name;
            this.Category = biomeCategory;
            this.Temperature = temperature;
            this.Precipitation = precipitation;
            this.Depth = depth;
            this.Dimension = dimension;
            this.DisplayName = displayName;
            this.Color = color;
            this.Rainfall = rainfall;
        }

        public int Id { get; }
        public string Name { get; }
        public int Category { get; }
        public float Temperature { get; }
        public string Precipitation { get; }
        public float Depth { get; }
        public Dimension Dimension { get; }
        public string DisplayName { get; }
        public int Color { get; }
        public float Rainfall { get; }

        public override string ToString() => $"Biome (Name={this.Name} Id={this.Id})";
    }
}
