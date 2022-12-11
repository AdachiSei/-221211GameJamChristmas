using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeView : MonoBehaviour
{
    [SerializeField]
    [Header("タイマーのテキスト")]
    Text _timerText;

    private void Awake()
    {
        TimeManager.Instance.StartTimer();
    }

    private void Update()
    {
        _timerText.text = TimeManager.Instance.Timer.ToString("f0");
    }
}
