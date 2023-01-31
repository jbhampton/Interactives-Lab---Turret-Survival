using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerUpDuration;

    protected abstract void PowerUp();

    protected abstract void PowerDown();

    protected void OnHit()
    {
        PowerUp();
    }

    
}
