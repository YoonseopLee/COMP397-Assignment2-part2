using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBarScreenSpaceController : MonoBehaviour
{
    [Header("Health Properties")]
    [Range(0, 100)]
    public int currentHealth = 100;
    [Range(1, 100)]
    public int maximumHealth = 100;

    private Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = GetComponent<Slider>();
        currentHealth = maximumHealth;
    }
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        healthBarSlider.value -= damage;
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            healthBarSlider.value = 0;
            currentHealth = 0;
        }
    }

    public void Healing(int currentHP)
    {
        healthBarSlider.value = currentHP;
        currentHealth = currentHP;
    }

        public void SetHealth(int healthValue)
    {
        healthBarSlider.value = healthValue;
        currentHealth = healthValue;
    }
    public void Reset()
    {
        healthBarSlider.value = maximumHealth;
        currentHealth = maximumHealth;
    }
}