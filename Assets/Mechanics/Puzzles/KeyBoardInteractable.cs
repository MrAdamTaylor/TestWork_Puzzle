using UnityEngine;

public enum KeyValue
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Enter,
    Exit
}

//TODO - А если предположить, что клавишь будет несколько
public class KeyBoardInteractable : Interactable
{
    [SerializeField]private KeyValue _key;

    [SerializeField]private PasswordController _сontroller;
    
    public override void Interract()
    {
        switch (_key)
        {
            case KeyValue.One:
                _сontroller.InputKey("1");
                break;
            case KeyValue.Two:
                _сontroller.InputKey("2");
                break;
            case KeyValue.Three:
                _сontroller.InputKey("3");
                break;
            case KeyValue.Four:
                _сontroller.InputKey("4");
                break;
            case KeyValue.Five:
                _сontroller.InputKey("5");
                break;
            case KeyValue.Six:
                _сontroller.InputKey("6");
                break;
            case KeyValue.Seven:
                _сontroller.InputKey("7");
                break;
            case KeyValue.Eight:
                _сontroller.InputKey("8");
                break;
            case KeyValue.Nine:
                _сontroller.InputKey("9");
                break;
            case KeyValue.Enter:
                _сontroller.Enter();
                break;
            case KeyValue.Exit:
                _сontroller.ResetInput();
                break;
        }
    }
}