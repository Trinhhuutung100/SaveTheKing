using System;
using UnityEngine;

public class EffectPool : PoolMember
{
    public ParticleSystem[] fxs;
    public float timePlayFx;

    // public void OnSpawnObject(Action OnComplete = null)
    // {
    //     foreach (ParticleSystem p in fxs)
    //     {
    //         p.Play();
    //     }
    //     if (timePlayFx == 0) { timePlayFx = 0.5f; }
    //     Timer.Schedule(this, timePlayFx, () =>
    //     {
    //         OnComplete?.Invoke();
    //         gameObject.SetActive(false);
    //         DespawnEffect();
    //     });
    // }

    // void DespawnEffect()
    // {
    //     PoolManager.Ins.Despawn(this);
    // }
}