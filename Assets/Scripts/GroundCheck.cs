using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private int colliderAmount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        colliderAmount++;
    }

    private void OnCollisionExit(Collision collision)
    {
        colliderAmount--;
    }

    public bool Grounded()
    {
        return colliderAmount > 0;
    }
}
