using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            _canvas.gameObject.SetActive(!_canvas.gameObject.activeSelf);
        }
    }
}