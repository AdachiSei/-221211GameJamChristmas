using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    GameObject[] _gameObject;

    Vector3 mousePosition;

    int _num;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _num = Random.Range(0, _gameObject.Length);
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            Instantiate(_gameObject[_num], Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
        }
    }
}
