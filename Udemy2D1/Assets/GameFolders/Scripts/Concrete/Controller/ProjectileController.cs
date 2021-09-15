using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : LifeCycleController
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();

        if(enemy!=null)
        {
            GameManager.Instance.IncreaseScore();
            enemy.KillGameObject();
            
        }
        KillGameObject();
    }
    public override void KillGameObject()
    {
        Destroy(this.gameObject);
    }
}
