using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeComparer : MonoBehaviour
{
    [SerializeField]private FinishTimeGame _finisherGame;
    
    private static int _digitalMinute;
    private static int _arrowMinute;
    
    private static int _digitalHour;
    private static int _arrowHour;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Load(int hours, int minutes)
    {
        _digitalHour = hours;
        _digitalMinute = minutes;
    }

    public  void Compare()
    {
        if (_arrowHour == _digitalHour && _arrowMinute == _digitalMinute)
        {
            Debug.Log("Победа!");
            _finisherGame.Finish();
        }
    }

    public  void UpdateMinuteValue(float f)
    {
        float val = f / 6;
        
        //int value = (int)f;
        _arrowMinute = (int)val;
        Debug.Log("Минута сейчас "+_arrowMinute);
    }

    public void UpdateHourValue(float f)
    {
        float val = f / 15;
        //int value = (int)f;
        _arrowHour = (int)val;
        Debug.Log("Час сейчас "+_arrowHour);
    }
}
