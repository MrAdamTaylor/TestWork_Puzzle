using System;
using TMPro;

public class PasswordController : PuzzleController
{
    public TextMeshProUGUI Text;
    
    private string _currentValue;

    private void Start()
    {
        _currentValue = "-";
        Text.text = _currentValue;
    }

    public void InputKey(string s)
    {
        _currentValue += s;
        Text.text = _currentValue;
    }

    public void Enter()
    {
        throw new System.NotImplementedException();
    }

    public void ResetInput()
    {
        Text.text = "-";
        _currentValue = "-";
    }
}