using UnityEngine;

namespace Raketa420
{
    public class UserInput : MonoBehaviour
    {
        [SerializeField] Joystick joystick;

        public bool IsEnabled { get; private set; }

        public void Initialize()
        {
            Enable(true);
        }

        public void Enable(bool isActive)
        {
            IsEnabled = isActive;
        }

        public bool IsJoystickDragged()
        {
            return joystick.Horizontal != 0f || joystick.Vertical != 0f;
        }

        public Vector3 GetInputDirection()
        {
            return joystick.Direction;
        }
    }
}