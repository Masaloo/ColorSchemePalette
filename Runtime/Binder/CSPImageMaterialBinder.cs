using UnityEngine;
using UnityEngine.UI;

namespace Mas4loo.ColorSchemePalettes
{
    [RequireComponent(typeof(Image)),ExecuteAlways]
    public class CSPImageColorBinder : MonoBehaviour
    {
        public int Index;
        public ColorSchemeBase source;
        private Image image;

        void BindColor()
        {
            if(Application.isPlaying)
            {
                if (source == null) return;
                image.color = source.GetColor(Index);
            }
            else
            {
#if UNITY_EDITOR
                image = GetComponent<Image>();
                image.color = source.GetColor(Index);
#endif  
            }

        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            image = GetComponent<Image>();
        }

        // Update is called once per frame
        void Update()
        {
            BindColor();

        }

        void OnValidate()
        {
            BindColor();
        }
    }
}
