using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanGeneration : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _man;

    [SerializeField]
    List<GameObject> _woman;

    [SerializeField]
    List<GameObject> _couple;

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
    [Header("生成するオブジェクトの位置")]
    Transform _generationObject;

    [SerializeField]
    [Header("初回生成数")]
    int _generationCount;

    void Awake()
    {
        ObjectPool.CreatePool(_couple, _coplePrefab, _generationCount, _generationObject);
        ObjectPool.CreatePool(_man, _manPrefab, _generationCount, _generationObject);
        ObjectPool.CreatePool(_woman, _womanPrefab, _generationCount, _generationObject);
        
    }

    void Update()
    {
        
    }
}
