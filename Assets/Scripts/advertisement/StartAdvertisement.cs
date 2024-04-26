using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(YandexSDK))]
public class StartAdvertisement : MonoBehaviour
{
    [SerializeField] private float _delay;

    private YandexSDK _yandexSDK;

    private void OnEnable()
    {
        _yandexSDK = GetComponent<YandexSDK>();
        Invoke(nameof(ShowAD), _delay);
    }

    public void ShowAD()
    {
        _yandexSDK.ShowInterstitial();
    }
}
