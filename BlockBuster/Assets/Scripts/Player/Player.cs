using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void collidedWithEnemy(Enemy enemy)
    {
	enemy.Attack(this);

	if (health <= 0)
	{

	}
    }

    void OnCollisionEnter(Collision col)
    {
	    Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
		if (enemy)
		{
			collidedWithEnemy(enemy);
		}
    }
}
