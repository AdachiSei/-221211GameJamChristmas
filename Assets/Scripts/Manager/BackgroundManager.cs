using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BackgroundManager : SingletonMonoBehaviour<BackgroundManager>
{
    [SerializeField]
    [Header("朝")]
    SpriteRenderer _morning;

    [SerializeField]
    [Header("夜")]
    SpriteRenderer _night;

    [SerializeField]
    GameObject _gameObject;

    async public void ChangeBackgrount()
    {
        DecorationsGenerator.Instance.Destroy();
        Destroy(_gameObject);
        if(_morning.gameObject.activeSelf)
        {
            await ChangeDay.Instance.DayChange();
            _morning.gameObject.SetActive(false);
            _night.gameObject.SetActive(true);
        }
        else
        {
            await ChangeDay.Instance.DayChange();
            _morning.gameObject.SetActive(true);
            _night.gameObject.SetActive(false);
        }
        SoundManager.Instance.PlayBGM("リザルト");
    }
}
