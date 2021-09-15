using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectTile : MonoBehaviour
{
    [SerializeField] ProjectileController projectilePrefab;
    [SerializeField] Transform projectileTransform;
    [SerializeField] GameObject projectTileParent;
    [SerializeField] float delayProjectile=1f;

    float _currentDelayTime=0f;
    bool _canLaunch=false;
    private void Update()
    {
        _currentDelayTime += Time.deltaTime;
        if(_currentDelayTime >delayProjectile)
        {
            _canLaunch = true;
            _currentDelayTime = 0;
        }
    }

    public void LaunchAction()
    {
        if (_canLaunch)
        {
          ProjectileController newProjectile=  Instantiate
                (projectilePrefab, projectileTransform.position, projectileTransform.rotation);
newProjectile.transform.parent = projectTileParent.transform;
            _canLaunch = false;
        }
    }
}
