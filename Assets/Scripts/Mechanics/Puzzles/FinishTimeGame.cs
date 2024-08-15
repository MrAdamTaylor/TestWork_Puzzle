using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishTimeGame : MonoBehaviour
{
    [SerializeField] private GameObject _playerBody;
    [SerializeField] private GameObject _camera;
    [SerializeField] private Canvas _canvas;

    public void Finish()
    {
        /*_playerBody.SetActive(false);
        _camera.SetActive(true);
        _canvas.gameObject.SetActive(true);*/
    }
}
