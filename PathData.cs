using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TTSlotMaker.Enums;

namespace TTSlotMaker
{
    public class PathData
    {
        public string Name { get; }

        public string FullPath { get; }
        
        public string FileName { get; }

        public string FileSlot { get; }

        public string FileTexType { get; }
        
        public string Path { get; }

        public int RaceCode { get; }

        public int TypeCode { get; }

        public TexType TexType { get; } = TexType.Unknown;

        public SlotType SlotType { get; } = SlotType.Ignored;

        private bool ValidRace => ValidRaceCodes.Contains(RaceCode);

        private bool ValidType => ValidTypeCodes.Contains(TypeCode);
        
        public static readonly HashSet<int> ValidRaceCodes = new()
        {
            // Hyur Midlander
            0201,
            // Hyur Highlander
            0401,
            // Au Ra
            1401,
            // Viera
            1801,
        };
        
        public static readonly HashSet<int> ValidTypeCodes = new()
        {
            // Type 1
            0001,
            // Type 1 Elder?
            0091,
            // Type 2
            0101,
            // Type 2 Elder?
            0191,
        };

        public ValidCheck IsValid { get; }

        public PathData(ModsJson modsJson)
        {
            Name = modsJson.Name;
            FullPath = modsJson.FullPath;
            Match match = ParseFullPath.Match(modsJson.FullPath);
            if (!match.Success)
            {
                IsValid = ValidCheck.FullPathRegexMismatch;
                return;
            }
            if (int.TryParse(match.Groups["race"].Value, out int raceNum)) RaceCode = raceNum;
            if (int.TryParse(match.Groups["type"].Value, out int typeNum)) TypeCode = typeNum;
            if (!ValidRace)
            {
                IsValid = ValidCheck.InvalidRace;
                return;
            }

            if (!ValidType)
            {
                IsValid = ValidCheck.InvalidType;
                return;
            }
            FileName = match.Groups["filename"].Value;
            Path = match.Groups["path"].Value;
            FileSlot = match.Groups["mid"].Value.ToLower();
            FileTexType = match.Groups["texType"].Value.ToLower();
            switch (FileTexType)
            {
                case "dif":
                case "diffuse":
                case "d":
                    TexType = TexType.Diffuse;
                    break;
                case "mask":
                case "multi":
                case "spec":
                case "specular":
                case "m":
                case "s":
                    TexType = TexType.Specular;
                    break;
                case "normal":
                case "norm":
                case "nrm":
                case "n":
                    TexType = TexType.Normal;
                    break;
                default:
                    TexType = TexType.Unknown;
                    IsValid = ValidCheck.InvalidTexType;
                    break;
            }

            if (string.IsNullOrEmpty(FileSlot))
            {
                IsValid = ValidCheck.Gen2Tex;
                return;
            }
            
            SlotType = Enum.TryParse(FileSlot, true, out SlotType slotType) ? slotType : SlotType.Ignored;
            if (SlotType == SlotType.Ignored)
            {
                IsValid = ValidCheck.InvalidSlot;
                return;
            }

            IsValid = ValidCheck.Valid;
        }

        private static readonly Regex ParseFullPath = new(@"^(?<path>chara\/human\/c(?<race>\d{4})\/obj\/body\/b(?<type>\d{4})\/texture\/)(?<filename>(?:--)?(?:v\d{2}_)?c\d{4}[bf]\d{4}_(?<mid>[^_])?_?(?<texType>[^_.]+)\.tex)$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public override string ToString() => $"{Name} : '{FullPath}'";
    }
}