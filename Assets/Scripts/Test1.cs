using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;
using UnityEngine.Events;
using System;

public class Test1 : MonoBehaviour
{
    [SerializeField]
    [Header("オブジェクトが移動するまでの時間")]
    float _moveTime;

    [SerializeField]
    [Header("オブジェクトを残す時間")]
    float __delayTime;
    void Start()
    {
        transform.DOLocalMoveY(1f, _moveTime);
        transform.DOScale(new Vector2(1.3f, 1.3f), _moveTime);

        DelayAsync(_moveTime + __delayTime, () => { Test(); }).Forget();
    }
    private void Test()
    {
        print("オブジェクトを削除");
        this.gameObject.SetActive(false);
        //Destroy(this.gameObject);
    }

    private async UniTask DelayAsync(float seconds, UnityAction callback)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(seconds));
        callback?.Invoke();
    }
}
