using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeComparer : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    private static int _digitalMinute;
    private static int _arrowMinute;
    
    private static int _digitalHour;
    private static int _arrowHour;

    public void Load(int hours, int minutes)
    {
        _digitalHour = hours;
        _digitalMinute = minutes;
    }

    public  void Compare()
    {
        if (_arrowHour == _digitalHour && _arrowMinute == _digitalMinute)
        {
            _gameController.Execute(Constants.ROTATE_MECHANISM);
        }
        else
        {
            _gameController.Stop(Constants.ROTATE_MECHANISM);
        }
    }

    public  void UpdateMinuteValue(float f)
    {
        float val = f / 6;
        _arrowMinute = (int)val;
        Debug.Log("Minute Now "+_arrowMinute);
    }

    public void UpdateHourValue(float f)
    {
        float val = f / 15;
        _arrowHour = (int)val;
        Debug.Log("Hour Now "+_arrowHour);
    }
}
