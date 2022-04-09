using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private GameObject coinAudioPrefab = null;
    [SerializeField] private GameObject hurtAudioPrefab = null;

    private void CreateAudioObject(AudioObjectTypes audioType)
    {
        switch (audioType)
        {
            case AudioObjectTypes.COIN:
                Instantiate(coinAudioPrefab, Vector2.zero, Quaternion.identity);
                break;
            case AudioObjectTypes.HURT:
                Instantiate(hurtAudioPrefab, Vector2.zero, Quaternion.identity);
                break;
        }
    }
}

public enum AudioObjectTypes
{
    COIN,
    HURT
}