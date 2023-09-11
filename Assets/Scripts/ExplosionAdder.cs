using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAdder : MonoBehaviour
{

    public float m_explosionForce;
    public float m_explosionRadius;
    private List<Rigidbody> m_affectedRigidbodies = new();
    public Camera m_screenCamera;

    public float cooldown = 1f;

    private float cooldownTimer = 0f;

    private void Awake()
    {
        m_affectedRigidbodies.AddRange(FindObjectsOfType<Rigidbody>());
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_screenCamera == null)
            m_screenCamera = Camera.main;
        if (m_screenCamera && Input.GetMouseButton(0) && cooldownTimer >= cooldown)
        {
            foreach (var rb in m_affectedRigidbodies)
            {
                if (!rb.GetComponent<GroundCheck>() || rb.GetComponent<GroundCheck>().Grounded())
                    rb.AddExplosionForce(m_explosionForce, m_screenCamera.ScreenToWorldPoint(Input.mousePosition - new Vector3(0, 0, m_screenCamera.transform.position.z + Random.Range(-1f, 1f))), m_explosionRadius, 1.25f, ForceMode.Impulse);
            }
            cooldownTimer = 0f;
        }
        if (cooldownTimer <= cooldown)
            cooldownTimer += Time.fixedDeltaTime;
    }
}
