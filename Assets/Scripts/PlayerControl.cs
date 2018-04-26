using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float     MoveSpeed;
    [SerializeField] private int       _upForce = 300;
    private                  Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * _upForce , ForceMode.Force);
        }
    }
}