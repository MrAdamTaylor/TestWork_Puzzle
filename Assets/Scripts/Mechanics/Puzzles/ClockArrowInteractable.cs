using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClockArrow
{
    Hour,
    Minute
}

public class ClockArrowInteractable : Interactable
{
    public ClockArrow ClockArrow;
    [SerializeField] private TimeComparer _comparer;

    public override void Interract()
    {
        if (ClockArrow == ClockArrow.Minute)
        {
            Vector3 vec = new Vector3(0,0,6f);
            transform.localEulerAngles += vec;
            _comparer.UpdateMinuteValue(transform.localEulerAngles.z);
        }
        else
        {
            Vector3 vec = new Vector3(0,0,15f);
            transform.localEulerAngles += vec;
            _comparer.UpdateHourValue(transform.localEulerAngles.z);
        }
        _comparer.Compare();
    }
}
