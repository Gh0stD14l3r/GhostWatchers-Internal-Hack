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
            if (Input.GetKey(KeyCode.Keypad1))
            {
                modules.House.OpenAllFaucets();
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
