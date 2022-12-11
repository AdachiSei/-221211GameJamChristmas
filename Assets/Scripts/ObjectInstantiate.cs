using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInstantiate : MonoBehaviour
{
    int _randomObj;

    Vector3 mousePosition;

    [SerializeField]
    [Header("オブジェクトリスト")]
    List<Image> _objList = new();

    [SerializeField]
    GameObject _a;

    [SerializeField]
    [Header("Cancas")]
    GameObject _parent;

    void Update()
    {
        Touch();
    }

    void Touch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _randomObj = Random.Range(0, _objList.Count);
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            var prefab = Instantiate(_objList[_randomObj], Camera.main.WorldToScreenPoint(mousePosition), Quaternion.identity);
            prefab.transform.SetParent(_parent.transform, false);
        }
    }
}
