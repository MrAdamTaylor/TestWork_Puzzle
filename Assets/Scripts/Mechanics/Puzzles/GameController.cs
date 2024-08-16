using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool _puzzleTreeSolving;
    private bool _puzzleTwoSolving;
    private bool _puzzleOneSolving;
    
    public void ThirdPuzzleSolved()
    {
        Debug.Log("Третья загадка решена");
        _puzzleTreeSolving = true;
    }

    public void ThirdPuzzleUnresolved()
    {
        _puzzleTreeSolving = false;
    }

    public void FirstPuzzleSolved()
    {
        Debug.Log("Первая загадка решена");
        _puzzleOneSolving = true;
    }
    
    public void FirstPuzzleUnresolved()
    {
        _puzzleOneSolving = false;
    }
    
    public void SecondPuzzleSolved()
    {
        Debug.Log("Вторая загадка решена");
        _puzzleTwoSolving = true;
    }
    
    public void SecondPuzzleUnresolved()
    {
        _puzzleTwoSolving = false;
    }
}