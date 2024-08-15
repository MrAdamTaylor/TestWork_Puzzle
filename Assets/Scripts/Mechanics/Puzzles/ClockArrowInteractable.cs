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
    
    public override void Interract()
    {
        if (ClockArrow == ClockArrow.Minute)
        {
            Vector3 vec = new Vector3(0,0,6f);
            transform.localEulerAngles += vec;
        }
        else
        {
            Vector3 vec = new Vector3(0,0,6f);
            transform.localEulerAngles += vec;
        }
    }
}
