using Components;
using Components.Model;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private SpawnComponent pauseSpawn;
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int speed;

    private Rigidbody _rigidbody;
    private GameSession _gameSession;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _gameSession = FindObjectOfType<GameSession>();
    }

    private void Update()
    {
        Time.timeScale = _gameSession.PauseDataModel.IsPause ? 0 : 1;

        if (!_gameSession.PauseDataModel.IsPause)
        {
            _rigidbody.AddRelativeForce(Vector3.forward * speed);

            var angel = Input.GetAxis("Horizontal") * rotationSpeed;
            transform.Rotate(0, angel, 0);
            
            if(Input.GetKeyDown(KeyCode.Escape)) pauseSpawn.SpawnInParent();
        }
    }
}