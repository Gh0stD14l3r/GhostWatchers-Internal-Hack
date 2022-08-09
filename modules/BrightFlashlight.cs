using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules
{
    class BrightFlashlight
    {
        public static void activate()
        {
            if (db.usingBrightLight && gwBase.flashlight != null)
            {
                gwBase.flashlight.AmbientLight.intensity = db.lightIntensity;
                gwBase.flashlight.AmbientLight.range = db.lightIntensity;
            }

            if (db.usingBrightLight && gwBase.lights != null)
            {
                foreach (LightSwitcherController light in gwBase.lights)
                {
                    if (light != null)
                    {
                        if (light.IsOn.Value)
                        {
                            foreach (UnityEngine.Light i in light.LightSources.ToList())
                            {
                                i.intensity = db.lightIntensity;
                            }
                        }
                    }
                }
            }
        }
    }
}
