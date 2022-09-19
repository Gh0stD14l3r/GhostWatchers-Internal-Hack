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
    class Baby
    {
        // - Pelvis - Spine - Spine1 - Neck - Head - Mask1 - Mask2 - Mask_End - Hair1_R - Hair2_R - Hair3_R - 
        //Hair_End_R - Hair1_L - Hair2_L - Hair3_L - Hair_End_L - Calvicle_L - Arm1_L - Arm2_L_2 - Hand_L1 - Finger1_1_L - 
        //Finger1_2_L - Finger1_3_L - Finger1_End_L - Finger2_1_L - Finger2_2_L - Finger2_3_L - Finger2_End_L - Finger3_1_L - 
        //Finger3_2_L - Finger3_3_L - Finger3_End_L - Finger4_1_L - Finger4_2_L - Finger4_3_L - Finger4_End_L - Finger5_1_L - 
        //Finger5_2_L - Finger5_3_L - Finger5_End_L - Calvicle_R - Arm1_R - Arm2_R - Hand_R - Finger1_1_R - Finger1_2_R - 
        //Finger1_3_R - Finger1_End_R - Finger2_1_R - Finger2_2_R - Finger2_3_R - Finger2_End_R - Finger3_1_R - Finger3_2_R - 
        //Finger3_3_R - Finger3_End_R - Finger4_1_R - Finger4_2_R - Finger4_3_R - Finger4_End_R - Finger5_1_R - Finger5_2_R -
        //Finger5_3_R - Finger5_End_R - Leg1_L - Leg2_L - Foot_L - Toe_L - Toe_End_L - Leg1_R - Leg2_R - Foot_R - Toe_R - Toe_End_R

        private static Vector3 Head, Neck, Spine1, Spine, Pelvis;
        private static Vector3 Leg1_L, Leg2_L, Foot_L, Toe_L;
        private static Vector3 Leg1_R, Leg2_R, Foot_R, Toe_R;
        private static Vector3 Calvicle_R, Arm1_R, Arm2_R, Hand_R;
        private static Vector3 Calvicle_L, Arm1_L, Arm2_L_2, Hand_L1;

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
                if (b.name.Contains("Neck"))
                {
                    Neck = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Spine1"))
                {
                    Spine1 = Camera.main.WorldToScreenPoint(b.transform.position);
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

                if (b.name.Contains("Leg1_L"))
                {
                    Leg1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Leg2_L"))
                {
                    Leg2_L = Camera.main.WorldToScreenPoint(b.transform.position);
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

                if (b.name.Contains("Leg1_R"))
                {
                    Leg1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Leg2_R"))
                {
                    Leg2_R = Camera.main.WorldToScreenPoint(b.transform.position);
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

                if (b.name.Contains("Calvicle_R"))
                {
                    Calvicle_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm1_R"))
                {
                    Arm1_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm2_R"))
                {
                    Arm2_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_R"))
                {
                    Hand_R = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("Calvicle_L"))
                {
                    Calvicle_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm1_L"))
                {
                    Arm1_L = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Arm2_L_2"))
                {
                    Arm2_L_2 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Hand_L1"))
                {
                    Hand_L1 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

            }

            if (gchecker >= 21)
            {
                ESP.DrawBoneLine(Head, Neck, Color.red);
                ESP.DrawBoneLine(Neck, Spine1, Color.red);
                ESP.DrawBoneLine(Spine1, Spine, Color.red);
                ESP.DrawBoneLine(Spine, Pelvis, Color.red);

                ESP.DrawBoneLine(Pelvis, Leg1_L, Color.red);
                ESP.DrawBoneLine(Leg1_L, Leg2_L, Color.red);
                ESP.DrawBoneLine(Leg2_L, Foot_L, Color.red);
                ESP.DrawBoneLine(Foot_L, Toe_L, Color.red);

                ESP.DrawBoneLine(Pelvis, Leg1_R, Color.red);
                ESP.DrawBoneLine(Leg1_R, Leg2_R, Color.red);
                ESP.DrawBoneLine(Leg2_R, Foot_R, Color.red);
                ESP.DrawBoneLine(Foot_R, Toe_R, Color.red);

                ESP.DrawBoneLine(Neck, Calvicle_R, Color.red);
                ESP.DrawBoneLine(Calvicle_R, Arm1_R, Color.red);
                ESP.DrawBoneLine(Arm1_R, Arm2_R, Color.red);
                ESP.DrawBoneLine(Arm2_R, Hand_R, Color.red);

                ESP.DrawBoneLine(Neck, Calvicle_L, Color.red);
                ESP.DrawBoneLine(Calvicle_L, Arm1_L, Color.red);
                ESP.DrawBoneLine(Arm1_L, Arm2_L_2, Color.red);
                ESP.DrawBoneLine(Arm2_L_2, Hand_L1, Color.red);

            }
        }
    }
}
