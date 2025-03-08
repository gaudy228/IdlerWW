using UnityEngine;
public class UILookAt : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        transform.LookAt(Camera.main.transform);
    }
}
