using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private PlayerSpawnPoint _playerSpawnPoint;
    [SerializeField] private GameObject _canvas;

    public void Death()
    {
        _canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _canvas.SetActive(false);
    }
}
