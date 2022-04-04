using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private float _posX;
    private float _posY;
    private float _posZ;
    private Vector3 _currentPos;

    public void Save()
    {
        Debug.Log(_currentPos.x);
        Debug.Log(_currentPos.y);
        Debug.Log(_currentPos.z);
        PlayerPrefs.SetFloat("PosX", _posX);
        PlayerPrefs.SetFloat("PosY", _posY);
        PlayerPrefs.SetFloat("PosZ", _posZ);
        PlayerPrefs.SetString("Rotation", _player.transform.rotation.ToString());
        PlayerPrefs.SetInt("SceneIndex", SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        _currentPos = _player.transform.position;
        _posX = _currentPos.x;
        _posY = _currentPos.y;
        _posZ = _currentPos.z;
    }

   
}
