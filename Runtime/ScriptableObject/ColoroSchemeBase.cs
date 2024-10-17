
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    public abstract class ColorSchemeBase:ScriptableObject
    {
        public Color BaseColor = Color.cyan;
        public List<Color> Colors;
        public Gradient Gradient;
        public GradientMode GradientMode = GradientMode.PerceptualBlend;

        public const int MAX_COLOR_KEY_COUNT = 8;

        public Color GetColor(int i)
        {
            int len = Colors.Count;
            if (len < i)
            {
                 i = i % len;
            }

            return Colors[i];
        }

        public abstract List<Color> BakeColor(Color baseColor);

        Gradient BakeGradient()
        {
            int count = Colors.Count <= MAX_COLOR_KEY_COUNT ? Colors.Count : MAX_COLOR_KEY_COUNT;

            var colorkeys = new GradientColorKey[count];
            var alphakeys = new GradientAlphaKey[1];

            int index = Colors.Count <= MAX_COLOR_KEY_COUNT ? Colors.Count : MAX_COLOR_KEY_COUNT;

            alphakeys[0].alpha = 1.0f;
            for(int i = 0; i < index;i++)
            {
                float time = (1.0f / count) * i;
                colorkeys[i].time = time;
                colorkeys[i].color = Colors[i];
            }

            var gradient = new Gradient
            {
                mode = GradientMode
            };
            gradient.SetKeys(colorkeys,alphakeys);
            Gradient = gradient;
            return new Gradient();
        }

        void BakeColors()
        {
            Colors.Clear();
            Colors = BakeColor(BaseColor);
        }

        #region ScriptableObject Message Methods
        void Awake()
        {
            BakeColors();
            BakeGradient();
        }

        void OnEnable()
        {
            BakeColors();
            BakeGradient();
        }

        void OnValidate()
        {
            BakeColors();
            BakeGradient();
        }


        void Reset()
        {
            BakeColors();
            BakeGradient();
        }
        #endregion
    }
}
