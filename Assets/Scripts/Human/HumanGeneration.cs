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
    GameObject _coplePrefab;

    [SerializeField]
    [Header("生成するオブジェクトの位置")]
    Transform _generationObject;

    [SerializeField]
    [Header("初回生成数")]
    int _generationCount;

    void Awake()
    {
        ObjectPool.CreatePool<GameObject>(_couple, _coplePrefab, _generationCount, _generationObject);
    }

    void Update()
    {
        
    }
}
