using System;
using UnityEngine;
using Random = UnityEngine.Random;

public enum PlateNum
{
    One,
    Two,
    Three
}

public class DirectionInterract : Interactable
{
    public PlateNum Num;
    
    [SerializeField]private DirectionController _directionController;

    public void Start()
    {
        int multipluer = Random.Range(1, 35);
        Vector3 vec = new Vector3(0,10f*multipluer,0);
        transform.localEulerAngles += vec;
    }

    public override void Interract()
    {
        Vector3 vec = new Vector3(0,10f,0);
        transform.localEulerAngles += vec;
        _directionController.AddDirectionData(Num, transform.localEulerAngles.y);
        _directionController.CheckDirections();
    }
    
    
}