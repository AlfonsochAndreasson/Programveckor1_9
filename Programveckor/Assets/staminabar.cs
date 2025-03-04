using UnityEngine;
using UnityEngine.UI;

public class staminaBar : MonoBehaviour
{
    public float stamina;
    public float dValue;
    public float maxStamina;
    public float maxValue;
    public float value;
    void Start()
    {
        maxStamina = stamina;
        maxValue = maxStamina;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            DecreaseEnergy();
        else if (stamina != maxStamina)
            IncreaseEnergy();
        ;
        
       
    }

    private void DecreaseEnergy()
    {
        if (stamina != 0)
            stamina -= dValue * Time.deltaTime;
    }

    private void IncreaseEnergy()
    {
        
            stamina += dValue * Time.deltaTime;
    }


}
