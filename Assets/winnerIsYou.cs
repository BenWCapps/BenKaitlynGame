using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winnerIsYou : MonoBehaviour
{
	public CoffeeManager cm;
	public SugarManager sm;
	public SyrupManager sym;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sym = 1 && cm = 1 && sm = 1)
		{
			text.gameObject.SetActive(false);
		}
    }
}
