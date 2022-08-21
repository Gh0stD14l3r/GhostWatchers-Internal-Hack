using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Donteco;
using db = GhostWatchers.objects.vars;
using gwBase = GhostWatchers.objects.gwObjects;

namespace GhostWatchers.modules
{
    class ESP
    {
        public static Vector3 bHead, bNeck;
        public static Vector3 bChest, bShoulderR;
        public static Vector3 bElbowR, bWristR;
        public static Vector3 bShoulderL, bElbowL;
        public static Vector3 bWristL, bSpine2;
        public static Vector3 bHipR, bKneeR;
        public static Vector3 bAnkleR, bHipL;
        public static Vector3 bKneeL, bAnkleL;
        public static Vector3 bSpine1, bHips;

        public static int hVal;
        public static bool lon = false;

        public static void show_esp()
        {
            if (db.showGhost)
            {
                ghostESP();
            }
            if (db.showItems)
            {
                itemESP();
            }
            if (db.showPlayers)
            {
                playerESP();
            }
            if (db.showHouse)
            {
                houseESP();
            }

        }

        private static void ghostESP()
        {
            if (gwBase.ghost != null)
            {
                if (IsOnScreen(gwBase.ghost.transform))
                {
                    Vector3 w2s_head = Camera.main.WorldToScreenPoint(gwBase.ghost.transform.position);
                    
                    Vector3 pivotPos1 = gwBase.ghost.transform.position;
                    Vector3 playerFootPos1; playerFootPos1.x = pivotPos1.x; playerFootPos1.z = pivotPos1.z; playerFootPos1.y = pivotPos1.y + 0.08f;
                    Vector3 playerHeadPos1; playerHeadPos1.x = playerFootPos1.x; playerHeadPos1.z = playerFootPos1.z; playerHeadPos1.y = playerFootPos1.y + gwBase.ghost.Movement.GetHeight();
                    
                    Vector3 w2s_playerFoot1 = Camera.main.WorldToScreenPoint(playerFootPos1);
                    Vector3 w2s_playerHead1 = Camera.main.WorldToScreenPoint(playerHeadPos1);

                    string distanceText = "";

                    if (db.useDistance)
                    {
                        distanceText = $"{gwBase.ghost.Data.name.Replace("(Clone)", "")} [{Math.Round(Vector3.Distance(gwBase.ghost.transform.position, gwBase.localplayer.transform.position),0)}]";
                    }
                    else
                    {
                        distanceText = $"{gwBase.ghost.Data.name.Replace("(Clone)", "")}";
                    }

                    if (db.useBoxes && db.toggle_useLabels)
                    {
                        DrawESP(w2s_playerFoot1, w2s_playerHead1, Color.magenta, distanceText);
                    }
                    if (db.useBoxes && !db.toggle_useLabels)
                    {
                        DrawESP(w2s_playerFoot1, w2s_playerHead1, Color.magenta, $"");
                    }
                    if (!db.useBoxes && db.toggle_useLabels)
                    {
                        Render.DrawString(new Vector2(w2s_head.x, (float)Screen.height - w2s_head.y), distanceText, Color.magenta);
                    }
                }

                if (gwBase.footprints != null)
                {
                    foreach (Footprint print in gwBase.footprints)
                    {
                        if (IsOnScreen(print.transform))
                        {
                            Vector3 w2s_print = Camera.main.WorldToScreenPoint(print.transform.position);
                            Render.DrawString(new Vector2(w2s_print.x, (float)Screen.height - w2s_print.y), $"Footprint", utils.NuColor.RGBtoColor(77, 29, 209));
                        }
                    }
                }
            }

            if (db.usePlayerBones && IsOnScreen(gwBase.ghost.transform))
            {
                switch (gwBase.ghost.Data.name.Replace("(Clone)", "").ToLower().Replace(" ", ""))
                {
                    case "poltergeist":
                        ESP_Models.Poltergeist.show_bones();
                        break;
                    case "vampire":
                        ESP_Models.Vampire.show_bones();
                        break;
                    case "demon":
                        ESP_Models.Demon.show_bones();
                        break;
                    case "gallowsghost":
                        ESP_Models.GallowsGhost.show_bones();
                        break;
                    case "drowned":
                        ESP_Models.Drowned.show_bones();
                        break;
                    case "baby":
                        ESP_Models.Baby.show_bones();
                        break;
                    case "darkness":
                        ESP_Models.Darkness.show_bones();
                        break;
                    case "puppet":
                        ESP_Models.Puppet.show_bones();
                        break;
                }
            }
            
        }

