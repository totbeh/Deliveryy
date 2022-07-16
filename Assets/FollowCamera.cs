using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
//The camera's postion in equal to the car's position
    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
