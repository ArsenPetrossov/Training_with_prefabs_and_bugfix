using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);
    
    private void Start()
    {
        Instantiate(_wallPrefab,_targetPosition,_wallPrefab.rotation);
        //wall.position = _targetPosition;
    }
}
