using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 200;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float slowSpeed = 5;
    [SerializeField] float boostSpeed = 15;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.tag == "Booster")
            {
              moveSpeed = boostSpeed;
            }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Slowdown")

            {
              moveSpeed = slowSpeed;
            }    
    }
}
