using UnityEngine;

namespace Mas4loo.ColorScheme
{
    public static class ColorExtension
    {
        public static Vector3 ToHSV(this Color color) 
        {
            float h, s, v;
            Color.RGBToHSV(color, out h,out s,out v);

            return new(h, s, v);
        }

        public static Color ToRGB(this Vector3 hsv)
        {
            return Color.HSVToRGB(hsv.x, hsv.y, hsv.z);
        }

    }
}
