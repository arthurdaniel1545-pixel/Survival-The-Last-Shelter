using UnityEngine;
using SurvivalTheLastShelter.Player;

namespace SurvivalTheLastShelter.Player
{
    [RequireComponent(typeof(CharacterController))]
    public sealed class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private float walkSpeed = 3.5f;
        [SerializeField] private float runSpeed = 6.0f;
        [SerializeField] private float crouchSpeed = 1.8f;
        [SerializeField] private float jumpHeight = 1.2f;
        [SerializeField] private float gravity = -18f;
        [SerializeField] private float rotationSpeed = 12f;

        [SerializeField] private PlayerSurvivalStats survivalStats;

        private CharacterController _controller;
        private Vector3 _velocity;
        private bool _isCrouching;
        private bool _isRunning;

        public bool IsRunning => _isRunning;
        public bool IsCrouching => _isCrouching;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        public void SetMoveInput(Vector2 input)
        {
            // Stored by external input system.
            _moveInput = Vector3.ClampMagnitude(new Vector3(input.x, 0f, input.y), 1f);
        }

        public void SetLookYaw(float yaw)
        {
            // Camera yaw is handled by the camera controller; movement uses world input.
        }

        public void SetRun(bool run)
        {
            _isRunning = run && survivalStats != null && survivalStats.Stamina.Current > 5f;
        }

        public void SetCrouch(bool crouch)
        {
            _isCrouching = crouch;
        }

        public void Jump()
        {
            if (_controller.isGrounded)
            {
                _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }

        private Vector3 _moveInput;

        private void Update()
        {
            if (_controller.isGrounded && _velocity.y < 0f)
            {
                _velocity.y = -2f;
            }

            float speed = _isCrouching ? crouchSpeed : (_isRunning ? runSpeed : walkSpeed);
            Vector3 motion = transform.TransformDirection(_moveInput) * speed;
            _controller.Move(motion * Time.deltaTime);

            if (_isRunning && _moveInput.sqrMagnitude > 0.01f && survivalStats != null)
            {
                survivalStats.Stamina.DrainPerSecond = 10f;
            }
            else if (survivalStats != null)
            {
                survivalStats.Stamina.DrainPerSecond = 0f;
            }

            if (_moveInput.sqrMagnitude > 0.01f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(new Vector3(_moveInput.x, 0f, _moveInput.z), Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            _velocity.y += gravity * Time.deltaTime;
            _controller.Move(_velocity * Time.deltaTime);
        }
    }
}
