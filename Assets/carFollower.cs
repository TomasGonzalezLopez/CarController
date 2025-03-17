using UnityEngine;

public class carFollower : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
        transform.LookAt(target);
    }
}
