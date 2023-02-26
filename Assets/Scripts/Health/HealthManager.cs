using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{

    #region Health
    public int maxHealth = 100;
    [HideInInspector]
    public int currentHealth;
    public TMP_Text healthText;
    public Slider healthSlider;
    #endregion


    private void OnEnable()
    {
        SnowballDamage.OnSnowballAttack += UpdateHealthDisplay;
        HealthPickup.OnAddHealth += UpdateHealthDisplay;

    }

    private void OnDisable()
    {
        SnowballDamage.OnSnowballAttack -= UpdateHealthDisplay;
        HealthPickup.OnAddHealth -= UpdateHealthDisplay;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        healthText.text = "HP:" + currentHealth + "/" + maxHealth;

        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

}
