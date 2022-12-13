using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemys : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private float _spawnTime = 2f;
    [SerializeField] private int _countEnemy = 10;

    private Transform[] _points;
    
    private void Start()
    {
        _points=new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(SpawnEnemy(_spawnTime));
    }

    private IEnumerator SpawnEnemy(float spawnTime)
    {
        var waitSeconds=new WaitForSeconds(spawnTime);

        for (int i = 0; i < _countEnemy; i++)
        {
            Instantiate(_template, _points[Random.Range(0, _points.Length)].position, Quaternion.identity);

            yield return waitSeconds;
        }
    }
}
