using UnityEngine;
using UnityEngine.EventSystems;

namespace SurvivalTheLastShelter.Player
{
    public sealed class TouchInputController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementController movement;
        [SerializeField] private ThirdPersonCameraController cameraController;
        [SerializeField] private RectTransform joystickArea;
        [SerializeField] private float joystickRadius = 80f;

        private int _joystickFinger = -1;
        private Vector2 _joystickOrigin;

        private void Update()
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.position.x < Screen.width * 0.5f)
                {
                    HandleJoystick(touch);
                }
                else
                {
                    if (touch.phase == TouchPhase.Moved)
                    {
                        cameraController?.AddLookInput(touch.deltaPosition);
                    }
                }
            }
        }

        private void HandleJoystick(Touch touch)
        {
            if (touch.phase == TouchPhase.Began)
            {
                _joystickFinger = touch.fingerId;
                _joystickOrigin = touch.position;
            }

            if (touch.fingerId != _joystickFinger) return;

            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                _joystickFinger = -1;
                movement?.SetMoveInput(Vector2.zero);
                return;
            }

            Vector2 delta = touch.position - _joystickOrigin;
            Vector2 clamped = Vector2.ClampMagnitude(delta / joystickRadius, 1f);
            movement?.SetMoveInput(clamped);
        }

        public void OnRunPressed(bool pressed)
        {
            movement?.SetRun(pressed);
        }

        public void OnJumpPressed()
        {
            movement?.Jump();
        }

        public void OnCrouchPressed(bool pressed)
        {
            movement?.SetCrouch(pressed);
        }
    }
}
