using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private GameObject _playerPrefab;

    [Header("Spawn Points")]
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _spawnPointIndex = 0;

    [Header("Options")]
    [SerializeField] private bool _spawnOnStart = true;

    [Header("Time Delay")]
    [SerializeField] private float _timeDelay = 2f;

    private GameObject _currentPlayer;

    public GameObject CurrentPlayer => _currentPlayer;

    private void Start()
    {
        if (_spawnOnStart)
        {
            StartCoroutine(SpawnPlayerAfterDelay());
        }
    }

    private IEnumerator SpawnPlayerAfterDelay()
    {
        if (_timeDelay > 0f)
        {
            yield return new WaitForSeconds(_timeDelay);
        }

        SpawnPlayer();
    }

    public GameObject SpawnPlayer()
    {
        return SpawnPlayerAt(_spawnPointIndex);
    }

    public GameObject SpawnPlayerAt(int index)
    {
        if (_playerPrefab == null)
        {
            Debug.LogError("[GameManager] Chưa gán Player Prefab.", this);
            return null;
        }

        Transform point = GetSpawnPoint(index);
        if (point == null)
        {
            Debug.LogError($"[GameManager] Spawn point index {index} không hợp lệ.", this);
            return null;
        }

        _currentPlayer = Instantiate(_playerPrefab, point.position, point.rotation);
        return _currentPlayer;
    }

    private Transform GetSpawnPoint(int index)
    {
        if (_spawnPoints == null || _spawnPoints.Length == 0)
        {
            return null;
        }

        if (index < 0 || index >= _spawnPoints.Length)
        {
            return null;
        }

        return _spawnPoints[index];
    }
}
