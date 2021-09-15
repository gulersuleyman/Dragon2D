using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour
{
    [SerializeField] float maxLifeTime = 5f;
    protected float _currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > maxLifeTime)
        {
            KillGameObject();
        }
    }
    public abstract void KillGameObject();
}
