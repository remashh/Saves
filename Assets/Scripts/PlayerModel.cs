using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    private float _sideSpeed = 20f;
    private float _leftBorder = -49f;
    private float _rightBorder = 49f;
    private float _frontBorder = 49f;
    private float _backBorder = -49f;
    private float _tilt = -1.5f;

    public float SideSpeed => _sideSpeed;
    public float LeftBorder => _leftBorder;
    public float FrontBorder => _frontBorder;
    public float BackBorder => _backBorder;
    public float RightBorder => _rightBorder;
    public float Tilt => _tilt;
}
