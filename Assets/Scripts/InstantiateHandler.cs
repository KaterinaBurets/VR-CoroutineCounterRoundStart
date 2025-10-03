using Unity.VisualScripting;
using UnityEngine;

public class InstantiateHandler : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints = new Transform[11];
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _allSpawnedGO;

    private GameObject _go;
    private Transform _spawnPoint;

    public void InstEnemy()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoint = _spawnPoints[i];
            _go = Instantiate(_enemyPrefab, _spawnPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)), _allSpawnedGO.transform);
        }
    }
    public void ArrayNull()
    {
        foreach (Transform child in _allSpawnedGO.transform)
        {
            Destroy(child.gameObject);
        }
    }
}