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
    class Darkness
    {
        //- CC_Base_Pelvis001 - CC_Base_R_ThighTwist003 - CC_Base_R_ThighTwist004 - CC_Base_R_CalfTwist003 - 
        //CC_Base_R_CalfTwist004 - CC_Base_R_Foot001 - CC_Base_R_RingToe002 - CC_Base_R_PinkyToe002 - 
        //CC_Base_R_MidToe002 - CC_Base_R_IndexToe002 - CC_Base_R_BigToe002 - CC_Base_R_KneeShareBone001 - 
        //CC_Base_L_ThighTwist003 - CC_Base_L_ThighTwist004 - CC_Base_L_CalfTwist003 - CC_Base_L_CalfTwist004 - 
        //CC_Base_L_Foot001 - CC_Base_L_BigToe002 - CC_Base_L_IndexToe002 - CC_Base_L_MidToe002 - CC_Base_L_PinkyToe002 - 
        //CC_Base_L_RingToe002 - CC_Base_L_KneeShareBone001 - CC_Base_Waist001 - CC_Base_Spine003 - CC_Base_Spine004 -
        //CC_Base_L_Clavicle001 - CC_Base_L_UpperarmTwist003 - CC_Base_L_UpperarmTwist004 - CC_Base_L_ForearmTwist003 - 
        //CC_Base_L_ForearmTwist004 - CC_Base_L_Hand001 - CC_Base_L_Index004 - CC_Base_L_Index005 - CC_Base_L_Index006 - 
        //CC_Base_L_Mid004 - CC_Base_L_Mid005 - CC_Base_L_Mid006 - CC_Base_L_Pinky004 - CC_Base_L_Pinky005 - CC_Base_L_Pinky006 - 
        //CC_Base_L_Ring004 - CC_Base_L_Ring005 - CC_Base_L_Ring006 - CC_Base_L_Thumb004 - CC_Base_L_Thumb005 - CC_Base_L_Thumb006 -
        //CC_Base_L_ElbowShareBone001 - CC_Base_NeckTwist003 - CC_Base_NeckTwist004 - CC_Base_Head001 - CC_Base_JawRoot001 -
        //CC_Base_Teeth005 - CC_Base_Teeth004 - CC_Base_R_Clavicle001 - CC_Base_R_UpperarmTwist003 - CC_Base_R_UpperarmTwist004 - 
        //CC_Base_R_ForearmTwist003 - CC_Base_R_ForearmTwist004 - CC_Base_R_Hand001 - CC_Base_R_Index004 - CC_Base_R_Index005 - 
        //CC_Base_R_Index006 - CC_Base_R_Mid004 - CC_Base_R_Mid005 - CC_Base_R_Mid006 - CC_Base_R_Pinky004 - CC_Base_R_Pinky005 - 
        //CC_Base_R_Pinky006 - CC_Base_R_Ring004 - CC_Base_R_Ring005 - CC_Base_R_Ring006 - CC_Base_R_Thumb004 - CC_Base_R_Thumb005 - 
        //CC_Base_R_Thumb006 - CC_Base_R_ElbowShareBone001

        private static Vector3 CC_Base_Head001, CC_Base_NeckTwist004, CC_Base_NeckTwist003, CC_Base_Spine004, CC_Base_Spine003, CC_Base_Waist001;
        private static Vector3 CC_Base_R_Clavicle001, CC_Base_R_UpperarmTwist003, CC_Base_R_UpperarmTwist004, CC_Base_R_ElbowShareBone001, CC_Base_R_ForearmTwist004, CC_Base_R_Hand001;
        private static Vector3 CC_Base_L_Clavicle001, CC_Base_L_UpperarmTwist003, CC_Base_L_UpperarmTwist004, CC_Base_L_ElbowShareBone001, CC_Base_L_ForearmTwist004, CC_Base_L_Hand001;
        private static Vector3 CC_Base_R_ThighTwist003, CC_Base_R_ThighTwist004, CC_Base_R_KneeShareBone001, CC_Base_R_CalfTwist004;
        private static Vector3 CC_Base_L_ThighTwist003, CC_Base_L_ThighTwist004, CC_Base_L_KneeShareBone001, CC_Base_L_CalfTwist004;
        
        // CC_Base_Head001, CC_Base_NeckTwist004, CC_Base_NeckTwist003, CC_Base_Spine004, CC_Base_Spine003, CC_Base_Waist001;
        // CC_Base_NeckTwist003, CC_Base_R_Clavicle001, CC_Base_R_UpperarmTwist003, CC_Base_R_UpperarmTwist004, CC_Base_R_ElbowShareBone001, CC_Base_R_ForearmTwist004, CC_Base_R_Hand001;
        // CC_Base_NeckTwist003, CC_Base_L_Clavicle001, CC_Base_L_UpperarmTwist003, CC_Base_L_UpperarmTwist004, CC_Base_L_ElbowShareBone001, CC_Base_L_ForearmTwist004, CC_Base_L_Hand001;
        // CC_Base_Waist001, CC_Base_R_ThighTwist003, CC_Base_R_ThighTwist004, CC_Base_R_KneeShareBone001, CC_Base_R_CalfTwist004;
        // CC_Base_Waist001, CC_Base_L_ThighTwist003, CC_Base_L_ThighTwist004, CC_Base_L_KneeShareBone001, CC_Base_L_CalfTwist004;

        public static void show_bones() //works
        {
            int gchecker = 0;
            Transform[] ghostBones = gwBase.ghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
            foreach (Transform b in ghostBones)
            {
                if (b.name.Contains("CC_Base_Head001"))
                {
                    CC_Base_Head001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_NeckTwist004"))
                {
                    CC_Base_NeckTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_NeckTwist003"))
                {
                    CC_Base_NeckTwist003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_Spine004"))
                {
                    CC_Base_Spine004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_Spine003"))
                {
                    CC_Base_Spine003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_Waist001"))
                {
                    CC_Base_Waist001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("CC_Base_R_Clavicle001"))
                {
                    CC_Base_R_Clavicle001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_UpperarmTwist003"))
                {
                    CC_Base_R_UpperarmTwist003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_UpperarmTwist004"))
                {
                    CC_Base_R_UpperarmTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_ElbowShareBone001"))
                {
                    CC_Base_R_ElbowShareBone001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_ForearmTwist004"))
                {
                    CC_Base_R_ForearmTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_Hand001"))
                {
                    CC_Base_R_Hand001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("CC_Base_L_Clavicle001"))
                {
                    CC_Base_L_Clavicle001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_UpperarmTwist003"))
                {
                    CC_Base_L_UpperarmTwist003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_UpperarmTwist004"))
                {
                    CC_Base_L_UpperarmTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_ElbowShareBone001"))
                {
                    CC_Base_L_ElbowShareBone001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_ForearmTwist004"))
                {
                    CC_Base_L_ForearmTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_Hand001"))
                {
                    CC_Base_L_Hand001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("CC_Base_R_ThighTwist003"))
                {
                    CC_Base_R_ThighTwist003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_ThighTwist004"))
                {
                    CC_Base_R_ThighTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_KneeShareBone001"))
                {
                    CC_Base_R_KneeShareBone001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_R_CalfTwist004"))
                {
                    CC_Base_R_CalfTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

                if (b.name.Contains("CC_Base_L_ThighTwist003"))
                {
                    CC_Base_L_ThighTwist003 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_ThighTwist004"))
                {
                    CC_Base_L_ThighTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_KneeShareBone001"))
                {
                    CC_Base_L_KneeShareBone001 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("CC_Base_L_CalfTwist004"))
                {
                    CC_Base_L_CalfTwist004 = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }


            }

            if (gchecker >= 26)
            {
                ESP.DrawBoneLine(CC_Base_Head001, CC_Base_NeckTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_NeckTwist004, CC_Base_NeckTwist003, Color.red);
                ESP.DrawBoneLine(CC_Base_NeckTwist003, CC_Base_Spine004, Color.red);
                ESP.DrawBoneLine(CC_Base_Spine004, CC_Base_Spine003, Color.red);
                ESP.DrawBoneLine(CC_Base_Spine003, CC_Base_Waist001, Color.red);

                ESP.DrawBoneLine(CC_Base_NeckTwist003, CC_Base_R_Clavicle001, Color.red);
                ESP.DrawBoneLine(CC_Base_R_Clavicle001, CC_Base_R_UpperarmTwist003, Color.red);
                ESP.DrawBoneLine(CC_Base_R_UpperarmTwist003, CC_Base_R_UpperarmTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_R_UpperarmTwist004, CC_Base_R_ElbowShareBone001, Color.red);
                ESP.DrawBoneLine(CC_Base_R_ElbowShareBone001, CC_Base_R_ForearmTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_R_ForearmTwist004, CC_Base_R_Hand001, Color.red);

                ESP.DrawBoneLine(CC_Base_NeckTwist003, CC_Base_L_Clavicle001, Color.red);
                ESP.DrawBoneLine(CC_Base_L_Clavicle001, CC_Base_L_UpperarmTwist003, Color.red);
                ESP.DrawBoneLine(CC_Base_L_UpperarmTwist003, CC_Base_L_UpperarmTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_L_UpperarmTwist004, CC_Base_L_ElbowShareBone001, Color.red);
                ESP.DrawBoneLine(CC_Base_L_ElbowShareBone001, CC_Base_L_ForearmTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_L_ForearmTwist004, CC_Base_L_Hand001, Color.red);

                ESP.DrawBoneLine(CC_Base_Waist001, CC_Base_R_ThighTwist003, Color.red);
                ESP.DrawBoneLine(CC_Base_R_ThighTwist003, CC_Base_R_ThighTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_R_ThighTwist004, CC_Base_R_KneeShareBone001, Color.red);
                ESP.DrawBoneLine(CC_Base_R_KneeShareBone001, CC_Base_R_CalfTwist004, Color.red);

                ESP.DrawBoneLine(CC_Base_Waist001, CC_Base_L_ThighTwist003, Color.red);
                ESP.DrawBoneLine(CC_Base_L_ThighTwist003, CC_Base_L_ThighTwist004, Color.red);
                ESP.DrawBoneLine(CC_Base_L_ThighTwist004, CC_Base_L_KneeShareBone001, Color.red);
                ESP.DrawBoneLine(CC_Base_L_KneeShareBone001, CC_Base_L_CalfTwist004, Color.red);

            }
        }
    }
}
