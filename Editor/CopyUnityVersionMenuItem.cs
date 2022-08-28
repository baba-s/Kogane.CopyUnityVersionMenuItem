using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class CopyUnityVersionMenuItem
    {
        [MenuItem( "Kogane/Unity バージョン/クリップボードにコピー" )]
        public static void Copy()
        {
            var unityVersion = Application.unityVersion;
            EditorGUIUtility.systemCopyBuffer = unityVersion;

            EditorUtility.DisplayDialog
            (
                title: "",
                message: $"Unity のバージョンをクリップボードにコピーしました\n{unityVersion}",
                ok: "OK"
            );
        }
    }
}