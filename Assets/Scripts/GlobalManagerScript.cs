using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlobalManagerScript : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void ManagerInit()
    {
        // Manager �ʱ�ȭ �Լ�
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
