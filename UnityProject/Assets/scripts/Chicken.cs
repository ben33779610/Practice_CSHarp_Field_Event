using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
	[Header("移動速度")][Range(20,200)]
	public float speed;
	[Header("跳躍高度")][Range(0,500)]
	public int jump;
	[Header("對話內容")]
	public string talk = ("咕咕咕");

    void Start()
    {
		print("Game Start"); //印出一次Start
    }

    
    void Update()
    {
		print(talk);		//重覆對話內容
    }
}
