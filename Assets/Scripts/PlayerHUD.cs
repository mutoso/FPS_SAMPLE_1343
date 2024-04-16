using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
    }

    public void setCurrentAmmo(int ammo)
    {
        currentAmmoText.text = ammo.ToString().PadLeft(2, '0');
    }

    public void LowerHealth()
    {
        healthBar.fillAmount -= 0.1f;
    }
}
