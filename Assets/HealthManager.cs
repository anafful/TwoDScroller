using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{

    #region Health
    public float maxHealth = 10f;
    [HideInInspector]
    public float currentHealth;
    public TMP_Text healthText;
    public Slider healthSlider;
    #endregion


    private void OnEnable()
    {
        PlayersDamage.OnSnowballAttack += UpdateHealthDisplay;
    }

    private void OnDisable()
    {
        PlayersDamage.OnSnowballAttack += UpdateHealthDisplay;

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
