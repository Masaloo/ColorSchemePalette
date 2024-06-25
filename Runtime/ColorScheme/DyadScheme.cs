using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(DyadScheme))]
    public class DyadScheme : ColorSchemeBase
    {
        public override List<Color> GetColors(Color baseColor)
        {
            List<Color> colors = new List<Color>()
            {
                baseColor,
                baseColor.ToComplementary()
            };
            return colors;
        }
    }

}
