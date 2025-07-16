using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnityCoroutineScript : MonoBehaviour
{
    [SerializeField]
    GameObject button;
    [SerializeField]
    GameObject toggle;
    [SerializeField]
    GameObject text;

    WaitForSeconds oneSecond = new WaitForSeconds(1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowGameObject());
    }

    IEnumerator ShowGameObject()
    {
        yield return oneSecond;
        button.SetActive(true);
        yield return oneSecond;
        toggle.SetActive(true);
        yield return oneSecond;
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
