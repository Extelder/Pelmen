using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleate : MonoBehaviour
{
    [SerializeField] private GameObject _compleateCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.TryGetComponent<PlayerMove>(out  PlayerMove move))
        {
            _compleateCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
