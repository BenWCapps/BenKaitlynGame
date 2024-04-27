using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyrupManager : MonoBehaviour
{
	public int syrupCount; 
	public Text syrupText;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        syrupText.text = ": " + syrupCount.ToString();
		
    }
}
