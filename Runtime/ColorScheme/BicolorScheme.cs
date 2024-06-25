using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/"+nameof(BicolorScheme))]
    public class BicolorScheme : ColorSchemeBase
    {
        public SubColorType subColor;

        public override List<Color> GetColors(Color baseColor)
        {
            var colors = new List<Color>()
            { 
                baseColor
            };
            switch(subColor)
            {
                case SubColorType.Black:colors.Add(Color.black); break; 
                case SubColorType.White:colors.Add(Color.white); break;
                case SubColorType.Complementary:colors.Add(baseColor.ToComplementary()); break;
            }
            return colors;
        }
    }
}
