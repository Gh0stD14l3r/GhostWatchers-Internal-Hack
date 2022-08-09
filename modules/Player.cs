using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;
using MhNetworking;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules
{
    class Player
    {
        public static void GiveMoneyAndExp(int money, int exp)
        {
            if (gwBase.wallet != null)
            {
                gwBase.wallet.AddMoneyAndExp(money, exp);
            }
        }

        public static void UnlockAllAchievements()
        {
            foreach (Donteco.AchievementType a in Enum.GetValues(typeof(Donteco.AchievementType)))
            {
                Donteco.AchievementsManager.IncrementAchievementValue(a);
            }
        }

        public static void TpOnKey()
        {
            //Code from HoppersButPC
            float TeleportDistance = 0.3f;
            GameObject gameObject = Donteco.GameConsole.CommandUtils.FindLocalPlayer();
            gameObject.GetComponent<Donteco.PlayerMovementController>().Warp(gameObject.transform.position + Donteco.MainCameraCached.Current.transform.forward * TeleportDistance);
        }

        public static void SetMasterClient()
        {
            GameObject localPlayer = Donteco.GameConsole.CommandUtils.FindLocalPlayer();
            CommonMsg.SetMasterClient setMasterClient = new CommonMsg.SetMasterClient();
            setMasterClient.ObjectId = -1;
            setMasterClient.NewMasterId = localPlayer.GetComponent<NetIdentity>().PlayerId;
            NetworkManager.Send((Message)setMasterClient);
        }
        
    }
}
