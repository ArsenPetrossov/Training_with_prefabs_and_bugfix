using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        Instantiate(_wallPrefab);
        _wallPrefab.isKinematic = false;
    }
}