        private static void itemESP()
        {
            foreach (Donteco.ChildrenToyController entity in gwBase.item)
            {
                if (entity != null)
                {
                    if (IsOnScreen(entity.transform))
                    {
                        Vector3 w2s_obj = Camera.main.WorldToScreenPoint(entity.transform.position);
                        Render.DrawString(new Vector2(w2s_obj.x, (float)Screen.height - w2s_obj.y), $"Cursed Item", utils.NuColor.RGBtoColor(0, 255, 255));
                    }
                }
            }
        }

        private static void houseESP()
        {
            foreach (OpenableObjectController door in gwBase.doors)
            {
                if (door != null)
                {
                    if (IsOnScreen(door.transform))
                    {
                        Vector3 w2s_obj = Camera.main.WorldToScreenPoint(door.transform.position);

                        string distanceText = "";

                        if (db.useDistance)
                        {
                            distanceText = $"Door [{Math.Round(Vector3.Distance(door.transform.position, gwBase.localplayer.transform.position), 0)}]";
                        }
                        else
                        {
                            distanceText = $"Door";
                        }

                        Render.DrawString(new Vector2(w2s_obj.x, (float)Screen.height - w2s_obj.y), distanceText, utils.NuColor.RGBtoColor(217, 9, 147));
                    }
                }
            }
            foreach (LightSwitcherController light in gwBase.lights)
            {
                if (light != null)
                {
                    if (IsOnScreen(light.transform))
                    {
                        Vector3 w2s_obj = Camera.main.WorldToScreenPoint(light.transform.position);

                        string distanceText = "";

                        if (db.useDistance)
                        {
                            distanceText = $"LightSwitch [{Math.Round(Vector3.Distance(light.transform.position, gwBase.localplayer.transform.position), 0)}]";
                        }
                        else
                        {
                            distanceText = $"LightSwitch";
                        }

                        Render.DrawString(new Vector2(w2s_obj.x, (float)Screen.height - w2s_obj.y), distanceText, utils.NuColor.RGBtoColor(217, 182, 9));
                    }
                }
            }
        }

