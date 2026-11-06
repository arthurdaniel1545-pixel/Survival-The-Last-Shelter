using UnityEngine;

namespace SurvivalTheLastShelter.Player
{
    public sealed class ThirdPersonCameraController : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float distance = 5f;
        [SerializeField] private float minDistance = 2f;
        [SerializeField] private float maxDistance = 8f;
        [SerializeField] private float pitchMin = -30f;
        [SerializeField] private float pitchMax = 60f;
        [SerializeField] private float sensitivity = 2f;
        [SerializeField] private LayerMask collisionMask = ~0;

        private float _yaw;
        private float _pitch = 20f;

        public void AddLookInput(Vector2 delta)
        {
            _yaw += delta.x * sensitivity;
            _pitch -= delta.y * sensitivity;
            _pitch = Mathf.Clamp(_pitch, pitchMin, pitchMax);
        }

        public void SetDistance(float value)
        {
            distance = Mathf.Clamp(value, minDistance, maxDistance);
        }

        private void LateUpdate()
        {
            if (target == null) return;

            Quaternion rotation = Quaternion.Euler(_pitch, _yaw, 0f);
            Vector3 desiredPosition = target.position + rotation * new Vector3(0f, 0f, -distance);

            if (Physics.Linecast(target.position + Vector3.up * 1.5f, desiredPosition, out RaycastHit hit, collisionMask))
            {
                desiredPosition = hit.point + (target.position - hit.point).normalized * 0.2f;
            }

            transform.position = desiredPosition;
            transform.LookAt(target.position + Vector3.up * 1.5f);
        }
    }
}
