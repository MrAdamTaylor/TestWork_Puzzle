using System.Collections;
using UnityEngine;

public class SecondMechanism : Mechanism
{
    private float _lerpSpeed = 0.1f;
    private bool _needMove;

    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    public override void StartMechanism()
    {
        _needMove = true;
        StartCoroutine(SmoothLerp());
    }

    public override void Stop()
    {
        _needMove = false;
        StopCoroutine(SmoothLerp());
    }

    /*public void Move()
    {
        _needMove = true;
        StartCoroutine(SmoothLerp());
    }

    public void StopMove()
    {
        _needMove = false;
        StopCoroutine(SmoothLerp());
    }*/
    
    private IEnumerator SmoothLerp()
    {
        transform.rotation = Quaternion.identity;

        while (true)
        {
            float time = 0;

            while (time < 1)
            {
                transform.position = Vector3.Lerp(_startPoint.position, _endPoint.position, time);
                time += Time.deltaTime * _lerpSpeed;
                yield return null;
            }

            time = 0;

            while (time < 1)
            {
                transform.position = Vector3.Lerp(_endPoint.position, _startPoint.position, time);
                time += Time.deltaTime * _lerpSpeed;
                yield return null;
            }
        }
    }
}