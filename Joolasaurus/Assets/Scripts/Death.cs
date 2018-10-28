﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Death")
		{
			Destroy(player);
		}
	}
}
