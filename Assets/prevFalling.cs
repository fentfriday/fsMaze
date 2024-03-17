using UnityEngine;

public class prevFalling : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Disable gravity for this object
        rb.useGravity = false;
    }
}
