using UnityEngine;


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
        //%1.0f(= fraction)
        return Color.HSVToRGB(hsv.x % 1.0f, hsv.y, hsv.z);
    }


    public static Color HSVOffset(this Color color,float hueOffset,float saturateOffset,float valueOffset)
    {
        var hsv = color.ToHSV();
        var newColor = Color.HSVToRGB(
            Mathf.Repeat(hsv.x + hueOffset, 1.0f),
            hsv.y + saturateOffset,
            hsv.z + valueOffset);
        return newColor;
    }

    public static Color HSVOffset(this Color color, Vector3 offset)
    {
        var hsv = color.ToHSV();
        var newColor = Color.HSVToRGB(
            Mathf.Repeat(hsv.x + offset.x, 1.0f),
            hsv.y + offset.y,
            hsv.z + offset.z);
        return newColor;
    }


    public static Color ToComplementary(this Color color)
    {
        Vector3 hsv = color.ToHSV();
        Vector3 compHSV = new(
            Mathf.Repeat(hsv.x - 0.5f,1.0f),
            hsv.y,
            hsv.z);
        return compHSV.ToRGB();
    }

    public static Color ToComplementary(this Color color,float hueOffset)
    {
        Vector3 hsv = color.ToHSV();
        Vector3 compHSV = new(
            Mathf.Repeat(hsv.x - 0.5f + hueOffset,1.0f),
            hsv.y,
            hsv.z);
        return compHSV.ToRGB();
    }

}

