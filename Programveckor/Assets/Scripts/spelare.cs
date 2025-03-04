using System.Collections;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;  // Vi anv�nder Unitys bibliotek 
using UnityEngine.UI;
public class MoveObject : MonoBehaviour 
{ 
    public float moveSpeed = 5f;  // Best�mmer hastigheten p� r�relsen 
    public Image StaminaBar;

    public float Stamina, MaxStamina;

    public float AttackCost;
    public float RunCost;
    public float ChargeRate;
    public Coroutine recharge;
    void Update() 
    { 
        // H�mta inmatning fr�n tangentbordet f�r v�nster/h�ger r�relse 
        float horizontalInput = Input.GetAxis("Horizontal"); 
         
        // Flytta objektet beroende p� inmatningen 
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        Stamina -= RunCost * Time.deltaTime;
        if (Stamina < 0) Stamina = 0;
        StaminaBar.fillAmount = Stamina / MaxStamina;

        if (recharge != null) StopCoroutine(recharge);
        recharge = StartCoroutine(RechargeStamina());
        
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("Attack!");
            Stamina -= AttackCost;
            if (Stamina < 0) Stamina = 0;
            StaminaBar.fillAmount = Stamina / MaxStamina;

            if (recharge != null) StopCoroutine(recharge);
            recharge = StartCoroutine(RechargeStamina());
        }
    } 
    private IEnumerator RechargeStamina()
    {
        yield return new WaitForSeconds(1f);

        while(Stamina < MaxStamina)
        {
            Stamina += ChargeRate / 10f;
            if (Stamina > MaxStamina) Stamina = MaxStamina;
            StaminaBar.fillAmount = Stamina / MaxStamina;
            yield return new WaitForSeconds(.1f);
        }
    }
} 
