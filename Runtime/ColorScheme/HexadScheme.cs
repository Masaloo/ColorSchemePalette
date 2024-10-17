using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(HexadScheme))]
    public class HexadScheme : ColorSchemeBase
    {
        public override List<Color> BakeColor(Color baseColor)
        {
            List<Color> colors = new()
            {
                baseColor,
                baseColor.HSVOffset(1.0f/6 * 1,0,0),
                baseColor.HSVOffset(1.0f/6 * 2,0,0),
                baseColor.HSVOffset(1.0f/6 * 3,0,0),
                baseColor.HSVOffset(1.0f/6 * 4,0,0),
                baseColor.HSVOffset(1.0f/6 * 5,0,0),
            };

            return colors;
        }
    }
}
