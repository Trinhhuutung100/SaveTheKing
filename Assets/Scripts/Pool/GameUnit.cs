using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnit : MonoBehaviour
{
    public Transform tf;
    protected virtual void Awake()
    {
        tf = GetComponent<Transform>();
    }
}
