using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] bool _isDead;
    [SerializeField] float delayTimeScale = 0f;
    public bool IsDead => _isDead;

    public event System.Action OnDead;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isDead = true;
        OnDead?.Invoke();
        Time.timeScale = delayTimeScale; // yavas cekim icin update icerisinde cagrilmali
    }

}
