using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroy : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
        print("a");
    }
}
