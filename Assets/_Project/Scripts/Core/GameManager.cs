using System.Collections;
using UnityEngine;

namespace PhiKiemSongHanh.Core
{
    public class GameManager : MonoBehaviour
    {
        [Header("Player")]
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private GameObject _playerPrefab2;

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
            return SpawnPrimaryPlayer();
        }

        public GameObject SpawnPrimaryPlayer()
        {
            return SpawnPlayerAt(_spawnPointIndex, _playerPrefab);
        }

        public GameObject SpawnSecondaryPlayer()
        {
            return SpawnPlayerAt(_spawnPointIndex, _playerPrefab2);
        }

        public GameObject SpawnPlayerAt(int index)
        {
            return SpawnPlayerAt(index, _playerPrefab);
        }

        private GameObject SpawnPlayerAt(int index, GameObject prefab)
        {
            if (prefab == null)
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

            if (_currentPlayer != null)
            {
                Destroy(_currentPlayer);
            }

            _currentPlayer = Instantiate(prefab, point.position, point.rotation);
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
}
