using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDay : MonoBehaviour
{
    [SerializeField]
    Text _dayText;

    [SerializeField]
    int _day;

    [SerializeField]
    float _timeOut;

    public void Start()
    {
        StartCoroutine(DayChange());
    }

    IEnumerator DayChange()
    {
        while (true)
        {
            _day++;
            _dayText.text = _day.ToString();
            yield return new WaitForSeconds(_timeOut);
            if(_day == 23)
            {
                _day = 23;
                _dayText.text = _day.ToString();
                break;
            }
        }
    }
}
