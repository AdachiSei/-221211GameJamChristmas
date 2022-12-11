using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 星、オーナメント、靴下、杖の飴、松ぼっくり、リボン、大きい星
/// </summary>
public class Item : MonoBehaviour
{
    public Sprite Decoration => _sprite;

    [SerializeField]
    [Header("名前")]
    string _name;

    [SerializeField]
    [Header("絵")]
    Sprite _sprite;
}
