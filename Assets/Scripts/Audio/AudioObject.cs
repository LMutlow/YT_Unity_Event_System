using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioObject : MonoBehaviour
{
    [SerializeField] private bool randomPitch = false;
    [SerializeField] private float pitchMin = 0.9f;
    [SerializeField] private float pitchMax = 1.1f;

    private AudioSource audioSource = null;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if(randomPitch)
        {
            audioSource.pitch = Random.Range(pitchMin, pitchMax);
        }
        audioSource.Play();
        StartCoroutine(WaitThenDestroy(audioSource.clip.length));
    }

    private IEnumerator WaitThenDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}