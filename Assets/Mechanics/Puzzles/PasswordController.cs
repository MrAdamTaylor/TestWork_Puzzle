using System;
using TMPro;
using UnityEngine;

public class PasswordController : MonoBehaviour
{
    public TextMeshProUGUI Text;

    [SerializeField]private PasswordGenerator _passwordGenerator;

    [SerializeField] private GameController _gameController;
    
    private string _currentValue;

    private string _password;

    private void Start()
    {
        _currentValue = "";
        Text.text = _currentValue;
        _passwordGenerator.GeneratePassword();
        _password = _passwordGenerator.TakePassword();
    }

    public void InputKey(string s)
    {
        _currentValue += s;
        Text.text = _currentValue;
    }

    public void Enter()
    {
        if (_password == _currentValue)
        {
            _gameController.Execute(Constants.MOVE_MECHANISM);
        }
        else
        {
            _gameController.Stop(Constants.MOVE_MECHANISM);
        }
    }

    public void ResetInput()
    {
        Text.text = "";
        _currentValue = "";
    }
}