using Mas4loo.ColorSchemePalettes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/DominantColorScheme")]
public class DominantColorScheme : ColorSchemeBase
{
    public int SplitResolution = 2;

    public override List<Color> GetColors(Color baseColor)
    {
        List<Color> colors = new();

        Vector3 mainHSV = baseColor.ToHSV();
        float offset = 1.0f / SplitResolution;

        for (int si = 0; si < SplitResolution; si++)
        {
            float saturateOffset = si * offset;
            for (int vi = 0; vi < SplitResolution; vi++)
            {
                float valueOffset = vi * offset;

                Vector3 hsv = new(mainHSV.x, mainHSV.y - saturateOffset, mainHSV.z - valueOffset);
                colors.Add(hsv.ToRGB());
            }
        }
        return colors;
    }
}
