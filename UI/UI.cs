using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.UI
{
    class UI
    {
        public static Rect MainMenu = new Rect(5f, 5f, 230f, 100f);
        public static Rect ESPMenu = new Rect(5f, 5f, 300f, 150f);
        public static Rect GhostMenu = new Rect(5f, 5f, 270f, 500f);
        public static Rect PlayerMenu = new Rect(5f, 5f, 270f, 300f);
        public static Rect HouseMenu = new Rect(5f, 5f, 270f, 350f);

        public static void displayUI()
        {
            GUI.backgroundColor = utils.NuColor.RGBtoColor(81, 81, 81);
            if (db.main_menu)
            {
                MainMenu = GUI.Window(0, MainMenu, MainWindow, db.mTitleShell);
            }
            if (db.esp_menu && db.main_menu)
            {
                ESPMenu = GUI.Window(1, ESPMenu, ESPWindow, db.mTitleShell);
            }
            if (db.ghost_menu && db.main_menu)
            {
                GhostMenu = GUI.Window(2, GhostMenu, GhostWindow, db.mTitleShell);
            }
            if (db.player_menu && db.main_menu)
            {
                PlayerMenu = GUI.Window(3, PlayerMenu, PlayerWindow, db.mTitleShell);
            }
            if (db.house_menu && db.main_menu)
            {
                HouseMenu = GUI.Window(4, HouseMenu, HouseWindow, db.mTitleShell);
            }

        }

        public static void MainWindow(int windowID)
        {
            GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal("");
                    db.toggle_ESPMenu = GUILayout.Toggle(db.esp_menu, "ESP Menu");
                    if (db.toggle_ESPMenu != db.esp_menu)
                    {
                        db.esp_menu = !db.esp_menu;
                    }

                    db.toggle_GhostMenu = GUILayout.Toggle(db.ghost_menu, "Ghost Menu");
                    if (db.toggle_GhostMenu != db.ghost_menu)
                    {
                        db.ghost_menu = !db.ghost_menu;
                    }
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal("");
                    db.toggle_PlayerMenu = GUILayout.Toggle(db.player_menu, "Player Menu");
                    if (db.toggle_PlayerMenu != db.player_menu)
                    {
                        db.player_menu = !db.player_menu;
                    }

                    db.toggle_HouseMenu = GUILayout.Toggle(db.house_menu, "House Menu");
                    if (db.toggle_HouseMenu != db.house_menu)
                    {
                        db.house_menu = !db.house_menu;
                    }
                GUILayout.EndHorizontal();
            GUILayout.EndVertical();

            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void ESPWindow(int windowID)
        {
            GUILayout.BeginHorizontal("box");
                GUILayout.BeginVertical("");
                db.toggle_ESPGhost = GUILayout.Toggle(db.showGhost, "Ghost ESP");
                if (db.toggle_ESPGhost != db.showGhost)
                {
                    db.showGhost = !db.showGhost;
                }
            
                db.toggle_ESPPlayers = GUILayout.Toggle(db.showPlayers, "Player ESP");
                if (db.toggle_ESPPlayers != db.showPlayers)
                {
                    db.showPlayers = !db.showPlayers;
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("");
                db.toggle_ESPItems = GUILayout.Toggle(db.showItems, "Item ESP");
                if (db.toggle_ESPItems != db.showItems)
                {
                    db.showItems = !db.showItems;
                }
                db.toggle_ESPHouse = GUILayout.Toggle(db.showHouse, "House ESP");
                if (db.toggle_ESPHouse != db.showHouse)
                {
                    db.showHouse = !db.showHouse;
                }
                GUILayout.EndVertical();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("box");
                GUILayout.BeginVertical("");
                db.toggle_useLabels = GUILayout.Toggle(db.useLabels, "Labels");
                if (db.toggle_useLabels != db.useLabels)
                {
                    db.useLabels = !db.useLabels;
                }

                db.toggle_usePlayerBones = GUILayout.Toggle(db.usePlayerBones, "Bones");
                if (db.toggle_usePlayerBones != db.usePlayerBones)
                {
                    db.usePlayerBones = !db.usePlayerBones;
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("");
                db.toggle_useDistance = GUILayout.Toggle(db.useDistance, "Distance");
                if (db.toggle_useDistance != db.useDistance)
                {
                    db.useDistance = !db.useDistance;
                }
                db.toggle_useBoxes = GUILayout.Toggle(db.useBoxes, "Boxes");
                if (db.toggle_useBoxes != db.useBoxes)
                {
                    db.useBoxes = !db.useBoxes;
                }
                GUILayout.EndVertical();
            GUILayout.EndHorizontal();

            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void GhostWindow(int windowID)
        {
            GUILayout.Label("Actions");
            GUILayout.BeginHorizontal("box");
                GUILayout.BeginVertical("");
                if (GUILayout.Button("Make Appear"))
                {
                    modules.Ghost.Appear();
                }
                if (GUILayout.Button("Random Action"))
                {
                    modules.Ghost.RandomAction();
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical("");
                if (GUILayout.Button("TP to Me"))
                {
                    modules.Ghost.Teleport(gwBase.localplayer.transform.position);
                }
                if (GUILayout.Button("Make Noise"))
                {
                    modules.Ghost.MakeNoise();
                }
                GUILayout.EndVertical();
            GUILayout.EndHorizontal();

            GUILayout.Label("Fun Options");
            GUILayout.BeginHorizontal("box");
                db.toggle_GhostInMe = GUILayout.Toggle(db.ghostInMe, "Ghost stays on me");
                if (db.toggle_GhostInMe != db.ghostInMe)
                {
                    db.ghostInMe = !db.ghostInMe;
                }
            GUILayout.EndHorizontal();

            GUILayout.Label("Ghost Information");
            GUILayout.BeginVertical("box");
                GUILayout.Label($"Ghost Type: {gwBase.ghost.Data.name.Replace("(Clone)", "")}");
                GUILayout.Label($"Ghost Age: {gwBase.ghost.Data.Age}");
                GUILayout.Label($"Hunt Distance: [{gwBase.ghost.Data.DistanceForHunt()}]");
                GUILayout.Label($"Temperature: [{gwBase.ghost.Data.GetTemperatureValue()}]");
                GUILayout.Label($"Mood Type: [{gwBase.ghost.Data.Mood}]");

                GUILayout.Label($"");

                GUILayout.Label($"Can Attack: [{gwBase.ghost.CanStartAttack()}]");
                GUILayout.Label($"Can Capture: [{gwBase.ghost.CanStartCapture()}]");
                GUILayout.Label($"Can Hunt: [{gwBase.ghost.CanHunt()}]");
                GUILayout.Label($"Can Range Attack: [{gwBase.ghost.CanRangeAttack()}]");
                GUILayout.Label($"Can Crit Hit: [{gwBase.ghost.CanCriticalAttack()}]");
                GUILayout.Label($"Full Weakness: [{gwBase.ghost.IsFullWeakness.Value}]");
            GUILayout.EndVertical();

            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void PlayerWindow(int windowID)
        {
            GUILayout.Label("Player Options");
            GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal("");
                    if (GUILayout.Button("Give Money & Exp"))
                    {
                        modules.Player.GiveMoneyAndExp(1000, 1000);
                    }
                    if (GUILayout.Button("Set Host"))
                    {
                        modules.Player.SetMasterClient();
                    }
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal("");
                    if (GUILayout.Button("Unlock Achievements"))
                    {
                        modules.Player.UnlockAllAchievements();
                    }
                GUILayout.EndHorizontal();
                GUILayout.BeginVertical("");
                    db.toggle_NoClip = GUILayout.Toggle(db.noClip, "Toggle Flying");
                    if (db.toggle_NoClip != db.noClip)
                    {
                        db.noClip = !db.noClip;
                    }
                    db.toggle_BrightLight = GUILayout.Toggle(db.usingBrightLight, "Toggle BrightLight");
                    if (db.toggle_BrightLight != db.usingBrightLight)
                    {
                        db.usingBrightLight = !db.usingBrightLight;
                    }

                    float brightAdjust = GUILayout.HorizontalSlider(db.lightIntensity, 50f, 9999f);
                    if (brightAdjust != db.lightIntensity)
                    {
                        db.lightIntensity = brightAdjust;
                    }

                GUILayout.EndVertical();
            GUILayout.EndVertical();

            GUILayout.Label("Player Information");
            GUILayout.BeginVertical("box");
                GUILayout.Label($"Bad To Hunt: [{gwBase.ghost.PlayerIsBadForHunting(gwBase.localplayer.gameObject)}]");
                GUILayout.Label($"Protected: [{gwBase.ghost.PlayerIsProtected(gwBase.localplayer.gameObject)}]");
            GUILayout.EndVertical();

            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void HouseWindow(int windowID)
        {
            GUILayout.Label("Doors");
            GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal("");
                    if (GUILayout.Button("Open All Doors"))
                    {
                        modules.House.OpenAllDoors();
                    }
                    
                GUILayout.EndHorizontal();
                GUILayout.BeginVertical("");
                    db.toggle_DoorsStayOpen = GUILayout.Toggle(db.doorsStayOpen, "Keep doors open");
                    if (db.toggle_DoorsStayOpen != db.doorsStayOpen)
                    {
                        db.doorsStayOpen = !db.doorsStayOpen;
                    }

                GUILayout.EndVertical();
            GUILayout.EndVertical();

            GUILayout.Label("Lights");
            GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal("");
                    if (GUILayout.Button("Turn Lights On"))
                    {
                        modules.House.TurnOnAllLights();
                    }
                    if (GUILayout.Button("Turn Lights Off"))
                    {
                        modules.House.TurnOffAllLights();
                    }
                GUILayout.EndHorizontal();
                GUILayout.BeginVertical("");
                    db.toggle_LightsStayOn = GUILayout.Toggle(db.lightsStayOn, "Lights stay on");
                    if (db.toggle_LightsStayOn != db.lightsStayOn)
                    {
                        db.lightsStayOn = !db.lightsStayOn;
                    }
                    db.toggle_LightsStayOff = GUILayout.Toggle(db.lightsStayOff, "Lights stay off");
                    if (db.toggle_LightsStayOff != db.lightsStayOff)
                    {
                        db.lightsStayOff = !db.lightsStayOff;
                    }

                GUILayout.EndVertical();
            GUILayout.EndVertical();

            GUILayout.Label("Faucets");
                GUILayout.BeginHorizontal("box");
                    if (GUILayout.Button("Open All Faucets"))
                    {
                        modules.House.OpenAllFaucets();
                    }
                    if (GUILayout.Button("Close All Faucets"))
                    {
                        modules.House.CloseAllFaucets();
                    }
                GUILayout.EndHorizontal();
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        
    }
}
