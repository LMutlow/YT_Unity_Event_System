using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel = null;

    private void ActivateDeathPanel()
    {
        deathPanel.SetActive(true);
    }
}