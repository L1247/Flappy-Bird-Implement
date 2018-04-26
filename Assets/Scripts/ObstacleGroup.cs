using UnityEngine;

public enum HoleDirectionType
{
    Up   = 1 ,
    Down = 2,
}

public class ObstacleGroup : MonoBehaviour
{
    [SerializeField] private Transform _obstacleUp , _obstacleDown;
    
    private float _totalY  = 10;
    private float _centerY = 5;
    
    public void SetChildSpacing(float randomSpacingY)
    {
        var intervalY = Random.Range(0f , _centerY);
        HoleDirectionType randomSpaceingType = (HoleDirectionType)
            (typeof(HoleDirectionType).GetRandomEnumValue());
        float downObstacleY = 0;
        float upObstacleY   = 0;
        switch (randomSpaceingType)
        {
            // hole up
            // 10 - 1  1
            // -5 + 5 -1 : Down
            //  5 + 5 : Up
            case HoleDirectionType.Up : 
                downObstacleY = -_centerY + intervalY - randomSpacingY;
                upObstacleY   = _centerY        + intervalY;
                break;
            // hole down
            //  1 - 10 1
            // -5 - 5 : Down
            //  5 - 5 +1 :Up
            case HoleDirectionType.Down :
                downObstacleY = -(_centerY + intervalY);
                upObstacleY   = (_centerY  - intervalY + randomSpacingY);
                break;
        }
        
        _obstacleDown.localPosition = Vector3.up * downObstacleY;
        _obstacleUp.localPosition   = Vector3.up * upObstacleY;
    }
}