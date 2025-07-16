using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlobalManagerScript : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void ManagerInit()
    {
        // Manager 초기화 함수
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
