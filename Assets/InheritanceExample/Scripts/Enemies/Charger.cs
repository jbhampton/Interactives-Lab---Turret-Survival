using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    protected override void OnHit()
    {
        //increase speed when hit
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        Instantiate(powerUpDrop, transform.position, Quaternion.identity);
        base.Kill();
    }
}
