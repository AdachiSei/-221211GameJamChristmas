using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationsGenerator : SingletonMonoBehaviour<DecorationsGenerator>
{
    //int _random;
    Vector3 _mousePosition;

    Vector3 _objPosition;

    [SerializeField]
    ItemWindowView _itemWindowView;

    [SerializeField] 
    [Header("オブジェクトリスト")]
    List <GameObject> _objList;

    [SerializeField]
    [Header("親")]
    GameObject _parent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.Instance.PlaySFX("クリック");
            //_random = Random.Range(0, _objList.Count);
            _mousePosition = Input.mousePosition;
            _mousePosition.z = 10.0f;
            _objPosition = Camera.main.ScreenToWorldPoint(_mousePosition);
            var prefab = Instantiate(_itemWindowView.NowItem, _objPosition, Quaternion.identity);
            prefab.transform.SetParent(_parent.transform, true);
        }
    }


    public void Destroy()
    {
        Destroy(this);
    }
}
