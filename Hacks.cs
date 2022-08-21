using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
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
            
            Timer += Time.deltaTime; 
            if (Timer >= 5f) 
            {
                Timer = 0f;

                MainCamera = Camera.main;
                gwBase.gwUpdater();
            }

            processModules();
        }

        public void OnGUI()
        {
            UI.UI.displayUI();
            modules.ESP.show_esp();

            GUI.color = Color.magenta;
            GUI.Label(new Rect(((float)Screen.width / 2) - 100, 0, (float)Screen.width, (float)Screen.height), "\x43\x72\x65\x61\x74\x65\x64\x20\x62\x79\x20\x47\x48\x30\x53\x54\x44\x31\x34\x4c\x33\x52\x20\x2d\x20\x41\x76\x61\x69\x6c\x61\x62\x6c\x65\x20\x6f\x6e\x20\x55\x6e\x6b\x6e\x6f\x77\x6e\x63\x68\x65\x61\x74\x73\x2e\x6d\x65");
            GUI.color = Color.white;
        }

        private static void processModules()
        {
            modules.BrightFlashlight.activate();

            if (db.ghostInMe)
            {
                if (gwBase.ghost.transform.position != gwBase.localplayer.transform.position)
                {
                    gwBase.ghost.Movement.Teleport(gwBase.localplayer.transform.position);
                }
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
