using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyScript : MonoBehaviour
{
	public GameObject inticon, key;

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			inticon.SetActive(true);
			if (Input.GetKeyDown(KeyCode.E))
			{
				key.SetActive(false);
				inticon.SetActive(false);
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			inticon.SetActive(false);
		}
	}
}