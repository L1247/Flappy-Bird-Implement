using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public        Transform   Player;

    [SerializeField] private GameObject _obstacleGroup;
    [SerializeField] private Transform  _obstacleParentTransform;
    [SerializeField] private float      _xMin , _xMax , _yMin , _yMax;
    
    private int        _spawnIndex;
    private Transform  _lastGroupTransform;
    private Vector3    _lastSpwanPos = Vector3.zero;
    
    private void Awake()
    {
        Instance         = this;
    }

    // Use this for initialization
    void Start ()
    {
//        for (int i = 0 ; i < 5 ; i++)
//        {
//            SpawnObstale(5 * i , 0 * i);
//        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObstale();
        }
    }

    private void SpawnObstale()
    {
//        if (_lastGroupTransform)
//        {
//            Destroy(_lastGroupTransform.gameObject);
//        }

        _lastGroupTransform = Instantiate(_obstacleGroup , Vector3.zero ,
                                          Quaternion.identity,
                                          _obstacleParentTransform).transform;
        _lastGroupTransform.localPosition = _lastSpwanPos;
        var   obstacleGroup = _lastGroupTransform.GetComponent<ObstacleGroup>();
        float randomX       = Random.Range(_xMin , _xMax);
        float randomY       = Random.Range(_yMin , _yMax);
        obstacleGroup.SetChildSpacing(randomY);
        _lastSpwanPos += Vector3.right * randomX;
    }
}