using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
   public float speed = 5f; // Movement speed
   private Rigidbody2D rb;
   private Vector2 movement;
   void Start()
   {
       rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
   }
   void Update()
   {
       // Capture input for horizontal and vertical movement
       float moveX = Input.GetAxis("Horizontal");
       float moveY = Input.GetAxis("Vertical");
       movement = new Vector2(moveX, moveY).normalized; // Normalize to maintain consistent speed
   }
   void FixedUpdate()
   {
       // Apply movement to Rigidbody2D
       rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
   }
}