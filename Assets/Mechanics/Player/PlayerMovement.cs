using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField]private float _moveSpeed;

    [SerializeField]private float _groundDrag;

    [SerializeField]private float _jumpForce;
    [SerializeField]private float _jumpCooldown;
    [SerializeField]private float _airMultiplier;

    [Header("Keybinds")]
    [SerializeField]private KeyCode _jumpKey = KeyCode.Space;
   
    [Header("Ground Check")] 
    [SerializeField]private Transform _groundCheckPoint;

    [SerializeField]private float _playerHeight;
    [SerializeField]private LayerMask _whatIsGround;
    
    bool _readyToJump;
    bool _grounded;

    [SerializeField]private Transform _orientation;

    float _horizontalInput;
    float _verticalInput;

    Vector3 _moveDirection;

    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;

        _readyToJump = true;
    }

    private void Update()
    {
        _grounded = Physics.Raycast(_groundCheckPoint.position, Vector3.down, _playerHeight * 0.5f + 0.3f, _whatIsGround);
        MyInput();
        SpeedControl();

        if (_grounded)
            _rigidbody.drag = _groundDrag;
        else
            _rigidbody.drag = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(_jumpKey) && _readyToJump && _grounded)
        {
            _readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), _jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        _moveDirection = _orientation.forward * _verticalInput + _orientation.right * _horizontalInput;

        if(_grounded)
            _rigidbody.AddForce(_moveDirection.normalized * _moveSpeed * Constants.FORCE_MULTIPLIER, ForceMode.Force);

        else if(!_grounded)
            _rigidbody.AddForce(_moveDirection.normalized * _moveSpeed * Constants.FORCE_MULTIPLIER * _airMultiplier, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);

        if(flatVel.magnitude > _moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * _moveSpeed;
            _rigidbody.velocity = new Vector3(limitedVel.x, _rigidbody.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);

        _rigidbody.AddForce(transform.up * _jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        _readyToJump = true;
    }
}