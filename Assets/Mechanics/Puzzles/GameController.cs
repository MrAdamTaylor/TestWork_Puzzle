using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private MechanismController _mechanismController;
    
    private bool _puzzleTreeSolving;
    private bool _puzzleTwoSolving;
    private bool _puzzleOneSolving;
    
    public void ThirdPuzzleSolved()
    {
        Debug.Log("Third Puzzle Solved");
        _puzzleTreeSolving = true;
        _mechanismController.StartThirdMechanism();
    }

    public void ThirdPuzzleUnresolved()
    {
        _puzzleTreeSolving = false;
        _mechanismController.StopThirdMechanism();
    }

    public void FirstPuzzleSolved()
    {
        Debug.Log("First Puzzle Solved");
        _puzzleOneSolving = true;
        _mechanismController.StartFirstMechanism();
    }
    
    public void FirstPuzzleUnresolved()
    {
        _puzzleOneSolving = false;
        _mechanismController.StopFirstMechanism();
    }
    
    public void SecondPuzzleSolved()
    {
        Debug.Log("Second Puzzle Solved");
        _puzzleTwoSolving = true;
        _mechanismController.StartSecondMechanism();
    }
    
    public void SecondPuzzleUnresolved()
    {
        _puzzleTwoSolving = false;
        _mechanismController.StopSecondMechanism();
    }
}