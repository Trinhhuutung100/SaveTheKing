using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolType
{
    Default,
    Box,
    Screw,
}

[System.Serializable]
public struct PoolAmount
{
    public PoolType type;
    public int amount;
    public PoolMember gameUnit;
}

public class PoolManager : Ply_Singleton<PoolManager>
{
    public PoolAmount[] poolAmounts;


    private Dictionary<PoolType, Queue<GameUnit>> dict = new Dictionary<PoolType, Queue<GameUnit>>();

    public override void Awake()
    {
        base.Awake();
        OnInit();
    }

    private void OnInit()
    {
        for (int i = 0; i < poolAmounts.Length; i++)
        {
            if (!dict.ContainsKey(poolAmounts[i].type))
            {
                dict[poolAmounts[i].type] = new Queue<GameUnit>();
            }

            for (int j = 0; j < poolAmounts[i].amount; j++)
            {
                GameUnit gameUnit = Instantiate(poolAmounts[i].gameUnit);
                gameUnit.gameObject.SetActive(false);
                dict[poolAmounts[i].type].Enqueue(gameUnit);
            }
        }
    }

    public GameUnit Spawn(PoolType poolType, Vector3 pos, Quaternion rot)
    {
        GameUnit gameUnit = dict[poolType].Count > 0 ? dict[poolType].Dequeue() : Instantiate(GetPrefab(poolType));

        gameUnit.tf.SetPositionAndRotation(pos, rot);
        gameUnit.gameObject.SetActive(true);

        return gameUnit;
    }

    public T Spawn<T>(PoolType poolType, Vector3 pos = default, Quaternion rot = default) where T : GameUnit
    {
        return Spawn(poolType, pos, rot) as T;
    }

    public void Despawn(PoolMember gameUnit)
    {
        gameUnit.gameObject.transform.SetParent(tf);
        gameUnit.gameObject.SetActive(false);
        dict[gameUnit.poolType].Enqueue(gameUnit);
    }


    public GameUnit GetPrefab(PoolType poolType)
    {
        for (int i = 0; i < poolAmounts.Length; i++)
        {
            if (poolAmounts[i].type == poolType)
            {
                return poolAmounts[i].gameUnit;
            }
        }

        return null;
    }
}