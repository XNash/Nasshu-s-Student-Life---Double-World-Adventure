using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PartnerFollow : MonoBehaviour
{
    //public Rigidbody2D target;
    public int numFrames = 10;

    public Rigidbody2D rb;
    public Animator animator;
    private Vector3 lastPosition;
    public Transform playerTransform;
    public Rigidbody2D playerRB;
    Queue<Vector3> targetMovement;
    Vector3 prevPlayerPosition;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        lastPosition = gameObject.transform.position;
        targetMovement = new Queue<Vector3>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    void FixedUpdate()
    {
        animate();

        if (playerRB.velocity != Vector2.zero)
            targetMovement.Enqueue(playerTransform.transform.position);

        if (targetMovement.Count > numFrames)
        {
            transform.position = targetMovement.Dequeue();
        }
    }

    void animate()
    {
        Vector3 movementDirection = transform.position - lastPosition;

        if (movementDirection.magnitude > 0.01f)
        {
            movementDirection.Normalize();

            if (movementDirection.y > 0)
            {
                animator.SetInteger("DirectionY", 1);
            }
            else if (movementDirection.y < 0)
            {
                animator.SetInteger("DirectionY", -1);
            }
            else if (movementDirection.x < 0)
            {
                animator.SetInteger("DirectionX", -1);
            }
            else if (movementDirection.x > 0)
            {
                animator.SetInteger("DirectionX", 1);
            }
        }
        else
        {
            animator.SetInteger("DirectionX", 0);
            animator.SetInteger("DirectionY", 0);
        }

        lastPosition = transform.position;
    }
}




/*public class PartnerFollow : MonoBehaviour
{
    public Transform playerTransform; 
    public float followDistance = 2.0f; 
    public float followSpeed = 5.0f;
    public float followSmoothness = 1f;

    private Vector3 targetPosition; 

    void Update()
    {
        Vector3 playerPosition = playerTransform.position;
        Vector3 offset = playerTransform.position - transform.position;
        offset = offset.normalized * followDistance;
        targetPosition = playerPosition - offset;

        Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, 1 - Mathf.Pow(1 - followSmoothness, Time.deltaTime * followSpeed));
        transform.position = newPosition;
    }
}
*/