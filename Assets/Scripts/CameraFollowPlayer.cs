using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public Transform m_FollowPlayerTransform;
    public float speed = 2.0f;

    // Update is called once per frame
    void LateUpdate()
    {
        float cameraZ = transform.position.z;
        if (m_FollowPlayerTransform != null)
            transform.position = Vector3.Lerp(transform.position, m_FollowPlayerTransform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, transform.position.y, cameraZ);
    }
}
