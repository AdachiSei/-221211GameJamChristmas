using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;
using UnityEngine.Events;
using System;

public class MoveObject : MonoBehaviour
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

        DelayAsync(_moveTime + __delayTime, () => { Delete(); }).Forget();
    }
    private void Delete()
    {
        print("オブジェクトを削除");
        this.gameObject.SetActive(false);
    }

    private async UniTask DelayAsync(float seconds, UnityAction callback)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(seconds));
        callback?.Invoke();
    }

    private void OnEnable()
    {
        transform.DOLocalMoveY(1f, _moveTime);
        transform.DOScale(new Vector2(1.3f, 1.3f), _moveTime);

        DelayAsync(_moveTime + __delayTime, () => { Delete(); }).Forget();
    }
}
