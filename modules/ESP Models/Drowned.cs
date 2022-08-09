using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;

using gwBase = GhostWatchers.objects.gwObjects;
using db = GhostWatchers.objects.vars;

namespace GhostWatchers.modules.ESP_Models
{
    class Drowned
    {
        // - Root - Pelvis - Spine - Spine2 - Spine3 - Chest - Head - Eye_L - Eye_L1 - Eye_R - Eye_R1 - 
        //Blink1 - Blink2 - Blink3 - Lower_Jaw - Tongue1 - Tongue2 - Tongue3 - Tongue4 - Tongue5 - Upper_Jaw - 
        //Hair - Hair1 - Hair2 - Hair3 - Hair4 - Hair5 - Hair6 - Hair7 - Hair8 - Hair9 - Hair10 - Hair11 - 
        //Hair12 - Hair13 - Hair14 - Hair15 - Hair16 - Hair17 - Hair18 - Hair19 - Hair20 - Hair21 - Hair22 - 
        //Hair23 - Hair24 - Hair25 - Hair26 - Hair27 - Hair28 - Hair29 - Hair30 - Hair31 - Hair32 - Hair33 -
        //Hair34 - Hair35 - Hair36 - Hair37 - Hair38 - Hair39 - Hair40 - Hair41 - Hair42 - Hair43 - Hair44 - 
        //Shoulder_R - Arm_R - Elbow_R - Hand_R - Thumb_R1 - Thumb_R2 - Thumb_R3 - Index_R1 - Index_R2 - 
        //Index_R3 - Middle_R1 - Middle_R2 - Middle_R3 - Ring_R1 - Ring_R2 - Ring_R3 - Pinky_R1 - Pinky_R2 - 
        //Pinky_R3 - Shoulder_L - Arm_L - Elbow_L - Hand_L - Thumb_L1 - Thumb_L2 - Thumb_L3 - Index_L1 - 
        //Index_L2 - Index_L3 - Middle_L1 - Middle_L2 - Middle_L3 - Ring_L1 - Ring_L2 - Ring_L3 - Pinky_L1 - 
        //Pinky_L2 - Pinky_L3 - Hip_R - Knee_R - Foot_R - Toe_R - Heel_R - Hip_L - Knee_L - Foot_L - Toe_L - Heel_L

        private static Vector3 Head, Chest, Spine3, Spine2, Spine, Pelvis;
        private static Vector3 Hip_R, Knee_R, Foot_R, Toe_R;
        private static Vector3 Hip_L, Knee_L, Foot_L, Toe_L;
        private static Vector3 Arm_R, Elbow_R, Hand_R;
        private static Vector3 Arm_L, Elbow_L, Hand_L;

        public static void show_bones()
        {
            int gchecker = 0;
            Transform[] ghostBones = gwBase.ghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
            foreach (Transform b in ghostBones)
            {
                if (b.name.Contains("Head"))
                {
                    Head = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Chest"))
                {
                    Chest = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine3"))
                {
                    Spine3 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine2"))
                {
                    Spine2 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine"))
                {
                    Spine = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Pelvis"))
                {
                    Pelvis = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Hip_R"))
                {
                    Hip_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Knee_R"))
                {
                    Knee_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Foot_R"))
                {
                    Foot_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Toe_R"))
                {
                    Toe_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Hip_L"))
                {
                    Hip_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Knee_L"))
                {
                    Knee_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Foot_L"))
                {
                    Foot_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Toe_L"))
                {
                    Toe_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Arm_R"))
                {
                    Arm_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Elbow_R"))
                {
                    Elbow_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_R"))
                {
                    Hand_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Arm_L"))
                {
                    Arm_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Elbow_L"))
                {
                    Elbow_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_L"))
                {
                    Hand_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

            }

            if (gchecker >= 20)
            {
                ESP.DrawBoneLine(Head, Chest, Color.red);
                ESP.DrawBoneLine(Chest, Spine3, Color.red);
                ESP.DrawBoneLine(Spine3, Spine2, Color.red);
                ESP.DrawBoneLine(Spine2, Spine, Color.red);
                ESP.DrawBoneLine(Spine, Pelvis, Color.red);

                ESP.DrawBoneLine(Pelvis, Hip_R, Color.red);
                ESP.DrawBoneLine(Hip_R, Knee_R, Color.red);
                ESP.DrawBoneLine(Knee_R, Foot_R, Color.red);
                ESP.DrawBoneLine(Foot_R, Toe_R, Color.red);

                ESP.DrawBoneLine(Pelvis, Hip_L, Color.red);
                ESP.DrawBoneLine(Hip_L, Knee_L, Color.red);
                ESP.DrawBoneLine(Knee_L, Foot_L, Color.red);
                ESP.DrawBoneLine(Foot_L, Toe_L, Color.red);

                ESP.DrawBoneLine(Chest, Arm_R, Color.red);
                ESP.DrawBoneLine(Arm_R, Elbow_R, Color.red);
                ESP.DrawBoneLine(Elbow_R, Hand_R, Color.red);

                ESP.DrawBoneLine(Chest, Arm_L, Color.red);
                ESP.DrawBoneLine(Arm_L, Elbow_L, Color.red);
                ESP.DrawBoneLine(Elbow_L, Hand_L, Color.red);

            }
        }
    }
}
