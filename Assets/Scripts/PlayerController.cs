using System;
using DefaultNamespace;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _sideSpeed = 20f;
    private Vector3 _startPos = new Vector3(0f, 1f, 0f);
    
    private void Start()
    {
        if (MainMenu.SetLoad == false)
        {
            transform.position = _startPos;
        }

        if (MainMenu.SetLoad == true)
        {
            var x = PlayerPrefs.GetFloat("PosX");
            var y = PlayerPrefs.GetFloat("PosY");
            var z = PlayerPrefs.GetFloat("PosZ");
            transform.position = new Vector3(x, y, z);
        }
    }

    private void Update()
    {
        MoveVer();
        Rotate();
    }

    private void Rotate()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0,moveHorizontal * 2,0);
    }
    
    private void MoveVer()
    {
        var moveVertical = Input.GetAxis("Vertical");
        transform.Translate(moveVertical * Vector3.forward * Time.deltaTime * _sideSpeed);
    }
}
