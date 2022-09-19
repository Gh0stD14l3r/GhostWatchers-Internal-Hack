using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Donteco;
using UnityEngine;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules.ESP_Models
{
    class Demon
    {
        // - Root_M - Spine1_M - Spine2_M - Chest_M - Neck_M - Head_M - HeadEnd_M - Jaw_M - 
        //JawEnd_M - Scapula_R - Shoulder_R - ShoulderPart1_R - Elbow_R - ElbowPart1_R - 
        //Wrist_R - MiddleFinger1_R - MiddleFinger2_R - MiddleFinger3_R - MiddleFinger4_R - 
        //ThumbFinger1_R - ThumbFinger2_R - ThumbFinger3_R - ThumbFinger4_R - IndexFinger1_R - 
        //IndexFinger2_R - IndexFinger3_R - IndexFinger4_R - RingFinger1_R - RingFinger2_R - 
        //RingFinger3_R - RingFinger4_R - PinkyFinger1_R - PinkyFinger2_R - PinkyFinger3_R - 
        //PinkyFinger4_R - Scapula_L - Shoulder_L - ShoulderPart1_L - Elbow_L - ElbowPart1_L - 
        //Wrist_L - MiddleFinger1_L - MiddleFinger2_L - MiddleFinger3_L - MiddleFinger4_L - 
        //ThumbFinger1_L - ThumbFinger2_L - ThumbFinger3_L - ThumbFinger4_L - IndexFinger1_L - 
        //IndexFinger2_L - IndexFinger3_L - IndexFinger4_L - RingFinger1_L - RingFinger2_L - 
        //RingFinger3_L - RingFinger4_L - PinkyFinger1_L - PinkyFinger2_L - PinkyFinger3_L - 
        //PinkyFinger4_L - Hip_R - HipPart1_R - Knee_R - KneePart1_R - Ankle_R - Hip_L - 
        //HipPart1_L - Knee_L - KneePart1_L - Ankle_L

        private static Vector3 Head_M, Neck_M, Chest_M, Spine2_M, Spine1_M, Root_M;
        private static Vector3 Shoulder_R, ShoulderPart1_R, Elbow_R, ElbowPart1_R, Wrist_R;
        private static Vector3 Shoulder_L, ShoulderPart1_L, Elbow_L, ElbowPart1_L, Wrist_L;
        private static Vector3 Hip_R, HipPart1_R, Knee_R, KneePart1_R, Ankle_R;
        private static Vector3 Hip_L, HipPart1_L, Knee_L, KneePart1_L, Ankle_L;

        public static void show_bones(GhostAI xghost) //works
        {
            int gchecker = 0;
            Transform[] ghostBones = xghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
            foreach (Transform b in ghostBones)
            {
                if (b.name.Contains("Head_M"))
                {
                    Head_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Neck_M"))
                {
                    Neck_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Chest_M"))
                {
                    Chest_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine2_M"))
                {
                    Spine2_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine1_M"))
                {
                    Spine1_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Root_M"))
                {
                    Root_M = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Shoulder_R"))
                {
                    Shoulder_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("ShoulderPart1_R"))
                {
                    ShoulderPart1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Elbow_R"))
                {
                    Elbow_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("ElbowPart1_R"))
                {
                    ElbowPart1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Wrist_R"))
                {
                    Wrist_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Shoulder_L"))
                {
                    Shoulder_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("ShoulderPart1_L"))
                {
                    ShoulderPart1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Elbow_L"))
                {
                    Elbow_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("ElbowPart1_L"))
                {
                    ElbowPart1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Wrist_L"))
                {
                    Wrist_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Hip_R"))
                {
                    Hip_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("HipPart1_R"))
                {
                    HipPart1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Knee_R"))
                {
                    Knee_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("KneePart1_R"))
                {
                    KneePart1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Ankle_R"))
                {
                    Ankle_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Hip_L"))
                {
                    Hip_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("HipPart1_L"))
                {
                    HipPart1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Knee_L"))
                {
                    Knee_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("KneePart1_L"))
                {
                    KneePart1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Ankle_L"))
                {
                    Ankle_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }


            }

            if (gchecker >= 26)
            {
                ESP.DrawBoneLine(Head_M, Neck_M, Color.red);
                ESP.DrawBoneLine(Neck_M, Chest_M, Color.red);
                ESP.DrawBoneLine(Chest_M, Spine2_M, Color.red);
                ESP.DrawBoneLine(Spine2_M, Spine1_M, Color.red);
                ESP.DrawBoneLine(Spine1_M, Root_M, Color.red);

                ESP.DrawBoneLine(Neck_M, Shoulder_R, Color.red);
                ESP.DrawBoneLine(Shoulder_R, ShoulderPart1_R, Color.red);
                ESP.DrawBoneLine(ShoulderPart1_R, Elbow_R, Color.red);
                ESP.DrawBoneLine(Elbow_R, ElbowPart1_R, Color.red);
                ESP.DrawBoneLine(ElbowPart1_R, Wrist_R, Color.red);

                ESP.DrawBoneLine(Neck_M, Shoulder_L, Color.red);
                ESP.DrawBoneLine(Shoulder_L, ShoulderPart1_L, Color.red);
                ESP.DrawBoneLine(ShoulderPart1_L, Elbow_L, Color.red);
                ESP.DrawBoneLine(Elbow_L, ElbowPart1_L, Color.red);
                ESP.DrawBoneLine(ElbowPart1_L, Wrist_L, Color.red);

                ESP.DrawBoneLine(Root_M, Hip_R, Color.red);
                ESP.DrawBoneLine(Hip_R, HipPart1_R, Color.red);
                ESP.DrawBoneLine(HipPart1_R, Knee_R, Color.red);
                ESP.DrawBoneLine(Knee_R, KneePart1_R, Color.red);
                ESP.DrawBoneLine(KneePart1_R, Ankle_R, Color.red);

                ESP.DrawBoneLine(Root_M, Hip_L, Color.red);
                ESP.DrawBoneLine(Hip_L, HipPart1_L, Color.red);
                ESP.DrawBoneLine(HipPart1_L, Knee_L, Color.red);
                ESP.DrawBoneLine(Knee_L, KneePart1_L, Color.red);
                ESP.DrawBoneLine(KneePart1_L, Ankle_L, Color.red);

            }
        }
    }
}
