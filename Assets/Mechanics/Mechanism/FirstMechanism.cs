using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class FirstMechanism : Mechanism
{
    [Range(1f,15f)] 
    [SerializeField] private float _rotateSpeed = 5f;
    private bool _needMove;

    public override void StartMechanism()
    {
        _needMove = true;
        StartCoroutine(MakeStep());
    }

    public override void Stop()
    {
        _needMove = false;
        StopCoroutine(MakeStep());
    }

    /*public void Move()
    {
        _needMove = true;
        StartCoroutine(MakeStep());
    }

    public void StopMove()
    {
        _needMove = false;
        StopCoroutine(MakeStep());
    }*/
    
    private IEnumerator MakeStep()
    {
        while (_needMove)
        {
            yield return null;
            Step();
        }
    }

    private void Step()
    {
        Vector3 vec = new Vector3(0,_rotateSpeed,0);
        transform.localEulerAngles += vec;
    }
}