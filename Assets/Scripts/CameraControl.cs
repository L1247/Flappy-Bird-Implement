using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform _player;
    private void Start()
    {
        _player = GameManager.Instance.Player;
    }

    private void Update()
    {
        Vector3 playerPos = _player.position;
        Vector3 pos = transform.position;
        pos.x = playerPos.x - 5;
        transform.position = pos;
    }
}