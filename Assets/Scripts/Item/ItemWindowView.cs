using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ItemWindowView : MonoBehaviour
{
    public Item NowItem => _itemPrefabs[_nowIndex];

    [SerializeField]
    [Header("飾り付けのプレファブ")]
    Item[] _itemPrefabs;

    [SerializeField]
    [Header("飾り付けのUI")]
    Image[] _itemImage;

    [SerializeField]
    [Header("現在のアイテムの番号")]
    int _nowIndex;

    [SerializeField]
    [Header("選択したアイテムのUIの大きさ")]
    float _scale = 1.5f;

    int _coolTime = 100;
    int _privIndex;
    bool _isChanging = true;

    private const int DEFAULT_SCALE = 1;
    private const int OFFSET = 1;

    private void Update()
    {
        if (!_isChanging) return;
        if (Input.GetAxis(InputName.MOUSE_SCROLLWHEEL) < 0)
        {
            ChangeItem(OFFSET);
            _isChanging = false;
            Debug.Log(Input.GetAxis(InputName.MOUSE_SCROLLWHEEL));
        }
        else if (Input.GetAxis(InputName.MOUSE_SCROLLWHEEL) > 0)
        {
            ChangeItem(-OFFSET);
            _isChanging = false;
            Debug.Log(Input.GetAxis(InputName.MOUSE_SCROLLWHEEL));
        }
    }

    async void ChangeItem(int num)
    {
        _privIndex = _nowIndex;
        _nowIndex += num;
        if (_nowIndex >= _itemPrefabs.Length)
        {
            _nowIndex = 0;
        }
        else if (_nowIndex < 0)
        {
            _nowIndex = _itemPrefabs.Length - OFFSET;
        }
        _itemImage[_privIndex].gameObject.transform.ChangeScaleAll(DEFAULT_SCALE);
        _itemImage[_nowIndex].gameObject.transform.ChangeScaleAll(_scale);
        await UniTask.Delay(_coolTime);
        _isChanging = true;
    }
}
