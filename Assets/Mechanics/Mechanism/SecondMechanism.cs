using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class SecondMechanism : MonoBehaviour
{
    public float LerpSpeed = 0.1f;
    private bool _needMove;
    private IEnumerator _makeStepRoutine;

    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    
    public void Start()
    {
        _makeStepRoutine = SmoothLerp();
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
    
    private IEnumerator SmoothLerp()
    {
        transform.rotation = Quaternion.identity;

        while (true)
        {
            float time = 0;

            while (time < 1)
            {
                transform.position = Vector3.Lerp(_startPoint.position, _endPoint.position, time);
                time += Time.deltaTime * LerpSpeed;
                yield return null;
            }

            time = 0;

            while (time < 1)
            {
                transform.position = Vector3.Lerp(_endPoint.position, _startPoint.position, time);
                time += Time.deltaTime * LerpSpeed;
                yield return null;
            }
        }
    }
}