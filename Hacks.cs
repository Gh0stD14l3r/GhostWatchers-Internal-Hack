using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using System.Linq;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers
{
    class Hacks : MonoBehaviour
    {
        public static Camera MainCamera = null;
        public static float Timer = 3f;
        public static string level = "null";
        public void Start()
        {
            
        }

        public void Update()
        {
            SignalSystem<GameLevelLoadedSignal>.Sub(new SignalHandler<GameLevelLoadedSignal>(this.OnGameLevelLoadedSignalHandler));

            if (Input.GetKeyDown(KeyCode.End)) 
            {
                Loader.unload();
            }
            if (Input.GetKeyDown(KeyCode.Insert)) 
            {
                db.main_menu = !db.main_menu;
            }
            if (Input.GetKey(KeyCode.W) && db.noClip) 
            {
                modules.Player.TpOnKey();
            }
            
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.StartPrepare, gwBase.network_player[0].PlayerId));
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.FinishPrepare, gwBase.network_player[0].PlayerId));
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.Attack, gwBase.network_player[0].PlayerId));
            }

            Timer += Time.deltaTime; 
            if (Timer >= 5f) 
            {
                Timer = 0f;

                MainCamera = Camera.main;
                gwBase.gwUpdater();
            }



            if (level == Levels.Menu.ToString() || level == Levels.Lobby.ToString())
            {
                db.house_menu = false;
                db.ghost_menu = false;
                db.player_menu = false;
                db.offensive_menu = false;
                db.esp_menu = false;
                db.ghostspawn_menu = false;
                db.troll_menu = false;

                db.toggle_ESPMenu = false;
                db.toggle_GhostMenu = false;
                db.toggle_GhostSpawnMenu = false;
                db.toggle_HouseMenu = false;
                db.toggle_OffensiveMenu = false;
                db.toggle_PlayerMenu = false;
                db.toggle_TrollMenu = false;
            }
            processModules();
        }

        public void OnGUI()
        {
            UI.UI.displayUI();
            modules.ESP.show_esp();

            GUI.color = utils.NuColor.Multicolor();
            GUI.Label(new Rect(((float)Screen.width / 2) - 100, 0, (float)Screen.width, (float)Screen.height), "\x43\x72\x65\x61\x74\x65\x64\x20\x62\x79\x20\x47\x48\x30\x53\x54\x44\x31\x34\x4c\x33\x52\x20\x2d\x20\x41\x76\x61\x69\x6c\x61\x62\x6c\x65\x20\x6f\x6e\x20\x55\x6e\x6b\x6e\x6f\x77\x6e\x63\x68\x65\x61\x74\x73\x2e\x6d\x65");
            GUI.color = Color.white;
            
        }

        private static void processModules()
        {
            modules.BrightFlashlight.activate();

            if (db.ghostInMe)
            {
                foreach (GhostAI go in gwBase.ghost)
                {
                    if (go.transform.position != gwBase.localplayer.transform.position)
                    {
                        go.Movement.Teleport(gwBase.localplayer.transform.position);
                    }
                }
            }

            if (db.ghostInPlayer && db.currentGhostPlayer != null)
            {
                modules.Ghost.TPGhostToPlayer(db.currentGhostPlayer);
            }

            if (db.doorsStayOpen)
            {
                if (db.doorsStayShut)
                {
                    db.doorsStayShut = !db.doorsStayShut;
                }
                modules.House.OpenAllDoors();
            }
            
            if (db.lightsStayOn)
            {
                if (db.lightsStayOff)
                {
                    db.lightsStayOff = !db.lightsStayOff;
                }
                modules.House.TurnOnAllLights();
            }

            if (db.lightsStayOff)
            {
                if (db.lightsStayOn)
                {
                    db.lightsStayOn = !db.lightsStayOn;
                }
                modules.House.TurnOffAllLights();
            }
        }

        
        private void OnGameLevelLoadedSignalHandler(GameLevelLoadedSignal signal)
        {
            level = signal.Level.ToString();
            return;
        }
    }
}
