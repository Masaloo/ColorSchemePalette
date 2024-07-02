using UnityEngine;

namespace Mas4loo.ColorSchemePalettes

{
    [RequireComponent(typeof(TrailRenderer)),ExecuteAlways]
    public class CSPTrailRendererBinder : MonoBehaviour
    {
        private TrailRenderer trailRenderer;
        public ColorSchemeBase colorScheme;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            trailRenderer = GetComponent<TrailRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (colorScheme == null) return;
            trailRenderer.colorGradient = colorScheme.Gradient;
        }
    }
}
