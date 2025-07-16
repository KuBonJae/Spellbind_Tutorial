using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtons : MonoBehaviour
{
    [SerializeField]
    GameObject button;

    public void OnClickESC()
    {
        if (button.activeSelf)
            button.SetActive(false);
        else
            button.SetActive(true);
    }
}
