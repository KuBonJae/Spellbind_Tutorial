using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Unity.VisualScripting;
using TMPro;

public class DOTweenSecondClass : MonoBehaviour
{
    [SerializeField]
    GameObject Image;
    [SerializeField]
    GameObject Text;

    bool doColorActivated = false;
    bool doFadeActivated = false;
    bool doFillAmountActivated = false;
    bool doCounterActivated = false;
    bool doTextActivated = false;

    public void ImageDoColor()
    {
        if(!doColorActivated)
        {
            Image.GetComponent<Image>().DOColor(Color.black, 1f);
            doColorActivated = true;
        }
        else
        {
            Image.GetComponent<Image>().DOColor(Color.white, 1f);
            doColorActivated = false;
        }
    }

    public void ImageDoFade()
    {
        if(!doFadeActivated)
        {
            Image.GetComponent<Image>().DOFade(0.1f, 1f);
            doFadeActivated = true;
        }
        else
        {
            Image.GetComponent<Image>().DOFade(1f, 1f);
            doFadeActivated = false;
        }
    }

    public void ImageDoFillAmount()
    {
        if(!doFillAmountActivated)
        {
            Image.GetComponent<Image>().DOFillAmount(0.1f, 1f);
            doFillAmountActivated= true;
        }
        else
        {
            Image.GetComponent<Image>().DOFillAmount(1f, 1f);
            doFillAmountActivated = false;
        }
    }

    public void TextDoCounter()
    {
        Text.GetComponent<Text>().DOCounter(0, 10, 10);
    }

    Tween tr;
    public void TextDoText()
    {
        
        if (tr != null)
            Text.GetComponent<Text>().text = "";

        tr = Text.GetComponent<Text>().DOText("DoTextComplete", 2f);

        //Debug.Log(Text.GetComponent<Text>().DOKill());
        
        // TextMeshProUGUI는 pro 버전에서 사용할 것
        //Text.GetComponent<TextMeshProUGUI>().GetComponent<Text>().DOText("DoTextComplete", 2f);
    }
}
