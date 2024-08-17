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
    [SerializeField] private PlateNum _num;
    [SerializeField] private DirectionController _directionController;

    public void Start()
    {
        int multipluer = Random.Range(Constants.MIN_PLATE_ANGLE, Constants.MAX_PLATE_ANGLE);
        Vector3 vec = new Vector3(0,Constants.PLATE_EULER_RATE*multipluer,0);
        transform.localEulerAngles += vec;
    }

    public override void Interract()
    {
        Vector3 vec = new Vector3(0,Constants.PLATE_EULER_RATE,0);
        transform.localEulerAngles += vec;
        _directionController.AddDirectionData(_num, transform.localEulerAngles.y);
        _directionController.CheckDirections();
    }
    
    
}