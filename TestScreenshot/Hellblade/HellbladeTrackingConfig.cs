﻿
using System.Drawing;

namespace HellbladeSaver
{
    public class HellbladeTrackingConfig
    {
        public string SaveGamePath { get; set; }
        public string SaveGameFilter { get; set; }

        public string SaveBackupPath { get; set; }
        public string DefaultNameFormat { get; set; }

        public string HellbladeExecutablePath { get; set; }
        public Size? TargetImageSize { get; internal set; }
    }
}
