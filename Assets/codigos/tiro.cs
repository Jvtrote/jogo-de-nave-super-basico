using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Fire();
        }
    
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
        
    
}
