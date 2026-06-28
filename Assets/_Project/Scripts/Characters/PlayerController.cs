using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Transform _cameraTarget;

    private void CameraFollow()
    {
        if (_cameraTarget != null)
        {
            transform.position = _cameraTarget.position;
            transform.rotation = _cameraTarget.rotation;
        }
    }
}
