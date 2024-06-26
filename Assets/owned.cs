using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owned : MonoBehaviour
{
	public float playerSpeed;
	private Rigidbody2D rb;
	private Vector2 playerDirection;
	public CoffeeManager cm;
	public SugarManager sm;
	public SyrupManager sym;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
		float directionY = Input.GetAxisRaw("Vertical");
		
		playerDirection = new Vector2(directionX, directionY).normalized;
    }
	
	void FixedUpdate()
	{
		rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Collectible"))
		{
			Destroy(other.gameObject);
			cm.coffeeCount++;
		}
		if(other.gameObject.CompareTag("Collectible2"))
		{
			Destroy(other.gameObject);
			sm.sugarCount++;
		}
		
	}
}
