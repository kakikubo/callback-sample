using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// サブミットボタンが押された時の処理です。
/// SubmitTextに記載された文字列をDelegateClassにセットします
/// </summary>
public class SubmitButton : MonoBehaviour {

    private Text submitText;

    void Awake()
    {
        submitText = GameObject.Find("SubmitText").GetComponent<Text>();
    }

    public void Submit()
    {
        Debug.Log("submitText.text = " + submitText.text);
        DelegateClass.Set(submitText.text);
    }
}
