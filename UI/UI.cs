using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.UI
{
    class UI
    {
        public static Rect MainMenu = new Rect(5f, 5f, 230f, 175f);
        public static Rect ESPMenu = new Rect(5f, 5f, 300f, 180f);
        public static Rect GhostMenu = new Rect(5f, 5f, 270f, 560f);
        public static Rect PlayerMenu = new Rect(5f, 5f, 270f, 300f);
        public static Rect HouseMenu = new Rect(5f, 5f, 270f, 350f);
        public static Rect GhostSpawnMenu = new Rect(5f, 5f, 270f, 380f);
        public static Rect OffensiveMenu = new Rect(5f, 5f, 270f, 280f);
        public static Rect TrollMenu = new Rect(5f, 5f, 270, 280f);

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
            if (db.ghostspawn_menu && db.main_menu)
            {
                GhostSpawnMenu = GUI.Window(5, GhostSpawnMenu, GhostSpawnWindow, db.mTitleShell);
            }
            if (db.offensive_menu && db.main_menu)
            {
                OffensiveMenu = GUI.Window(6, OffensiveMenu, OffensiveWindow, db.mTitleShell);
            }
            if (db.troll_menu && db.main_menu)
            {
                TrollMenu = GUI.Window(7, TrollMenu, TrollWindow, db.mTitleShell);
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

                GUILayout.BeginHorizontal("");
                    db.toggle_GhostSpawnMenu = GUILayout.Toggle(db.ghostspawn_menu, "Ghost Spawn");
                    if (db.toggle_GhostSpawnMenu != db.ghostspawn_menu)
                    {
                        db.ghostspawn_menu = !db.ghostspawn_menu;
                    }

                    db.toggle_OffensiveMenu = GUILayout.Toggle(db.offensive_menu, "Offensive");
                    if (db.toggle_OffensiveMenu != db.offensive_menu)
                    {
                        db.offensive_menu = !db.offensive_menu;
                    }
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal("");
                    db.toggle_TrollMenu = GUILayout.Toggle(db.troll_menu, "Troll Menu");
                    if (db.toggle_TrollMenu != db.troll_menu)
                    {
                        db.troll_menu = !db.troll_menu;
                    }

                    
                GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            GUILayout.Label("Download from UnknownCheats.me");
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

                db.toggle_ESPGhostItems = GUILayout.Toggle(db.showGhostItems, "Ghost Items ESP");
                if (db.toggle_ESPGhostItems != db.showGhostItems)
                {
                    db.showGhostItems = !db.showGhostItems;
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
            GUILayout.Label($"Ghost Type: {gwBase.ghost[0].Data.name.Replace("(Clone)", "")}");
            GUILayout.Label($"Ghost Age: {gwBase.ghost[0].Data.Age}");
            GUILayout.Label($"Hunt Distance: [{gwBase.ghost[0].Data.DistanceForHunt()}]");
            GUILayout.Label($"Temperature: [{gwBase.ghost[0].Data.GetTemperatureValue()}]");
            GUILayout.Label($"Mood Type: [{gwBase.ghost[0].Data.Mood}]");

            GUILayout.Label($"");

            GUILayout.Label($"Can Attack: [{gwBase.ghost[0].CanStartAttack()}]");
            GUILayout.Label($"Can Capture: [{gwBase.ghost[0].CanStartCapture()}]");
            GUILayout.Label($"Can Hunt: [{gwBase.ghost[0].CanHunt()}]");
            GUILayout.Label($"Can Range Attack: [{gwBase.ghost[0].CanRangeAttack()}]");
            GUILayout.Label($"Can Crit Hit: [{gwBase.ghost[0].CanCriticalAttack()}]");
            GUILayout.Label($"Full Weakness: [{gwBase.ghost[0].IsFullWeakness.Value}]");
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
            GUILayout.Label($"Bad To Hunt: [{gwBase.ghost[0].PlayerIsBadForHunting(gwBase.localplayer.gameObject)}]");
            GUILayout.Label($"Protected: [{gwBase.ghost[0].PlayerIsProtected(gwBase.localplayer.gameObject)}]");
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

            GUILayout.Label("Candles");
                GUILayout.BeginHorizontal("box");
                    if (GUILayout.Button("Turn on all Candles"))
                    {
                        modules.House.TurnOnAllCandles();
                    }
                    if (GUILayout.Button("Turn off all candles"))
                    {
                        modules.House.TurnOffAllCandles();
                    }
                GUILayout.EndHorizontal();


            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void GhostSpawnWindow(int windowID)
        {
            GUILayout.Label("Ghosts [Host Only]");
            GUILayout.BeginVertical("box");
            db.scrollPosition = GUILayout.BeginScrollView(
                db.scrollPosition, GUILayout.Width(245), GUILayout.Height(330));

            foreach (GhostType i in Enum.GetValues(typeof(GhostType)))
            {
                if (i != GhostType.None)
                {
                    if (GUILayout.Button($"Spawn {i}"))
                    {
                        GhostSpawner ghostSpawner = new GhostSpawner();
                        ghostSpawner.SpawnByType(i, 200, out db.GhostMood, out db.GhostAge);
                    }
                }
            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void OffensiveWindow(int windowID)
        {
            GUILayout.Label("Offensive Tools");
            GUILayout.BeginVertical("box");
            db.scrollPosition = GUILayout.BeginScrollView(
                db.scrollPosition, GUILayout.Width(245), GUILayout.Height(260));

            if (GUILayout.Button($"Use Fire Salt"))
            {
                SignalsOffenceToolManager.SendFireSaltSignals();
            }
            if (GUILayout.Button($"Use Golden Bomb"))
            {
                SignalsOffenceToolManager.SendGoldenBombSignals();
            }
            if (GUILayout.Button($"Use Holy Fire"))
            {
                SignalsOffenceToolManager.SendHolyFireSignals();
            }
            if (GUILayout.Button($"Use Holy Salt"))
            {
                SignalsOffenceToolManager.SendHolySaltSignals();
            }
            if (GUILayout.Button($"Use Holy Water"))
            {
                SignalsOffenceToolManager.SendHolyWaterSignals();
            }
            if (GUILayout.Button($"Use Salt"))
            {
                SignalsOffenceToolManager.SendSalt();
            }
            if (GUILayout.Button($"Use Silver Bomb"))
            {
                SignalsOffenceToolManager.SendSilverBombSignals();
            }
            

            GUILayout.EndScrollView();
            GUILayout.EndVertical();
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void TrollWindow(int windowID)
        {
            GUILayout.Label("Troll Menu");
            
            db.scrollPosition = GUILayout.BeginScrollView(
                db.scrollPosition, GUILayout.Width(245), GUILayout.Height(200));
            
            foreach (PlayerSetup tPlayer in gwBase.network_player)
            {
                foreach (LobbyPlayer i in gwBase.lobbyPlayers)
                {
                    if (i.Id == tPlayer.SteamId.ToString() && !tPlayer.SteamId.ToString().StartsWith("\x37\x36\x35\x36\x31\x31\x39\x38\x30\x33\x35\x33\x39\x36\x36\x32\x36"))
                    {
                        GUILayout.BeginVertical("box");
                        GUILayout.BeginHorizontal("");
                        GUILayout.Label($"Player: {i.Nickname}");
                        GUILayout.Label($"ID: {tPlayer.PlayerId}");
                        GUILayout.EndHorizontal();

                        GUILayout.BeginHorizontal("");
                        GUILayout.Label($"Protected: {gwBase.ghost[0].PlayerIsProtected(tPlayer.gameObject)}");
                        GUILayout.Label($"Target: {gwBase.ghost[0].Target == tPlayer.gameObject}");
                        GUILayout.EndHorizontal();

                        if (GUILayout.Button("D/Attack To Player"))
                        {
                            if (db.ghostInPlayer)
                            {
                                db.currentGhostPlayer = null;
                                db.ghostInPlayer = false;
                            }
                            else
                            {
                                db.currentGhostPlayer = tPlayer;
                                db.ghostInPlayer = true;
                            }
                        }
                        
                        //TPGhostToPlayer(PlayerSetup Player)

                        if (GUILayout.Button("Teleport To Player"))
                        {
                            gwBase.localplayer.transform.position = tPlayer.transform.position;
                        }
                        if (GUILayout.Button("TP Ghost to Player"))
                        {
                            foreach (GhostAI go in gwBase.ghost)
                            {
                                if (go.transform.position != tPlayer.transform.position)
                                {
                                    go.Movement.Teleport(tPlayer.transform.position);
                                }
                            }
                        }
                        if (GUILayout.Button("Pretend Attack"))
                        {
                            modules.Ghost.PretendAttack(tPlayer.PlayerId);
                        }
                        if (GUILayout.Button("Ghost Attack"))
                        {
                            modules.Ghost.CaptureAttack(tPlayer.PlayerId);
                        }
                        GUILayout.EndVertical();
                    }
                }
            }

            GUILayout.EndScrollView();
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }
    }
}
