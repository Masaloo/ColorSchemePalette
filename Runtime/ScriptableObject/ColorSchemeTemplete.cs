using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(ColorSchemeTemplete))]
    public class ColorSchemeTemplete : ColorSchemeBase
    {
        public override List<Color> BakeColor(Color baseColor)
        {
            List<Color> colors = new List<Color>()
            { 
                baseColor 
            };

            return colors;
            throw new System.NotImplementedException();
        }
    }
}
