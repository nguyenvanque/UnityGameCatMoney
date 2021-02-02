using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class managerlist : MonoBehaviour
{
	// Use this for initialization

	public GameObject player;

	void Start()
	{


		for (int i = 0; i < 4; i++)
		{


			GameObject g = (GameObject)Instantiate(player); // tao gameObject

			g.transform.SetParent(this.transform); // Chi dinh la cha

			g.transform.Find("ID").GetComponent<Text>().text = "150"; // them de lieu cho text ID
			g.transform.Find("TENTK").GetComponent<Text>().text = "honda"; // them de lieu cho text ID
			g.transform.Find("DIACHI").GetComponent<Text>().text = "5 Chan Hung, Tan Binh, HCM"; // them de lieu cho text ID
			g.transform.Find("MATKHAU").GetComponent<Text>().text = "123456"; // them de lieu cho text ID


		}

	}

	// Update is called once per frame
	void Update()
	{

	}
}
