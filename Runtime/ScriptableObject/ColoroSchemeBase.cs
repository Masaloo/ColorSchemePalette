
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    public abstract class ColorSchemeBase:ScriptableObject
    {
        public Color BaseColor = Color.cyan;
        public List<Color> Colors;

        public abstract List<Color> GetColors(Color baseColor);

        void Awake()
        {
            BakeColors();
        }

        void OnEnable()
        {
            BakeColors();
        }

        void OnValidate()
        {
            BakeColors();
        }


        void Reset()
        {
            BakeColors();
        }

        void BakeColors()
        {
            Colors.Clear();
            Colors = GetColors(BaseColor);
        }
    }
}
