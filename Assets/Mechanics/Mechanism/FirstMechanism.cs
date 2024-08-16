using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class FirstMechanism : MonoBehaviour
{
    private bool _needMove;
    private IEnumerator _makeStepRoutine;
    [Range(1f,15f)]public float RotateSpeed = 5f;
    public void Start()
    {
        _makeStepRoutine = MakeStep();
    }

    public void Move()
    {
        _needMove = true;
        StartCoroutine(_makeStepRoutine);
    }

    public void StopMove()
    {
        _needMove = false;
        StopCoroutine(_makeStepRoutine);
    }
    
    private IEnumerator MakeStep()
    {
        while (_needMove)
        {
            yield return null;
            yield return null;
            yield return null;
            Step();
        }
    }

    private void Step()
    {
        Vector3 vec = new Vector3(0,RotateSpeed,0);
        transform.localEulerAngles += vec;
    }
}