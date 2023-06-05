using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicators : MonoBehaviour
{
    public Image healthBar, foodBar;
    public float healthAmount = 100;
    public float foodAmount = 100;

    private float secondsToEmptyFood = 10f;
    private float secondsToEmptyHealth = 60f;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.fillAmount = healthAmount/100;
        foodBar.fillAmount = foodAmount/100;
    }

    // Update is called once per frame
    void Update()
    {
        if(foodAmount > 0)
        {
            foodAmount -= 100 / secondsToEmptyFood * Time.deltaTime;
            foodBar.fillAmount = foodAmount / 100;
        }
        if(foodAmount <= 0)
        {
            healthAmount -= 100 / secondsToEmptyHealth * Time.deltaTime;
            healthBar.fillAmount = healthAmount / 100;
        }
        
    }
}
