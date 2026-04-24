using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Progect
{
    public class SettingsData
    {
        public int DefaultFocus { get; set; } = 60;
        public int DefaultBreak { get; set; } = 10;

        public bool DarkMode { get; set; } = false;

        public bool EnableSound { get; set; } = false;
        public bool SilentMode { get; set; } = false;
    }
}
