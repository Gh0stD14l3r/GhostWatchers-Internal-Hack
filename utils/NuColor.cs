using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GhostWatchers.utils
{
    class NuColor
    {
        private static System.Random rand = new System.Random();

        private static float minimum = 80f;
        private static float maximum = 255f;

        private static float mRed = 80;
        private static float mBlue = 255;
        private static float mGreen = 80;

        private static bool rdown = false;
        private static bool bdown = false;
        private static bool gdown = false;

        private static float changeRate = 0.1f;

        public static Color RGBtoColor(float r = 255f, float g = 255f, float b = 255f)
        {
            return new Color(r / 255f, g / 255f, b / 255f);
        }
        public static Color RGBAtoColor(float r = 255f, float g = 255f, float b = 255f, float a = 255f)
        {
            return new Color(r / 255f, g / 255f, b / 255f, a / 255f);
        }

        public static Color Multicolor()
        {
            if (mRed >= maximum)
            {
                rdown = true;
            }
            if (mBlue >= maximum)
            {
                bdown = true;
            }
            if (mGreen >= maximum)
            {
                gdown = true;
            }
            if (mRed <= minimum)
            {
                rdown = false;
            }
            if (mBlue <= minimum)
            {
                bdown = false;
            }
            if (mGreen <= minimum)
            {
                gdown = false;
            }

            if (rand.Next(1, 10) >= 5)
            {
                if (rdown)
                {
                    mRed -= changeRate;
                }
                else
                {
                    mRed += changeRate;
                }
            }
            if (rand.Next(1, 10) >= 5)
            {
                if (gdown)
                {
                    mGreen -= changeRate;
                }
                else
                {
                    mGreen += changeRate;
                }
            }
            if (rand.Next(1, 10) >= 5)
            {
                if (bdown)
                {
                    mBlue -= changeRate;
                }
                else
                {
                    mBlue += changeRate;
                }
            }
            
            return new Color(mRed / 255f, mBlue / 255f, mGreen / 255f);
        }
    }
}
