using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [RequireComponent(typeof(Renderer)), ExecuteAlways]
    public class CSPRendererMaterialBinder : MonoBehaviour
    {
        public ColorSchemeBase palette;
        public int index;
        public string propertyName = "_Color";
        private int propertyID;
        Renderer _renderer;

        void Start()
        {
            _renderer = GetComponent<Renderer>();
            propertyID = Shader.PropertyToID(propertyName);
        }

        void OnValidate()
        {
            propertyID = Shader.PropertyToID(propertyName);
        }

        // Update is called once per frame
        void Update()
        {
            if (palette == null) return;

            if(Application.isPlaying)
            {
                var mat = _renderer.material;
                if (mat != null) return;
                _renderer.material.SetColor(propertyID, palette.Colors[index]);
            }
            else
            {
                if(_renderer.material == null) return;
                _renderer.sharedMaterial.SetColor(propertyID, palette.Colors[index]);
            }
        }
    }
}
