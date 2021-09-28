using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private void Start() {
        // object akan hancur setelah 10 detik jika tidak diambil oleh player
        Destroy(this.gameObject, 10f);
    }
    
    private void Update() 
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }

}
