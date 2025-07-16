using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSettingScriptableObject
{
    private static ScriptableObjectExample _instance;
    public static ScriptableObjectExample Instance
    {
        get
        {
            if (_instance == null)
                _instance = Resources.Load<ScriptableObjectExample>("Scriptable Object Example");

            return _instance;
        }
    }
}
