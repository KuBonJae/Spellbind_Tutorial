using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UsingDOTweenScript : MonoBehaviour
{
    Sequence sequence;

    // Append : 트윈 마지막에 추가
    // Insert : 일정 시간에 시작
    // Join : 앞에 추가된 트윈과 동시 시작
    // Prepend : 맨 처음에 추가
    
    void Awake()
    {
        sequence = DOTween.Sequence();

        DOTween.Init(false, true).SetCapacity(200, 50);

        //Tweener tr = transform.DOScale(2f, 2f)
        //    .SetEase(Ease.Linear)
        //    .OnComplete(() => transform.DOMove(new Vector3(3f, 3f, 0f), 3f));

        gameObject.GetComponent<Rigidbody>()?.transform.DOMove(new Vector3(10f, 10f, 10f), 5f)
            .OnComplete(TriggerCoroutine);
    }

    void TriggerCoroutine()
    {
        StartCoroutine(MakeBigger());
    }

    IEnumerator MakeBigger()
    {
        yield return new WaitForSeconds(1f);

        gameObject.GetComponent<Rigidbody>().transform.DOScale(new Vector3(3f, 3f, 3f), 2f);
    }
}
