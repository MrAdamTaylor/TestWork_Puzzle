using System;
using System.Collections.Generic;
using UnityEngine;

public class MechanismController : MonoBehaviour
{
    [SerializeField] private FirstMechanism _firstMechanism;
    [SerializeField] private SecondMechanism _secondMechanism;
    [SerializeField] private ThirdMechanism _thirdMechanism;
    
    private bool _firstIsActive;
    private bool _secondIsActive;
    private bool _thirdIsActive;

    public void StartFirstMechanism()
    {
        if (!_firstIsActive)
        {
            _firstMechanism.Move();
            _firstIsActive = true;
        }
    }

    public void StopFirstMechanism()
    {
        _firstMechanism.StopMove();
        _firstIsActive = false;
    }

    public void StartSecondMechanism()
    {
        if (!_secondIsActive)
        {
            _secondMechanism.Move();
            _secondIsActive = true;
        }
    }

    public void StopSecondMechanism()
    {
        _secondMechanism.StopMove();
        _secondIsActive = false;
    }
    
    public void StartThirdMechanism()
    {
        if (!_thirdIsActive)
        {
            _thirdMechanism.Move();
            _thirdIsActive = true;
        }
    }

    public void StopThirdMechanism()
    {
        _thirdMechanism.StopMove();
        _thirdIsActive = false;
    }

}