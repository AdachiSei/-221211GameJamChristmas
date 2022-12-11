using System.Collections;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDay : SingletonMonoBehaviour<ChangeDay>
{
    [SerializeField]
    Text _dayText;

    [SerializeField]
    int _day;

    [SerializeField]
    float _timeOut;

    [SerializeField]
    Transform _all;

    [SerializeField]
    GameObject _result;

    async public UniTask DayChange()
    {
        _all.transform.ChangePosY(540);
        while (true)
        {
            _day++;
            _dayText.text = _day.ToString();
            await UniTask.Delay((int)(_timeOut * 1000));
            if(_day == 24)
            {
                _day = 24;
                _dayText.text = _day.ToString();
                break;
            }
        }
        _result.gameObject.SetActive(true);
        _all.transform.ChangePosY(9999);
    }
}
