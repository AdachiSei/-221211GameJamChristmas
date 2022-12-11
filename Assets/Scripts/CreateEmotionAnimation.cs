using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEmotionAnimation : SingletonMonoBehaviour<CreateEmotionAnimation>
{
    [SerializeField]
    List<GameObject> _gameObjects = new();

    [SerializeField]
    GameObject[] _gameObject;

    int _num;

    [SerializeField]
    Transform _parent;

    protected override void Awake()
    {
        base.Awake();
        ObjectPool.CreatePool(_gameObjects,_gameObject[_num],1, _parent);
    }

    public void Create()
    {
        _num = Random.Range(0, _gameObject.Length);
        ObjectPool.UseObject(_gameObjects, _gameObject[_num], _parent);
    }
}
