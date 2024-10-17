using Mas4loo.ColorSchemePalettes;
using UnityEngine;

[ExecuteAlways]
public class CSPGlobalShaderBinder : MonoBehaviour
{
    [Header("SerialzieField")]
    [SerializeField] ColorSchemeBase colorScheme;
    [SerializeField] string colorAPropertyName = "_ColorA";
    [SerializeField] string colorBPropertyName = "_ColorB";

    [Header("")]
    [SerializeField] private int colorAPropertyID;
    [SerializeField] private int colorBPropertyID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorAPropertyID = Shader.PropertyToID(colorAPropertyName);
        colorBPropertyID = Shader.PropertyToID (colorBPropertyName);
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalColor(colorAPropertyID,colorScheme.GetColor(0));
        Shader.SetGlobalColor(colorAPropertyID,colorScheme.GetColor(1));
    }
}
