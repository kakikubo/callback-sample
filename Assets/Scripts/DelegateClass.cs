using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// デリゲート用のクラス。文字列がセットされたら、コールバックを登録したTextにも反映させる
/// </summary>
public class DelegateClass : MonoBehaviour {

    public static Action<string> CallbackMethod = delegate {};

    public static bool Set(string text)
    {
        SetText(text);
        return true;
    }

    private static void SetText(string text)
    {
        CallbackMethod(text);
    }

    public static void SetText()
    {
        CallbackMethod("");
    }
}
