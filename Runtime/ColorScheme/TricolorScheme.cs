using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [CreateAssetMenu(fileName = "ColorScheme", menuName = "ColorPalette/" + nameof(TricolorScheme))]
    public class TricolorScheme : ColorSchemeBase
    {
        public SubColorType SubColorType;

        [Header("MonoSubColor Only")]
        [Range(-1f, 1f)] public float HueOffset = 0f;
        [Range(0, 1f)] public float MonoColorValueOffset;
        public override List<Color> GetColors(Color baseColor)
        {
            var colors = new List<Color>()
            { baseColor };
            switch (SubColorType)
            {
                case SubColorType.Black:
                    colors.Add(Color.black.HSVOffset(0, 0, MonoColorValueOffset));
                    colors.Add(baseColor.ToComplementary(HueOffset));
                    break;

                case SubColorType.White:
                    colors.Add(Color.white.HSVOffset(0,0,-MonoColorValueOffset));
                    colors.Add(baseColor.ToComplementary(HueOffset));
                    break;

                case SubColorType.Complementary:
                    colors.Add(baseColor.HSVOffset(1.0f / 3,0,0));
                    colors.Add(baseColor.HSVOffset(-1.0f / 3,0,0));
                    break;
            }
            return colors;
        }

    }
}
