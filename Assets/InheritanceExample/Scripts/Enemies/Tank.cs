using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    [SerializeField] float stunDuration = 1f;
    
    private bool waiting;
      

    protected override void OnHit()
    {
        //pause movement on hit
        StartCoroutine(Stun(stunDuration));
        
    }

       
    private IEnumerator Stun(float duration)
    {
        waiting = true;
        MoveSpeed = 0;
        yield return new WaitForSecondsRealtime(duration);
        MoveSpeed = 0.05f;
        waiting = false;
    }
    
}
