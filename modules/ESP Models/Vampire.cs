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
    class Vampire
    {
        // - Pivot - Cloth7 - Cloth8 - Cloth9 - Cloth4 - Cloth5 - Cloth6 - Cloth1 - Cloth2 - Cloth3 - 
        //Spine1 - Spine2 - Spine3 - Chest - U_ARM_R - Arm_R - Elbor_R - Hand_R - 
        //Pinky_R1 - Pinky_R2 - Pinky_R3 - Ring_R1 - Ring_R2 - Ring_R3 - 
        //Index_R1 - Index_R2 - Index_R3 - Thumb_R1 - Thumb_R2 - Thumb_R3 - 
        //Cloth_Arm5 - Cloth_Arm6 - Cloth_Arm7 - Cloth_Arm8 - 
        //Head - Hairs1 - Hairs2 - Hairs3 - Hairs4 - Hairs5 - Hairs6 - Hairs7 - Upper_Jaw - Lower_Jaw -
        //U_ARM_L - Arm_L - Elbor_L - Hand_L - Pinky_L1 - Pinky_L2 - Pinky_L3 - 
        //Ring_L1 - Ring_L2 - Ring_L3 - Index_L1 - Index_L2 - Index_L3 - Thumb_L1 - Thumb_L2 - Thumb_L3 -
        //Cloth_Arm1 - Cloth_Arm2 - Cloth_Arm3 - Cloth_Arm4
        
        private static Vector3 Head, Chest, Spine3, Spine2, Spine1, Pivot;
        private static Vector3 Cloth8, Cloth9;
        private static Vector3 Cloth5, Cloth6;
        private static Vector3 Cloth2, Cloth3;
        private static Vector3 U_ARM_R, Arm_R, Cloth_Arm5, Cloth_Arm6, Cloth_Arm7, Cloth_Arm8, Hand_R;
        private static Vector3 U_ARM_L, Arm_L, Cloth_Arm1, Cloth_Arm2, Cloth_Arm3, Cloth_Arm4, Hand_L;

        public static void show_bones(GhostAI xghost) //works
        {
            int gchecker = 0;
            Transform[] ghostBones = xghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
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
                if (b.name.Contains("Spine1"))
                {
                    Spine1 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Pivot"))
                {
                    Pivot = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth8"))
                {
                    Cloth8 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth9"))
                {
                    Cloth9 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth5"))
                {
                    Cloth5 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth6"))
                {
                    Cloth6 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth2"))
                {
                    Cloth2 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth3"))
                {
                    Cloth3 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("U_ARM_R"))
                {
                    U_ARM_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_R"))
                {
                    Arm_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm5"))
                {
                    Cloth_Arm5 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm6"))
                {
                    Cloth_Arm6 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm7"))
                {
                    Cloth_Arm7 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm8"))
                {
                    Cloth_Arm8 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_R"))
                {
                    Hand_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("U_ARM_L"))
                {
                    U_ARM_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm_L"))
                {
                    Arm_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm1"))
                {
                    Cloth_Arm1 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm2"))
                {
                    Cloth_Arm2 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm3"))
                {
                    Cloth_Arm3 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Cloth_Arm4"))
                {
                    Cloth_Arm4 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_L"))
                {
                    Hand_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

            }

            if (gchecker >= 25)
            {
                ESP.DrawBoneLine(Head, Chest, Color.red);
                ESP.DrawBoneLine(Chest, Spine3, Color.red);
                ESP.DrawBoneLine(Spine3, Spine2, Color.red);
                ESP.DrawBoneLine(Spine2, Spine1, Color.red);
                ESP.DrawBoneLine(Spine1, Pivot, Color.red);

                ESP.DrawBoneLine(Pivot, Cloth8, Color.red);
                ESP.DrawBoneLine(Cloth8, Cloth9, Color.red);

                ESP.DrawBoneLine(Pivot, Cloth5, Color.red);
                ESP.DrawBoneLine(Cloth5, Cloth6, Color.red);

                ESP.DrawBoneLine(Pivot, Cloth2, Color.red);
                ESP.DrawBoneLine(Cloth2, Cloth3, Color.red);

                ESP.DrawBoneLine(Chest, U_ARM_R, Color.red);
                ESP.DrawBoneLine(U_ARM_R, Arm_R, Color.red);
                ESP.DrawBoneLine(Arm_R, Cloth_Arm5, Color.red);
                ESP.DrawBoneLine(Cloth_Arm5, Cloth_Arm6, Color.red);
                ESP.DrawBoneLine(Cloth_Arm6, Cloth_Arm7, Color.red);
                ESP.DrawBoneLine(Cloth_Arm7, Cloth_Arm8, Color.red);
                ESP.DrawBoneLine(Cloth_Arm8, Hand_R, Color.red);

                ESP.DrawBoneLine(Chest, U_ARM_L, Color.red);
                ESP.DrawBoneLine(U_ARM_L, Arm_L, Color.red);
                ESP.DrawBoneLine(Arm_L, Cloth_Arm1, Color.red);
                ESP.DrawBoneLine(Cloth_Arm1, Cloth_Arm2, Color.red);
                ESP.DrawBoneLine(Cloth_Arm2, Cloth_Arm3, Color.red);
                ESP.DrawBoneLine(Cloth_Arm3, Cloth_Arm4, Color.red);
                ESP.DrawBoneLine(Cloth_Arm4, Hand_L, Color.red);

            }
        }
    }
}
