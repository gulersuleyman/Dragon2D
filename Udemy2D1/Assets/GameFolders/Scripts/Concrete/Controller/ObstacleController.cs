using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : EnemyController
{
    public override void SetEnemyPool()
    {
        ObstaclePool.Instance.Set(this);
    }
}
