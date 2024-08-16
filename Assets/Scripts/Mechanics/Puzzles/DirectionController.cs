using UnityEngine;

public class DirectionController : MonoBehaviour
{

    [SerializeField]private GameController _gameController;
    
    private float _firstDirection;
    private float _secondDirection;
    private float _thirdDirection;
    
    public void AddDirectionData(PlateNum num, float directionValue)
    {
        switch (num)
        {
            case PlateNum.One:
                _firstDirection = directionValue;
                Debug.Log("FirstPlate "+_firstDirection);
                break;
            case PlateNum.Two:
                _secondDirection = directionValue;
                Debug.Log("SecondPlate "+_secondDirection);
                break;
            case PlateNum.Three:
                _thirdDirection = directionValue;
                Debug.Log("ThirdPlate "+_thirdDirection);
                break;
        }
    }

    public void CheckDirections()
    {
        if (Mathf.Approximately(_firstDirection, _secondDirection) &&
            (Mathf.Approximately(_firstDirection, _thirdDirection)))
        {
            _gameController.ThirdPuzzleSolved();
        }
        else
        {
            _gameController.ThirdPuzzleUnresolved();
        }
    }
}