using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerUpDuration;

    protected abstract IEnumerator PowerUp(float PowerupDuration);

    protected abstract void PowerDown();

    protected virtual void OnHit()
    {
        Debug.Log("powerup acquired");
        //disable powerup visual & collider
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        //power up for duration
        StartCoroutine(PowerUp(PowerUpDuration));
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            OnHit();
        }
    }


}
