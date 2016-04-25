using UnityEngine;
using System.Collections;

public class laserBullet : MonoBehaviour {

	public float speed;
	public Vector2 direction;
	public bool isReady;
	public Vector2 position;
	public Vector2 min;
	public Vector2 max;

	void Awake()
	{
		speed = 5f;
		isReady = false;
	}

	// Use this for initialization
	void Start () {
	
	}

	void SetDirection(Vector2 direction)
	{
		direction = direction.normalized;

		isReady = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (isReady) {
			position = transform.position;

			position += direction * speed * Time.deltaTime;

			transform.position = position;

			min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

			max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

			if((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
			{
				Destroy (gameObject);
			}

		}
	}
}
