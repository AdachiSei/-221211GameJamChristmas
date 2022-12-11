using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeView : MonoBehaviour
{
    [SerializeField]
    [Header("制限時間")]
    float _limitTime = 30;

    [SerializeField]
    [Header("タイマーのテキスト")]
    Text _timerText;

    bool _isCounting = true;

    private void Awake()
    {
        TimeManager.Instance.StartTimer();
    }

    private void Update()
    {
        if (_limitTime - TimeManager.Instance.Timer < 0)
        {   
            if (_isCounting)
            {
                _timerText.text = "0";
                _isCounting = false;
                BackgroundManager.Instance.ChangeBackgrount();
            }
        }
        else
        {
            var timeLeft = _limitTime - TimeManager.Instance.Timer;
            _timerText.text = timeLeft.ToString("f0");
        }
    }
}
