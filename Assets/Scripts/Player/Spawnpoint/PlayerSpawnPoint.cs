using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    public void SetSpawnPointPlayerPosition()
    {
        transform.position = _spawnPoint.position;
    }
}
