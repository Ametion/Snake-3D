using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [Range(1, 5)] [SerializeField] private int _rotationSpeed;
    [Range(1, 10)][SerializeField] private int _speed;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.AddRelativeForce(Vector3.forward * _speed);
        
        var angel = Input.GetAxis("Horizontal") * _rotationSpeed;
        transform.Rotate(0, angel, 0);
    }
}