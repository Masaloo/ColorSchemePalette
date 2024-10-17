using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(CamaieuScheme))]
    public class CamaieuScheme : ColorSchemeBase
    {
        [Range(-0.05f,0.05f)]public float HueOffset = 0.1f;
        [Range(-0.25f,0.25f)]public float ToneOffset = 0f;
        public override List<Color> BakeColor(Color baseColor)
        {
            List<Color> colors = new List<Color>()
            {
                baseColor,
                baseColor.HSVOffset(HueOffset,ToneOffset,ToneOffset)
            };
            return colors;
        }
    }
}
