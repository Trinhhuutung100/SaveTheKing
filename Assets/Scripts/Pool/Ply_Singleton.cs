using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ply_Singleton<T> : GameUnit
{
    public static T instance;

    public virtual void Awake()
    {
        instance = GetComponent<T>();
    }
}
