using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SugarManager : MonoBehaviour
{
	public int sugarCount; 
	public Text sugarText;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sugarText.text = ": " + sugarCount.ToString();
		
    }
}
