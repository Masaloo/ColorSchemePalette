using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [RequireComponent(typeof(SpriteRenderer)),ExecuteAlways]
    public class CSPSpriteRendererBinder : MonoBehaviour
    {
        public ColorSchemeBase palette;
        public int index;
        SpriteRenderer _renderer;
        void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }
        // Update is called once per frame
        void Update()
        {
            if (palette == null) return;
            _renderer.color = palette.Colors[index];
        }
    }
}