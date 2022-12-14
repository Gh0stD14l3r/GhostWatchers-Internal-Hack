using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

namespace GhostWatchers.objects
{
    class vars
    {
        //Menu variables
        public static bool main_menu = true;
        public static bool esp_menu = false;
        public static bool ghost_menu = false;
        public static bool player_menu = false;
        public static bool house_menu = false;
        public static bool ghostspawn_menu = false;
        public static bool offensive_menu = false;
        public static bool troll_menu = false;

        //Menu togglestate variables
        public static bool toggle_ESPMenu = false;
        public static bool toggle_ESPGhost = false;
        public static bool toggle_ESPPlayers = false;
        public static bool toggle_ESPItems = false;
        public static bool toggle_ESPGhostItems = false;
        public static bool toggle_ESPHouse = false;
        public static bool toggle_GhostMenu = false;
        public static bool toggle_GhostInMe = false;
        public static bool toggle_useLabels = true;
        public static bool toggle_usePlayerBones = true;
        public static bool toggle_useDistance = true;
        public static bool toggle_useBoxes = true;
        public static bool toggle_PlayerMenu = false;
        public static bool toggle_HouseMenu = false;
        public static bool toggle_DoorsStayOpen = false;
        public static bool toggle_LightsStayOn = false;
        public static bool toggle_DoorsStayShut = false;
        public static bool toggle_LightsStayOff = false;
        public static bool toggle_NoClip = false;
        public static bool toggle_BrightLight = false;
        public static bool toggle_GhostSpawnMenu = false;
        public static bool toggle_OffensiveMenu = false;
        public static bool toggle_TrollMenu = false;

        //Ghost variables
        public static bool ghostInMe = false;
        public static bool ghostInPlayer = false;
        public static PlayerSetup currentGhostPlayer;

        //Player variables
        public static bool noClip = false;
        public static float lightIntensity = 50f;
        public static bool usingBrightLight = false;

        //House variables
        public static bool doorsStayOpen = false;
        public static bool lightsStayOn = false;
        public static bool doorsStayShut = false;
        public static bool lightsStayOff = false;

        //ESP variables
        public static bool showGhost = true;
        public static bool showPlayers = true;
        public static bool showItems = false;
        public static bool showGhostItems = false;
        public static bool showHouse = false;
        public static bool useLabels = true;
        public static bool usePlayerBones = true;
        public static bool useDistance = true;
        public static bool useBoxes = true;

        //Ghost Spawn variables
        public static Vector2 scrollPosition;
        public static GhostMoodType GhostMood;
        public static GhostAgeType GhostAge;

        //Strings variables
        public static string mTitleShell = "\x43\x72\x65\x61\x74\x65\x64\x20\x62\x79\x20\x47\x48\x30\x53\x54\x44\x31\x34\x4c\x33\x52";
    }
}
