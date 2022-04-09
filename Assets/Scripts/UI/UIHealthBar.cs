using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar = null;

    private void UpdateHealthBar(float health)
    {
        healthBar.fillAmount = health / 100f;
    }
}
