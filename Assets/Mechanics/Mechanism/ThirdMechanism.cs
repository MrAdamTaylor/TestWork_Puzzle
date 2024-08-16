using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class ThirdMechanism : MonoBehaviour
{
    private bool _needMove;
    private IEnumerator _makeStepRoutine;
    [SerializeField] private float effectTime = 2f;

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
        Vector3 startScale = new Vector3(1f,1f,1f);
        Vector3 targetScale = new Vector3(2f,2f,2f);
        while (true)
        {
            float time = 0;

            while (time < 1)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, targetScale, time);
                time += Time.deltaTime * effectTime;
                yield return null;
            }

            time = 0;

            while (time < 1)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, startScale, time);
                time += Time.deltaTime * effectTime;
                yield return null;
            }
        }
    }

    private void Step()
    {
        Vector3 vec = new Vector3(0.1f,0.1f,0.1f);
        for (int i = 0; i < 10; i++)
        {
            transform.localScale += vec;
        }
        for (int i = 0; i < 10; i++)
        {
            transform.localScale -= vec;
        }

    }
}