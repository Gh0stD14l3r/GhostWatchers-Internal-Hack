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
    class Poltergeist
    {
        //- Root - Pelvis - Spine_1 - Spine_2 - Chest - Neck - Head - Head_End - 
        //Clavicle_L - Arm_1_L - Arm_2_L - Hand_L - Thumb_1_L - Thumb_2_L - 
        //Thumb_End_L - Index_1_L - Index_2_L - Index_3_L - Index_End_L - Middle_1_L - 
        //Middle_2_L - Middle_3_L - Middle_End_L - Noname_1_L - Noname_2_L - Noname_3_L - 
        //Noname_End_L - Little_1_L - Little_2_L - Little_3_L - Little_End_L - Clavicle_R - 
        //Arm_1_R - Arm_2_R - Hand_R - Thumb_1_R - Thumb_2_R - Thumb_End_R - Index_1_R - 
        //Index_2_R - Index_3_R - Index_End_R - Middle_1_R - Middle_2_R - Middle_3_R - 
        //Middle_End_R - Noname_1_R - Noname_2_R - Noname_3_R - Noname_End_R - Little_1_R - 
        //Little_2_R - Little_3_R - Little_End_R - Cape_Root - Cape_F_1_L - Cape_F_2_L - 
        //Cape_F_3_L - Cape_F_4_L - Cape_F_5_L - Cape_F_6_L - Cape_B_1_L - Cape_B_2_L - 
        //Cape_B_3_L - Cape_Mid_1 - Cape_Mid_2 - Cape_Mid_3 - Cape_Mid_4 - Cape_F_1_R - 
        //Cape_F_2_R - Cape_F_3_R - Cape_F_4_R - Cape_F_5_R - Cape_F_6_R - Cape_B_1_R - 
        //Cape_B_2_R - Cape_B_3_R - Leg_1_L - Leg_2_L - Ankle_1_L - Heel_L - Toe_1_L - 
        //Toe_End_L - Leg_1_R - Leg_2_R - Ankle_1_R - Heel_R - Toe_1_R - Toe_End_R

        private static Vector3 Head_End, Head, Neck, Chest, Spine_2, Spine_1;
        private static Vector3 Leg_1_L, Leg_2_L,  Heel_L;
        private static Vector3 Leg_1_R, Leg_2_R, Heel_R;
        private static Vector3 Clavicle_L, Arm_1_L, Arm_2_L, Hand_L;
        private static Vector3 Clavicle_R, Arm_1_R, Arm_2_R, Hand_R;

        public static void show_bones(GhostAI xghost) //works
        {
            int gchecker = 0;
            Transform[] ghostBones = xghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
            foreach (Transform b in ghostBones)
            {
                if (b.name.Contains("Head_End"))
                {
                    Head_End = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Head"))
                {
                    Head = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Neck"))
                {
                    Neck = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Chest"))
                {
                    Chest = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine_2"))
                {
                    Spine_2 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine_1"))
                {
                    Spine_1 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Leg_1_L"))
                {
                    Leg_1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Leg_2_L"))
                {
                    Leg_2_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Heel_L"))
                {
                    Heel_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Leg_1_R"))
                {
                    Leg_1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Leg_2_R"))
                {
                    Leg_2_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Heel_R"))
                {
                    Heel_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Clavicle_L"))
                {
                    Clavicle_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_1_L"))
                {
                    Arm_1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_2_L"))
                {
                    Arm_2_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_L"))
                {
                    Hand_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Clavicle_R"))
                {
                    Clavicle_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_1_R"))
                {
                    Arm_1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_2_R"))
                {
                    Arm_2_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_R"))
                {
                    Hand_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

            }

            if (gchecker >= 20)
            {
                ESP.DrawBoneLine(Head_End, Head, Color.red);
                ESP.DrawBoneLine(Head, Neck, Color.red);
                ESP.DrawBoneLine(Neck, Chest, Color.red);
                ESP.DrawBoneLine(Chest, Spine_2, Color.red);
                ESP.DrawBoneLine(Spine_2, Spine_1, Color.red);

                ESP.DrawBoneLine(Spine_1, Leg_1_L, Color.red);
                ESP.DrawBoneLine(Leg_1_L, Leg_2_L, Color.red);
                ESP.DrawBoneLine(Leg_2_L, Heel_L, Color.red);

                ESP.DrawBoneLine(Spine_1, Leg_1_R, Color.red);
                ESP.DrawBoneLine(Leg_1_R, Leg_2_R, Color.red);
                ESP.DrawBoneLine(Leg_2_R, Heel_R, Color.red);

                ESP.DrawBoneLine(Neck, Clavicle_L, Color.red);
                ESP.DrawBoneLine(Clavicle_L, Arm_1_L, Color.red);
                ESP.DrawBoneLine(Arm_1_L, Arm_2_L, Color.red);
                ESP.DrawBoneLine(Arm_2_L, Hand_L, Color.red);

                ESP.DrawBoneLine(Neck, Clavicle_R, Color.red);
                ESP.DrawBoneLine(Clavicle_R, Arm_1_R, Color.red);
                ESP.DrawBoneLine(Arm_1_R, Arm_2_R, Color.red);
                ESP.DrawBoneLine(Arm_2_R, Hand_R, Color.red);

            }
        }
    }
}
