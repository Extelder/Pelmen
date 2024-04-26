using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevelCompleate : MonoBehaviour
{
    [SerializeField] private int _lastSceneIndex;

    public void LevelCompleate()
    {
        if(SceneManager.GetActiveScene().buildIndex != _lastSceneIndex)
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
