using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : BaseSpawner
{

    protected override void Spawn()
    {
        EnemyController poolEnemy = ObstaclePool.Instance.Get();
        poolEnemy.transform.position = this.transform.position;
        poolEnemy.gameObject.SetActive(true);
    }
}
