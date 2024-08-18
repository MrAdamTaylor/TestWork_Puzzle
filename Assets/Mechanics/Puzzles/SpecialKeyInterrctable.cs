using UnityEngine;

public class SpecialKeyInterrctable : Interactable
{
    [SerializeField]private KeyValue _key;

    [SerializeField]private PasswordController _сontroller;
    
    public override void Interract()
    {
        switch (_key)
        {
            case KeyValue.Enter:
                _сontroller.Enter();
                break;
            case KeyValue.Exit:
                _сontroller.ResetInput();
                break;
        }
    }
}