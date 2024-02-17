using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeManager : MonoBehaviour
{
	public int coffeeCount; 
	public Text coffeeText;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coffeeText.text = ": " + coffeeCount.ToString();
		
    }
}
