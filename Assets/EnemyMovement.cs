using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    
    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;
    
    private int pathIndex = 0;
    private Transform target;
    
    // Start is called before the first frame update
    private void Start() {
        target = LevelManager.main.path[pathIndex];
    }

    // Update is called once per frame
    private void Update() {
        if (target == null)
        {
            target = LevelManager.main.path[pathIndex];
        }

        if(Vector2.Distance(target.position, transform.position) <= 0.1f) {
            pathIndex++;
            target = LevelManager.main.path[pathIndex];

            if (pathIndex >= LevelManager.main.path.Length) {
                Destroy(gameObject);
                return;
            }
        }
    }

private void FixedUpdate() {
    Vector2 direction = (target.position - transform.position).normalized;

    rb.velocity = direction * moveSpeed;
}

}
