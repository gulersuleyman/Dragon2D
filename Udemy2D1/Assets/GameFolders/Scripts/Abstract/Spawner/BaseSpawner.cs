using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    [Range(2f, 5f)]
    [SerializeField] float maxSpawnTime = 3f;

    [Range(0.3f, 1.5f)]
    [SerializeField] float minSpawnTime = 1f;

    

    float _curretnSpawnTime;
    float _timeBoundary;



    private void Start()
    {
        ResetTimes();
    }
    private void Update()
    {
        _curretnSpawnTime += Time.deltaTime;
        if (_curretnSpawnTime > _timeBoundary)
        {
            Spawn();
            ResetTimes();
        }
    }
    protected abstract void Spawn();
    
    private void ResetTimes()
    {
        _curretnSpawnTime = 0f;
        _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
