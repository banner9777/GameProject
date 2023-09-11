using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointUser : MonoBehaviour
{
    public CheckPoint m_checkPoint;

    public void TeleportBack()
    {
        if (m_checkPoint != null)
        {
            transform.position = m_checkPoint.transform.position;
            transform.rotation = m_checkPoint.transform.rotation;
        }
    }
}
