using UnityEngine;

namespace PhiKiemSongHanh.Characters
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Player")]
        [SerializeField] private Transform _cameraTarget;

        private void Update()
        {
            FollowCameraTarget();
        }

        private void FollowCameraTarget()
        {
            if (_cameraTarget == null)
            {
                return;
            }

            transform.position = _cameraTarget.position;
            transform.rotation = _cameraTarget.rotation;
        }
    }
}
