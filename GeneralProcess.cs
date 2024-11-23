using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
/// <summary>
/// 共通處理腳本，主要將共通性需要呼叫的一系列處理集合
/// </summary>
public class GeneralProcess : MonoBehaviour
{
    /// <summary>
    /// 全域性的物件無效化(Inactivate)的函式<br/>
    /// 可以使用在：Animation結束時利用Event Trigger呼叫<br/>
    /// 最新資訊可以參考 <see href="https://www.notion.so/misosir00177/C-GeneralProcessor-Documentaion-1ec1f5753c204ecabb0fb831fb9cb561?pvs=4">Notion文檔</see>
    /// </summary>
    public void InactivateThisObject()
    {
        this.gameObject.SetActive(false);

    }

}

/// <summary>
/// 外部アクセス時(Animationから呼びたいときなど)に、関数忘れ防止用に記録をし、<br/>
/// Inspectorから内容関数を見てるようにするClass
/// </summary>
[CustomEditor(typeof(GeneralProcess))]
public class EditorHelp : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.HelpBox("有關於GeneralProcess的內容函式\n" +
            "public void InactivateThisObject()", MessageType.None);
    }
}
