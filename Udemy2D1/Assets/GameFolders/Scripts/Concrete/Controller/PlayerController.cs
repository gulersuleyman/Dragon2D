using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    
    Rigidbody2D _rigidbody2D;
    Jump _jump;
    InputController _input;
    LaunchProjectTile _launchProjectTile;
    Dead _dead;
    bool _isLeftMouseClicked;

    
    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _jump = GetComponent<Jump>();
        _launchProjectTile = GetComponent<LaunchProjectTile>();
        _dead = GetComponent<Dead>();
        _input = new InputController();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_dead.IsDead) return;

        if(_input.LeftMouseClickDown)
        {
            _isLeftMouseClicked = true;
        }
        if(_input.RightMouseClickDown)
        {
            _launchProjectTile.LaunchAction();
        }
    }
    private void FixedUpdate()
    {
        if (_isLeftMouseClicked)
        {
            _jump.JumpAction(_rigidbody2D);

            _isLeftMouseClicked = false;
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //   GameManager.Instance.RestartGame();
    //}
}
