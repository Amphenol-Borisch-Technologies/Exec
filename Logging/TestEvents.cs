using System;
using System.Collections.Generic;
using System.Drawing;

namespace ABT.Test.Exec.Logging {
    public static class TestEvents {
        public const String CANCEL = "CANCEL";
        public const String EMERGENCY_STOP = "EMERGENCY STOP";
        public const String ERROR = "ERROR";
        public const String FAIL = "FAIL";
        public const String PASS = "PASS";
        public const String UNSET = "UNSET";

        public static Color GetColor(String Event) {
            Dictionary<String, Color> codesToColors = new Dictionary<String, Color>() {
                { CANCEL, Color.Yellow },
                { EMERGENCY_STOP, Color.Firebrick },
                { ERROR, Color.Aqua },
                { FAIL, Color.Red },
                { PASS, Color.Green },
                { UNSET, Color.Gray }
            };
            return codesToColors[Event];
        }
    }
}
