using Mas4loo.ColorSchemePalettes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(DominantToneScheme))]
public class DominantToneScheme : ColorSchemeBase
{
    public int SplitResolution = 4;

    public override List<Color> GetColors(Color baseColor)
    {
        List<Color> colors = new();
        Vector3 mainHSV = baseColor.ToHSV();

        float offset = 1.0f / SplitResolution;

        float saturate = mainHSV.y;
        float value = mainHSV.z;

        for (int hi = 0; hi < SplitResolution; hi++)
        {
            float hueOffset = (offset * hi);
            Vector3 hsv = new(mainHSV.x + hueOffset, saturate, value);
            colors.Add(hsv.ToRGB());
        }
        return colors;
    }
}
