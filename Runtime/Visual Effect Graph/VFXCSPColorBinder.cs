namespace Mas4loo.ColorSchemePalettes
{

    using UnityEngine;
    using UnityEngine.VFX;
    using UnityEngine.VFX.Utility;
    // VFXBinder Attribute がこのクラスをプロパティバインディングの追加メニューに投入します。
    [VFXBinder("ColorSchemePalette/Palette Color")]
    // クラスは VFXBinderBase を拡張する必要があります
    public class VFXCSPColorBinder : VFXBinderBase
    {
        // VFXPropertyBinding 属性は特定のタイプの
        //  VisualEffect プロパティを追加する特殊プロパティドローワーを
        // 使えるようにします。
        [VFXPropertyBinding("System.Single")]
        public ExposedProperty property = "Color";

        public ColorSchemeBase target;
        public int index;


        // IsValid メソッドはバインディングが達成できるなら、チェックを実行し返す
        // 必要があります。
        public override bool IsValid(VisualEffect component)
        {
            return target != null 
                && component.HasVector4(property)
                && target.Colors[index] != null;
        }

        // UpdateBinding メソッドは有効であると推定しバインディングを
        // 実行する場所です。このメソッドはIsValid が true を返した場合のみ
        // 呼び出されます。
        public override void UpdateBinding(VisualEffect component)
        {
            var c = target.Colors[index];
            component.SetVector4(property,c);
        }
    }
}