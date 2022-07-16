using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    
    bool hasPackage ;
    [SerializeField] float DestroyDelay = 0;

    SpriteRenderer ahmed; 
    void Start() 
    {
        ahmed = GetComponent<SpriteRenderer>();
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up.");
            ahmed.color = hasPackageColor;
            hasPackage = true;
            Destroy(other.gameObject,DestroyDelay);

        }
        
        if(other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package Delivered.");
            hasPackage = false;
            ahmed.color = noPackageColor;
        }

    }
}