using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MechanismController : MonoBehaviour
{
    public List<Mechanism> Mechanisms;

    public void LaunchByValue(int value)
    {
        for (int i = 0; i < Mechanisms.Count; i++)
        {
            if (i == value)
            {
                Mechanisms[i].StartMechanism();
            }
        }
    }

    public void StopByValue(int value)
    {
        for (int i = 0; i < Mechanisms.Count; i++)
        {
            if (i == value)
            {
                Mechanisms[i].Stop();
            }
        }
    }
}

