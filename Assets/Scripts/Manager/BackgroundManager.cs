using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : SingletonMonoBehaviour<BackgroundManager>
{
    [SerializeField]
    [Header("朝")]
    SpriteRenderer _morning;

    [SerializeField]
    [Header("夜")]
    SpriteRenderer _night;

    public void ChangeBackgrount()
    {
        if(_morning.gameObject.activeSelf)
        {
            _morning.gameObject.SetActive(false);
            _night.gameObject.SetActive(true);
        }
        else
        {
            _morning.gameObject.SetActive(true);
            _night.gameObject.SetActive(false);
        }
    }
}
