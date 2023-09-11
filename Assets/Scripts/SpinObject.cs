using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{

    public Vector3 m_axis;
    public float m_speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(m_axis, m_speed * Time.deltaTime);
    }
}
