using System.Collections;
using UnityEngine;

public class ThirdMechanism : MonoBehaviour
{
    private bool _needMove;
    [SerializeField] private float _effectTime = 2f;

    public void Move()
    {
        _needMove = true;
        StartCoroutine(MakeStep());
    }

    public void StopMove()
    {
        _needMove = false;
        StopCoroutine(MakeStep());
    }
    
    private IEnumerator MakeStep()
    {
        Vector3 startScale = Constants.STANDART_SCALE;
        Vector3 targetScale = Constants.TARGET_SCALE;
        while (true)
        {
            float time = 0;

            while (time < Constants.MAX_SCALE_TIME)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, targetScale, time);
                time += Time.deltaTime * _effectTime;
                yield return null;
            }

            time = 0;

            while (time < Constants.MAX_SCALE_TIME)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, startScale, time);
                time += Time.deltaTime * _effectTime;
                yield return null;
            }
        }
    }
}