using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

namespace GhostWatchers.objects
{
    class gwObjects
    {
        public static GhostAI ghost;
        public static List<PlayerSetup> network_player;
        public static PlayerSetup localplayer;
        public static PlayerWallet wallet;
        public static LobbyManager lobbyManager;
        public static Lobby lobby;
        public static List<LobbyPlayer> lobbyPlayers;
        public static FlashlightController flashlight;
        public static List<OpenableObjectController> doors;
        public static List<LightSwitcherController> lights;
        public static List<ChildrenToyController> item;
        public static List<WaterFaucetController> faucets;
        public static List<Footprint> footprints;
        public static AreaNode areaNode;

        public static void gwUpdater()
        {
            areaNode = UnityEngine.GameObject.FindObjectOfType<AreaNode>();
            ghost = UnityEngine.GameObject.FindObjectOfType<GhostAI>();
            network_player = UnityEngine.GameObject.FindObjectsOfType<PlayerSetup>().ToList();
            flashlight = UnityEngine.GameObject.FindObjectOfType<FlashlightController>();
            wallet = UnityEngine.GameObject.FindObjectOfType<PlayerWallet>();
            doors = UnityEngine.GameObject.FindObjectsOfType<OpenableObjectController>().ToList();
            lights = UnityEngine.GameObject.FindObjectsOfType<LightSwitcherController>().ToList();
            item = UnityEngine.GameObject.FindObjectsOfType<ChildrenToyController>().ToList();
            faucets = UnityEngine.GameObject.FindObjectsOfType<WaterFaucetController>().ToList();
            footprints = UnityEngine.GameObject.FindObjectsOfType<Footprint>().ToList();

            lobbyManager = LobbyManager.Instance;
            lobby = LobbyManager.Current;
            lobbyPlayers = lobby.Players.Values.ToList();
            
            foreach (PlayerSetup p in network_player)
            {
                if (p.IsLocalPlayer)
                {
                    localplayer = p;
                }   
            }
        }

        public static void gwNull()
        {
            ghost = null;
            network_player = null;
            flashlight = null;
            wallet = null;
            doors = null;
            item = null;


            lobbyManager = LobbyManager.Instance;
            lobby = LobbyManager.Current;
            lobbyPlayers = lobby.Players.Values.ToList();

            foreach (PlayerSetup p in network_player)
            {
                if (p.IsLocalPlayer)
                {
                    localplayer = p;
                }
            }
        }
    }
}
