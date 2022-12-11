using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : SingletonMonoBehaviour<CreateObject>
{
    [SerializeField]
    List<GameObject> _gameObjects = new();

    [SerializeField]
    GameObject[] _gameObject;

    int _num;

    [SerializeField]
    Transform _parent;
    public void Awake()
    {
        ObjectPool.CreatePool(_gameObjects,_gameObject[_num],1, _parent);
    }

    public void Create()
    {
        ObjectPool.CreatePool(_gameObjects, _gameObject[_num], 1, _parent);
        _num = Random.Range(0, _gameObject.Length);
        ObjectPool.UseObject(_gameObjects, _gameObject[_num], _parent);
    }
}
