using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PasswordGenerator : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _passwordText;
    
    [Range(5,10)]
    [SerializeField]private int _lenght;

    private string _password;

    public void GeneratePassword()
    {
        string password = "";
        for (int i = 0; i < _lenght; i++)
        {
            int sumbol = Random.Range(1, 9);
            password += sumbol.ToString();
        }

        _passwordText.text = password;
        _password = password;
    }

    public string TakePassword()
    {
        return _password;
    }
}