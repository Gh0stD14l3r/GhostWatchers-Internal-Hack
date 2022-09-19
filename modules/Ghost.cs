using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules
{
    class Ghost
    {
        public static PlayerSetup currentPlayer;
        public static void Appear()
        {
            if (gwBase.ghost != null) 
            { 
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.Data.Visibility.SetVisibleForTime(5f);
                }
            }
        }
        public static void RandomAction()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.Actions.Random();
                }
            }
        }

        public static int GetAge()
        {
            if (gwBase.ghost != null) { return (int)gwBase.ghost[0].Data.Age; }
            return 0;
        }

        public static string GetGhostType()
        {
            if (gwBase.ghost != null)
            {
                return gwBase.ghost[0].Data.name.Replace("(Clone)", "");
            }
            return "null";
        }

        public static void DoAttack()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.ResetCooldowns();
                    ghost.DoCooldownAttack();
                }
            }
        }

        public static void DoFastAttack()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.ResetCooldowns();
                    ghost.DoCooldownFastAttack();
                }
            }
        }

        public static void DoHunt()
        {
            foreach (PlayerSetup player in gwBase.network_player)
            {
                if (currentPlayer == null)
                {
                    currentPlayer = player;
                }
                else
                {
                    if (Vector3.Distance(player.transform.position, gwBase.ghost[0].transform.position) < Vector3.Distance(currentPlayer.transform.position, gwBase.ghost[0].transform.position))
                    {
                        currentPlayer = player;
                    }
                }
            }

            CaptureAttack(currentPlayer.PlayerId);
            currentPlayer = null;

        }

        public static void DoDamage()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.ResetCooldowns();
                    ghost.DoDamage();
                }
            }
        }

        public static void DoCapture()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.ResetCooldowns();
                    ghost.DoCooldownCapture();
                }
            }
        }
        public static void Teleport(Vector3 destination)
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.Movement.Teleport(destination);
                }
            }
        }

        public static void MakeNoise()
        {
            if (gwBase.ghost != null)
            {
                foreach (GhostAI ghost in gwBase.ghost)
                {
                    ghost.Audio.PlayInteractBreath();
                    ghost.Audio.PlayWarningRunAttack();
                }
            }
        }

        public static void PretendAttack(int PlayerID)
        {
            SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.StartPrepare, PlayerID));
            
            new Thread(() =>
            {
                Thread.Sleep(5000);
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.FinishPrepare, PlayerID));
            }).Start();
        }

        public static void CaptureAttack(int PlayerID)
        {
            SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.Attack, PlayerID));

            new Thread(() =>
            {
                Thread.Sleep(4000);
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.CaptureAttack, PlayerID));
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.FinishAttack, PlayerID));
                SignalSystem<GhostAttackSignal>.Pub(new GhostAttackSignal(GhostAttackSignal.AttackPhase.None, PlayerID));
            }).Start();
        }

        public static void TPGhostToPlayer(PlayerSetup Player)
        {
            foreach (GhostAI go in gwBase.ghost)
            {
                if (go.transform.position != Player.transform.position)
                {
                    go.Movement.Teleport(Player.transform.position);
                }
            }
        }
    }
}
