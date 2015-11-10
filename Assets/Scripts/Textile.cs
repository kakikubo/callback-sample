using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 事前に「自身の文字列を変更する」関数だけDelegateClassに登録し、空文字列で初期化します。
/// </summary>
public class Textile : MonoBehaviour {

    private Text textMsg;

    void Awake()
    {
        DelegateClass.CallbackMethod += OnTextChange;
        textMsg = transform.GetComponent<Text>();
        DelegateClass.SetText();
    }

    private void OnTextChange(string text)
    {
        textMsg.text = text;
    }
}
