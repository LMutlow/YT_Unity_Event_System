using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinConterText = null;

    private void UpdateCoinCounter(int amount)
    {
        coinConterText.text = amount.ToString();
    }
}
