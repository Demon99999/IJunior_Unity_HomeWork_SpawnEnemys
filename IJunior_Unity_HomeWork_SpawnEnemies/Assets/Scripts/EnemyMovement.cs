using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _pointArrival;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _pointArrival.position, _speed * Time.deltaTime);

        if (transform.position == _pointArrival.position)
        {
            Destroy(this.gameObject);
        }
    }
}
