using Mas4loo.ColorSchemePalettes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(DominantToneScheme))]
public class DominantToneScheme : ColorSchemeBase
{
    public int SplitResolution = 4;
    public bool IsCreateMonoToneColor = false;
    public override List<Color> BakeColor(Color baseColor)
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

        if( IsCreateMonoToneColor )
        {
            Vector3 mono1 = new(0, 0, value);
            colors.Add(mono1.ToRGB());

            Vector3 mono2 = new(0, 0, 1 - value);
            colors.Add(mono2.ToRGB());
        }

        return colors;
    }
}
