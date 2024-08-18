using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private MechanismController _mechanismController;

    public void Execute(int value)
    {
        _mechanismController.LaunchByValue(value);
        
    }

    public void Stop(int value)
    {
        _mechanismController.StopByValue(value);
        
    }
}