using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AimInterractor : MonoBehaviour
{
    [SerializeField] private TimeComparer _comparer;
    
    [SerializeField] private Transform _marker;
 
    [SerializeField] private Transform _armPivot;
    private Vector3 _nullPosition;
    private Transform _lookPivot;
    private Camera _camera;
    [SerializeField] private float _distance = 300;
    private bool _isAiming;


    void Aiming()
    {
        Ray ray;
        RaycastHit hit;
        ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        _isAiming = false;
        bool hadHit = Physics.Raycast(ray, out hit, _distance);
        if (hadHit)
        {
            if (hit.transform.CompareTag("Interactable"))
            {
                _marker.position = hit.point;
                _isAiming = true;
            }
        }

        if (!_isAiming && _marker.transform.position != _nullPosition) 
            _marker.transform.position = _nullPosition;
    }

    void RotateArm()
    {
        Vector3 euler;
        euler = _armPivot.eulerAngles;
        //armPivot = lookPivot.eulerAngles;
        euler.x = _lookPivot.eulerAngles.x;
        _armPivot.eulerAngles = euler;
    }

    void Interaction()
    {
        Ray ray;
        RaycastHit hit;
        ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        
        bool hadHit = Physics.Raycast(ray, out hit, _distance);
        if (hadHit)
        {
            if (hit.transform.CompareTag("Interactable"))
            {
                Interactable interactable = hit.transform.gameObject.GetComponent<Interactable>();
                interactable.Interract();
            }
        }
    }

    private void Start()
    {
        _nullPosition = _marker.position;
        _camera = Camera.main;
        _lookPivot = _camera.transform;
    }

    private void Update()
    {
        RotateArm();
        Aiming();


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Interaction();
        }
    }
}