        private static void playerESP()
        {
            Color HealthColor = Color.green;
            hVal = 100;

            foreach (PlayerSetup entity in gwBase.network_player)
            {
                if (!entity.IsLocalPlayer)
                {
                    if (entity.GetComponentInParent<PlayerHealth>(true) != null)
                    {
                        hVal = entity.GetComponentInParent<PlayerHealth>(true).CurrentHealth.Value;

                        if (hVal <= 0)
                        {
                            HealthColor = Color.white;
                        }
                        if (hVal <= 25 && hVal >= 1)
                        {
                            HealthColor = utils.NuColor.RGBtoColor(217, 16, 9);
                        }
                        if (hVal < 75 && hVal > 25)
                        {
                            HealthColor = utils.NuColor.RGBtoColor(217, 92, 9);
                        }
                        if (hVal <= 99 && hVal >= 75)
                        {
                            HealthColor = utils.NuColor.RGBtoColor(217, 172, 9);
                        }
                        
                    }

                    if (gwBase.lobby == null)
                    {
                        if (IsOnScreen(entity.transform))
                        {
                            Vector3 w2s_head = Camera.main.WorldToScreenPoint(entity.transform.position);
                            GUI.Label(new Rect(w2s_head.x, (float)Screen.height - w2s_head.y, 100, 30), $"Player");
                        }
                    }
                    else
                    {
                        foreach (LobbyPlayer i in gwBase.lobbyPlayers)
                        {
                            if (i.Id == entity.SteamId.ToString())
                            {
                                if (IsOnScreen(entity.transform)) 
                                {
                                    Vector3 w2s_head = Camera.main.WorldToScreenPoint(entity.transform.position);

                                    Vector3 pivotPos1 = entity.transform.position;
                                    Vector3 playerFootPos1; playerFootPos1.x = pivotPos1.x; playerFootPos1.z = pivotPos1.z; playerFootPos1.y = pivotPos1.y;
                                    Vector3 playerHeadPos1; playerHeadPos1.x = playerFootPos1.x; playerHeadPos1.z = playerFootPos1.z; playerHeadPos1.y = playerFootPos1.y + 2f;

                                    Vector3 w2s_playerFoot1 = Camera.main.WorldToScreenPoint(playerFootPos1);
                                    Vector3 w2s_playerHead1 = Camera.main.WorldToScreenPoint(playerHeadPos1);

                                    string distanceText = "";

                                    if (db.useDistance)
                                    {
                                        distanceText = $"{i.Nickname} [{Math.Round(Vector3.Distance(entity.transform.position, gwBase.localplayer.transform.position), 0)}]";
                                    }
                                    else
                                    {
                                        distanceText = $"{i.Nickname}";
                                    }

                                    if (db.useBoxes && db.toggle_useLabels)
                                    {
                                        DrawESP(w2s_playerFoot1, w2s_playerHead1, HealthColor, distanceText);
                                    }
                                    if (db.useBoxes && !db.toggle_useLabels)
                                    {
                                        DrawESP(w2s_playerFoot1, w2s_playerHead1, HealthColor, $"");
                                    }
                                    if (!db.useBoxes && db.toggle_useLabels)
                                    {
                                        Render.DrawString(new Vector2(w2s_head.x, (float)Screen.height - w2s_head.y), distanceText, HealthColor);
                                    }
                                }
                            }
                        }
                    }
                    
                    if (entity.Male.GetComponentInChildren<SkinnedMeshRenderer>() != null && IsOnScreen(entity.transform) && db.usePlayerBones)
                    {
                        Transform[] boneEnt = entity.Male.GetComponentInChildren<SkinnedMeshRenderer>().bones;
                        int checker = 0;
                        
                        foreach (Transform b in boneEnt)
                        {

                            if (b.name.Contains("Head_"))
                            {
                                bHead = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Neck_"))
                            {
                                bNeck = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Chest_"))
                            {
                                bChest = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Spine2_"))
                            {
                                bSpine2 = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Spine1_"))
                            {
                                bSpine1 = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Root_"))
                            {
                                bHips = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Hip_L"))
                            {
                                bHipL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Hip_R"))
                            {
                                bHipR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Knee_L"))
                            {
                                bKneeL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Knee_R"))
                            {
                                bKneeR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Ankle_L"))
                            {
                                bAnkleL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Ankle_R"))
                            {
                                bAnkleR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Shoulder_R"))
                            {
                                bShoulderR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Shoulder_L"))
                            {
                                bShoulderL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Elbow_R"))
                            {
                                bElbowR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Elbow_L"))
                            {
                                bElbowL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Wrist_L"))
                            {
                                bWristL = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                            if (b.name.Contains("Wrist_R"))
                            {
                                bWristR = Camera.main.WorldToScreenPoint(b.transform.position);
                                checker++;
                            }
                        }
                        
                        if (checker >= 18)
                        {
                            DrawBoneLine(bHead, bNeck, HealthColor);
                            DrawBoneLine(bNeck, bChest, HealthColor);
                            DrawBoneLine(bChest, bSpine2, HealthColor);
                            DrawBoneLine(bSpine2, bSpine1, HealthColor);
                            DrawBoneLine(bSpine1, bHips, HealthColor);

                            DrawBoneLine(bNeck, bShoulderR, HealthColor);
                            DrawBoneLine(bShoulderR, bElbowR, HealthColor);
                            DrawBoneLine(bElbowR, bWristR, HealthColor);

                            DrawBoneLine(bNeck, bShoulderL, HealthColor);
                            DrawBoneLine(bShoulderL, bElbowL, HealthColor);
                            DrawBoneLine(bElbowL, bWristL, HealthColor);

                            DrawBoneLine(bHips, bHipR, HealthColor);
                            DrawBoneLine(bHipR, bKneeR, HealthColor);
                            DrawBoneLine(bKneeR, bAnkleR, HealthColor);

                            DrawBoneLine(bHips, bHipL, HealthColor);
                            DrawBoneLine(bHipL, bKneeL, HealthColor);
                            DrawBoneLine(bKneeL, bAnkleL, HealthColor);
                        }
                        
                    }
                }
            }
        }

        private static bool IsOnScreen(Transform ent_transform)
        {
            Vector3 w2s_check = Camera.main.WorldToScreenPoint(ent_transform.position);
            
            if (w2s_check.z > 0.1f && w2s_check.x > 0f && w2s_check.x < (float)Screen.width && w2s_check.y > 0 && w2s_check.y < (float)Screen.height)
            {
                return true;
            }

            return false;
        }

        public static void DrawESP(Vector3 objfootPos, Vector3 objheadPos, Color objColor, String name)
        {
            float height = objheadPos.y - objfootPos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            Render.DrawBox(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - height, width, height, objColor, 1f);
            Render.DrawString(new Vector2(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - height), $"{name}", Color.magenta);
        }

        public static void DrawBoneLine(Vector3 w2s_objectStart, Vector3 w2s_objectFinish, Color color)
        {
            if (w2s_objectStart != null && w2s_objectFinish != null)
            {
                Render.DrawLine(new Vector2(w2s_objectStart.x, (float)Screen.height - w2s_objectStart.y), new Vector2(w2s_objectFinish.x, (float)Screen.height - w2s_objectFinish.y), color, 1f);
            }
        }
    }
}
