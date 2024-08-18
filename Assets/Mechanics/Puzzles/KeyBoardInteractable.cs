using UnityEngine;

public enum KeyValue
{
    Enter,
    Exit
}

public class KeyBoardInteractable : Interactable
{
    [SerializeField]private string _key;

    [SerializeField]private PasswordController _сontroller;
    
    public override void Interract()
    {
        _сontroller.InputKey(_key);
    }
}

