using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    [SerializeField]
    float moveSpeed;
    Vector2 moveToPos;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = FindObjectOfType<PlayerMovement>().gameObject.transform;
        moveToPos = playerTransform.position;
    Destroy(gameObject, 2.05f);    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, moveToPos, Time.deltaTime * moveSpeed);
    }
}
