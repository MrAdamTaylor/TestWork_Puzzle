using System.Collections;
using System.Collections.Generic;

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

public class KeyBoardInteractable : Interactable
{
    public KeyValue Key;

    public PasswordController Controller;
    
    public override void Interract()
    {
        switch (Key)
        {
            case KeyValue.One:
                Controller.InputKey("1");
                break;
            case KeyValue.Two:
                Controller.InputKey("2");
                break;
            case KeyValue.Three:
                Controller.InputKey("3");
                break;
            case KeyValue.Four:
                Controller.InputKey("4");
                break;
            case KeyValue.Five:
                Controller.InputKey("5");
                break;
            case KeyValue.Six:
                Controller.InputKey("6");
                break;
            case KeyValue.Seven:
                Controller.InputKey("7");
                break;
            case KeyValue.Eight:
                Controller.InputKey("8");
                break;
            case KeyValue.Nine:
                Controller.InputKey("9");
                break;
            case KeyValue.Enter:
                Controller.Enter();
                break;
            case KeyValue.Exit:
                Controller.ResetInput();
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}