using UnityEngine;

public enum ClockArrow
{
    Hour,
    Minute
}

public class ClockArrowInteractable : Interactable
{
    [SerializeField] private ClockArrow _clockArrow;
    [SerializeField] private TimeComparer _comparer;

    public override void Interract()
    {
        if (_clockArrow == ClockArrow.Minute)
        {
            Vector3 vec = new Vector3(0,0,Constants.MINUTE_EULER_CIRCLE);
            transform.localEulerAngles += vec;
            _comparer.UpdateMinuteValue(transform.localEulerAngles.z);
        }
        else
        {
            Vector3 vec = new Vector3(0,0,Constants.HOUR_EULER_CIRCLE);
            transform.localEulerAngles += vec;
            _comparer.UpdateHourValue(transform.localEulerAngles.z);
        }
        _comparer.Compare();
    }
}

