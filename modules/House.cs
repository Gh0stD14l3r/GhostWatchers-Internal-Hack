using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules
{
    class House
    {
        public static void OpenAllDoors()
        {
            if (gwBase.doors != null)
            {
                foreach (OpenableObjectController door in gwBase.doors)
                {
                    if (door != null && !door.IsOpened.Value)
                    {
                        door.Open(gwBase.localplayer.gameObject);
                    }
                }
            }
        }

        public static void TurnOnAllLights()
        {
            if (gwBase.lights != null)
            {
                foreach (LightSwitcherController light in gwBase.lights)
                {
                    if (light != null)
                    {
                        if (!light.IsOn.Value)
                        {
                            light.ActionsBeforeExplosion.Value = 999;
                            light.Action(gwBase.localplayer.gameObject);
                        }
                    }
                }
            }
        }

        public static void TurnOffAllLights()
        {
            if (gwBase.lights != null)
            {
                foreach (LightSwitcherController light in gwBase.lights)
                {
                    if (light != null)
                    {
                        if (light.IsOn.Value)
                        {
                            light.ActionsBeforeExplosion.Value = 999;
                            light.Action(gwBase.localplayer.gameObject);
                        }
                    }
                }
            }
        }

        public static void OpenAllFaucets()
        {
            if (gwBase.faucets != null)
            {
                foreach(WaterFaucetController faucet in gwBase.faucets)
                {
                    if (!faucet.IsOn.Value)
                    {
                        faucet.Interact(gwBase.localplayer.gameObject);
                    }
                }
            }
        }

        public static void CloseAllFaucets()
        {
            if (gwBase.faucets != null)
            {
                foreach (WaterFaucetController faucet in gwBase.faucets)
                {
                    if (faucet.IsOn.Value)
                    {
                        faucet.Interact(gwBase.localplayer.gameObject);
                    }
                }
            }
        }

    }
}
