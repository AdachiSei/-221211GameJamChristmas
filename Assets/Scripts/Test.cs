using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _gameObjects = new();

    [SerializeField]
    GameObject[] _gameObject;

    Vector3 _mousePosition;

    int _num;

    [SerializeField]
    Transform _parent;
    public void Awake()
    {
        ObjectPool.CreatePool(_gameObjects,_gameObject[_num],1, _parent);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _num = Random.Range(0, _gameObjects.Count);
            _mousePosition = Input.mousePosition;
            _mousePosition.z = 10.0f;
            //Instantiate(_gameObjects[_num], Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);

            ObjectPool.UseObject(_gameObjects, _gameObject[_num], _parent);
        }
    }
}
