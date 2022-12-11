using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class HumanController : MonoBehaviour
{
    [SerializeField]
    [Header("人の移動スピード")]
    float _moveSpeed;

    [SerializeField]
    [Header("アニメーションを出すまでの時間")]
    int _animationTime;

    [SerializeField]
    Vector2 _trrePos;

    CreateObject _animation;

    [System.Obsolete]
    async void Awake()
    {
        transform.DOMove(_trrePos, _moveSpeed);

        _animationTime = Random.RandomRange(20, max: 30);
        await UniTask.DelayFrame(_animationTime);


        _animation.Create();
        Debug.Log("アニメーションを呼んだ");
    }
}
