using System.Collections.Generic;
using UnityEngine;

public class HumanGeneration : MonoBehaviour
{
    [SerializeField]
    [Header("カップルのプレハブ")]
    GameObject _coplePrefab;

    [SerializeField]
    [Header("男性のプレハブ")]
    GameObject _manPrefab;

    [SerializeField]
    [Header("女性のプレハブ")]
    GameObject _womanPrefab;

    [SerializeField]
    [Header("初回生成数")]
    int _generationCount;

    [SerializeField]
    [Header("")]
    float _randomCount;

    [SerializeField]
    [Header("ランダムな数字")]
    int _randomNum;

    [System.Obsolete]
    private void Update()
    {
       _randomCount += Time.deltaTime;

        if(_randomCount >= 10f)
        {
            _randomNum = Random.RandomRange(0, 15);
            _randomCount = 0f;
            RandomCreate();
        }
    }

    private void RandomCreate()
    {
        switch (_randomNum)
        {
            //カップルの生成
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Instantiate(_coplePrefab);
                break;

            //男性の生成
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Instantiate(_manPrefab);
                break;

            //女性の生成
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                Instantiate<GameObject>(_womanPrefab);
                break;
        }
    }
}

