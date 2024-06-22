using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "ColorScheme", menuName = "Scriptable Objects/ColorScheme")]
public class ColorSchemeTable : ScriptableObject
{
    public ColorSchemeType colorSchemeType;

    public Color Main = Color.red;

    public List<Color> Colors;

    [Range(0, 1)] public float Offset = 0.1f;

    /// <summary>
    /// ê∂ê¨Ç∑ÇÈêFÇÃêî
    /// </summary>
    [Range(0,8)] public int GenerateColorOffsetCount = 1;


    void OnValidate()
    {
        BakeTable();
    }
        
    void BakeTable()
    {
        Colors.Clear();
        Colors.Add(Main);
        switch (colorSchemeType)
        {
            case ColorSchemeType.DominantColor:
                BakeDominantColor();
                break;

            case ColorSchemeType.DominantTone:
                BakeDominantTone();
                break;



        }
    }

    void BakeDominantColor()
    {
        Vector3 mainHSV = Main.ToHSV();

        for (int si = 0; si < GenerateColorOffsetCount; si++)
        {
            float saturateOffset = si * Offset;
            for (int vi = 0; vi < GenerateColorOffsetCount; vi++)
            {
                float valueOffset = vi * Offset;

                Vector3 hsv = new(mainHSV.x, mainHSV.y - saturateOffset, mainHSV.z - valueOffset);
                Colors.Add(hsv.ToRGB());
            }
        }
    }

    void BakeDominantTone()
    {
        Vector3 mainHSV = Main.ToHSV();

        for (int si = 0; si < GenerateColorOffsetCount; si++)
        {
            float saturateOffset = si * Offset;
            for (int vi = 0; vi < GenerateColorOffsetCount; vi++)
            {
                float valueOffset = vi * Offset;

                Vector3 hsv = new(mainHSV.x, mainHSV.y - saturateOffset, mainHSV.z - valueOffset);
                Colors.Add(hsv.ToRGB());
            }
        }
    }

}

public enum ColorSchemeType
{
    DominantColor,
    DominantTone,
    Bicolor,
    Tricolor,
}
