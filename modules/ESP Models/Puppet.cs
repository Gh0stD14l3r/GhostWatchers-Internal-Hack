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
    class Puppet
    {
        // - Billy_Hips - Billy_Spine - Billy_Spine1 - Billy_Spine2 - Billy_Neck - Billy_Head - 
        //Billy_HeadTop_End - Billy_LeftEye - Billy_RightEye - Jaw - Jaw_End - Billy_LeftShoulder -
        //Billy_LeftArm - Billy_LeftForeArm - Billy_LeftHand - Billy_LeftHandMiddle1 - Billy_LeftHandMiddle2 - 
        //Billy_LeftHandMiddle3 - Billy_LeftHandMiddle4 - Billy_LeftHandThumb1 - Billy_LeftHandThumb2 - 
        //Billy_LeftHandThumb3 - Billy_LeftHandThumb4 - Billy_LeftHandIndex1 - Billy_LeftHandIndex2 - 
        //Billy_LeftHandIndex3 - Billy_LeftHandIndex4 - Billy_LeftHandRing1 - Billy_LeftHandRing2 - 
        //Billy_LeftHandRing3 - Billy_LeftHandRing4 - Billy_LeftHandPinky1 - Billy_LeftHandPinky2 - 
        //Billy_LeftHandPinky3 - Billy_LeftHandPinky4 - Billy_RightShoulder - Billy_RightArm - Billy_RightForeArm -
        //Billy_RightHand - Billy_RightHandMiddle1 - Billy_RightHandMiddle2 - Billy_RightHandMiddle3 - 
        //Billy_RightHandMiddle4 - Billy_RightHandThumb1 - Billy_RightHandThumb2 - Billy_RightHandThumb3 - 
        //Billy_RightHandThumb4 - Billy_RightHandIndex1 - Billy_RightHandIndex2 - Billy_RightHandIndex3 - 
        //Billy_RightHandIndex4 - Billy_RightHandRing1 - Billy_RightHandRing2 - Billy_RightHandRing3 - 
        //Billy_RightHandRing4 - Billy_RightHandPinky1 - Billy_RightHandPinky2 - Billy_RightHandPinky3 - 
        //Billy_RightHandPinky4 - Billy_LeftUpLeg - Billy_LeftLeg - Billy_LeftFoot - Billy_LeftToeBase - 
        //Billy_LeftToe_End - Billy_RightUpLeg - Billy_RightLeg - Billy_RightFoot - Billy_RightToeBase - Billy_RightToe_End

        private static Vector3 Billy_Head, Billy_Neck, Billy_Spine, Billy_Hips;
        private static Vector3 Billy_LeftShoulder, Billy_LeftArm, Billy_LeftForeArm, Billy_LeftHand;
        private static Vector3 Billy_RightShoulder, Billy_RightArm, Billy_RightForeArm, Billy_RightHand;
        private static Vector3 Billy_LeftUpLeg, Billy_LeftLeg, Billy_LeftFoot;
        private static Vector3 Billy_RightUpLeg, Billy_RightLeg, Billy_RightFoot;

        public static void show_bones(GhostAI xghost) //works
        {
            int gchecker = 0;
            Transform[] ghostBones = xghost.GetComponentInParent<Donteco.Ghost>().GetComponentInChildren<SkinnedMeshRenderer>().bones;
            foreach (Transform b in ghostBones)
            {
                if (b.name.Contains("Billy_Head"))
                {
                    Billy_Head = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_Neck"))
                {
                    Billy_Neck = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_Spine"))
                {
                    Billy_Spine = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_Hips"))
                {
                    Billy_Hips = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftShoulder"))
                {
                    Billy_LeftShoulder = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftArm"))
                {
                    Billy_LeftArm = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftForeArm"))
                {
                    Billy_LeftForeArm = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftHand"))
                {
                    Billy_LeftHand = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightShoulder"))
                {
                    Billy_RightShoulder = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightArm"))
                {
                    Billy_RightArm = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightForeArm"))
                {
                    Billy_RightForeArm = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightHand"))
                {
                    Billy_RightHand = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftUpLeg"))
                {
                    Billy_LeftUpLeg = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftLeg"))
                {
                    Billy_LeftLeg = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_LeftFoot"))
                {
                    Billy_LeftFoot = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightUpLeg"))
                {
                    Billy_RightUpLeg = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightLeg"))
                {
                    Billy_RightLeg = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }
                if (b.name.Contains("Billy_RightFoot"))
                {
                    Billy_RightFoot = Camera.main.WorldToScreenPoint(b.transform.position);
                    gchecker++;
                }

            }

            if (gchecker >= 18)
            {
                ESP.DrawBoneLine(Billy_Head, Billy_Neck, Color.red);
                ESP.DrawBoneLine(Billy_Neck, Billy_Spine, Color.red);
                ESP.DrawBoneLine(Billy_Spine, Billy_Hips, Color.red);

                ESP.DrawBoneLine(Billy_Neck, Billy_LeftShoulder, Color.red);
                ESP.DrawBoneLine(Billy_LeftShoulder, Billy_LeftArm, Color.red);
                ESP.DrawBoneLine(Billy_LeftArm, Billy_LeftForeArm, Color.red);
                ESP.DrawBoneLine(Billy_LeftForeArm, Billy_LeftHand, Color.red);

                ESP.DrawBoneLine(Billy_Neck, Billy_RightShoulder, Color.red);
                ESP.DrawBoneLine(Billy_RightShoulder, Billy_RightArm, Color.red);
                ESP.DrawBoneLine(Billy_RightArm, Billy_RightForeArm, Color.red);
                ESP.DrawBoneLine(Billy_RightForeArm, Billy_RightHand, Color.red);

                ESP.DrawBoneLine(Billy_Hips, Billy_LeftUpLeg, Color.red);
                ESP.DrawBoneLine(Billy_LeftUpLeg, Billy_LeftLeg, Color.red);
                ESP.DrawBoneLine(Billy_LeftLeg, Billy_LeftFoot, Color.red);

                ESP.DrawBoneLine(Billy_Hips, Billy_RightUpLeg, Color.red);
                ESP.DrawBoneLine(Billy_RightUpLeg, Billy_RightLeg, Color.red);
                ESP.DrawBoneLine(Billy_RightLeg, Billy_RightFoot, Color.red);

            }
        }
    }
}
