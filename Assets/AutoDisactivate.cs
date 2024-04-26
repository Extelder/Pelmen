using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisactivate : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Disactivate());
    }

    private IEnumerator Disactivate()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}