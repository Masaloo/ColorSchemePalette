using UnityEngine;

namespace Mas4loo.ColorSchemePalettes
{
    [RequireComponent(typeof(Camera)),ExecuteAlways]
    public class CSPCameraBackGroundBinder : MonoBehaviour
    {
        public ColorSchemeBase ColorScheme;
        public int Index = 0;


        Camera _camera;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _camera = GetComponent<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_camera == null) return;
            if (ColorScheme == null) return;
            _camera.backgroundColor = ColorScheme.Colors[Index];
        }
    }
}
