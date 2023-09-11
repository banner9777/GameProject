using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        CheckPointUser user = other.GetComponent<CheckPointUser>();
        if(user)
        {
            user.m_checkPoint = this;
        }
    }

}
