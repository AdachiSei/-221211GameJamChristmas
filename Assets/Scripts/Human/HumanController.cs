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

    CreateEmotionAnimation _animation;

    [System.Obsolete]
    async private void OnEnable()
    {
        _animation = GetComponent<CreateEmotionAnimation>();
        transform.DOMove(_trrePos, _moveSpeed);

        _animationTime = Random.RandomRange(60, max: 240);
        await UniTask.DelayFrame(_animationTime);

        _animation.Create();
        Debug.Log("アニメーションを呼んだ");

        await UniTask.DelayFrame(1200);
        this.gameObject.SetActive(false);

    }
}
