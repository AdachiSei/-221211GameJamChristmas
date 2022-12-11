using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CreditManager : MonoBehaviour
{
    [SerializeField]
    [Header("クレジットのパネル")]
    Image _creditPanel;

    [SerializeField]
    [Header("パネルについているテキスト")]
    Text _credeiText;

    [SerializeField]
    [Header("表示する文字")]
    [TextArea]
    string _credit;

    [SerializeField]
    float _long = 180;

    [SerializeField]
    float _time = 10;

    private int _lines;
    private Vector3 _defaultPos;

    private void Awake()
    {
        _defaultPos = _credeiText.transform.position;
        _lines = _credit.Split('\n').Length;
        _credeiText.text = _credit;
    }

    public void StartCredit()
    {
        if (_creditPanel.gameObject.activeSelf)
        {
            _credeiText.transform.DOKill();
            _credeiText.transform.position = _defaultPos;
            _creditPanel.gameObject.SetActive(false);
            return;
        }
        _creditPanel.gameObject.SetActive(true);
        _credeiText.transform.DOMoveY(_lines * _long, _time);
    }
}
