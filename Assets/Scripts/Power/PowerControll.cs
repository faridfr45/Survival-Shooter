using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerControll : MonoBehaviour
{
    public GameObject player;
    PlayerMovement playerMovement;
    PlayerHealth playerHealth;

    [Header("Speed Up")]
    // speedValue untuk jumlah pengingkatan kecepatan
    // duration adalah durasi kecepatan bertambah    
    public float SpeedValue = 3f;
    public float duration = 5f;

    bool isSpeed;
    float speedTimer;

    [Header("Heal")]
    public int healValue = 25;


    private void Start() 
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void Update() 
    {
        if(speedTimer > 0){
            speedTimer -= Time.deltaTime;
        }else if(speedTimer <= 0 && isSpeed){
            // jika player masih memiliki peningkatan kecepatan dan mengambil SpeedUp lagi maka kecepatannya tidak akan ditambah lagi melainkan durasinya saja
            playerMovement.speed -= SpeedValue;
            isSpeed = false;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "SpeedUp")
        {
            Destroy(other.gameObject, 0.1f);
            if(!isSpeed)
                playerMovement.speed += SpeedValue;
            
            speedTimer += duration;
            isSpeed = true;
        }
        else if(other.tag == "Heal")
        {
            Destroy(other.gameObject, 0.1f);
            playerHealth.Heal(healValue);
        }
    }

}
