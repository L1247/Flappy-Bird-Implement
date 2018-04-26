using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private float _offsetX;
    private float _scrollSpeed = 5;
    private float _reposLimit;
    private int _reimburse = 10;
    private void Start()
    {
        _offsetX = transform.Find("Up").localScale.x;
        _reposLimit = -_offsetX - _reimburse;
    }

    private void Update()
    {
        transform.position -= Vector3.right * _scrollSpeed * 0.1f;
        if (transform.localPosition.x <= _reposLimit)
        {
            transform.localPosition = Vector3.right * (_offsetX - _reimburse);
        }
    }
}