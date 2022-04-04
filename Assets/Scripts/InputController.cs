using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class InputController : MonoBehaviour
    {
        public event Action<float> HorizontalPressed;
        public event Action<float> VerticalPressed;

        public void Update()
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                HorizontalPressed?.Invoke(UnityEngine.Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                VerticalPressed?.Invoke(UnityEngine.Input.GetAxis("Vertical"));
            }
        }
    }
}