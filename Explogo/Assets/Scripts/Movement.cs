using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

	public Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
		while(Input.GetKeyDown(KeyCode.A))
		{
		player.velocity =  new Vector3(2, 0, 0);
		}
		
		while (Input.GetKeyDown(KeyCode.D))
		{
		player.velocity =  new Vector3(-2, 0, 0);
		}

		while(Input.GetKeyDown(KeyCode.W)) 
		{
		player.velocity =  new Vector3(0, 0, 2);
		}


		while(Input.GetKeyDown(KeyCode.S)) 
		{
		player.velocity =  new Vector3(0, 0, -2);
		}
    }
}
