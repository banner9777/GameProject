using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        CheckPointUser user = other.GetComponent<CheckPointUser>();
        if (user)
        {
            user.TeleportBack();
            Rigidbody userRB = user.GetComponent<Rigidbody>();
            if (userRB)
            {
                userRB.velocity = Vector3.zero;
                userRB.angularVelocity = Vector3.zero;
            }
        }
    }
}
