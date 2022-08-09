using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules
{
    class Ghost
    {
        public static void Appear()
        {
            if (gwBase.ghost != null) { gwBase.ghost.Data.Visibility.SetVisibleForTime(3f); }
        }
        public static void RandomAction()
        {
            if (gwBase.ghost != null) { gwBase.ghost.Actions.Random(); }
        }

        public static int GetAge()
        {
            if (gwBase.ghost != null) { return (int)gwBase.ghost.Data.Age; }
            return 0;
        }

        public static string GetGhostType()
        {
            if (gwBase.ghost != null)
            {
                return gwBase.ghost.Data.name.Replace("(Clone)", "");
            }
            return "null";
        }

        public static void DoAttack()
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.ResetCooldowns();
                gwBase.ghost.DoCooldownAttack();
            }
        }

        public static void DoFastAttack()
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.ResetCooldowns();
                gwBase.ghost.DoCooldownFastAttack();
            }
        }

        public static void DoHunt()
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.ResetCooldowns();
                gwBase.ghost.DoCooldownHunt();
            }
        }

        public static void DoDamage()
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.ResetCooldowns();
                gwBase.ghost.DoDamage();
            }
        }

        public static void DoCapture()
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.ResetCooldowns();
                gwBase.ghost.DoCooldownCapture();
            }
        }
        public static void Teleport(Vector3 destination)
        {
            if (gwBase.ghost != null)
            {
                gwBase.ghost.Movement.Teleport(destination);
            }
        }

        public static void MakeNoise()
        {
            gwBase.ghost.Audio.PlayInteractBreath();
            gwBase.ghost.Audio.PlayWarningRunAttack();
        }
    }
}
