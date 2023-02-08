using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRapidFire : PowerUpBase
{
    public TurretController turretController;
    //private void TurretController;

    protected override void OnHit()
    {
        base.OnHit();
    }

    protected override void PowerDown()
    {
        //return fire cooldown to default value
        turretController.FireCooldown = 0.5f;
        Destroy(gameObject);
    }

    protected override IEnumerator PowerUp(float PowerupDuration)
    {
        //increase fire rate by reducing the fire cooldown of the turret controller
        turretController = GameObject.Find("TurretController").GetComponent<TurretController>();
        turretController.FireCooldown = 0.25f;
        //wait for 2 seconds
        yield return new WaitForSecondsRealtime(PowerUpDuration);
        //call PowerDown
        Debug.Log("power down");
        PowerDown();
    }
}
