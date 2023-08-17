using System;
using UnityEngine;
using CementTools;
using Femur; 
// This is an example Mod class
public class test : CementMod {

	// The Cement Mod Class inherits from MonoBehaviour, so you can use all the methods of MonoBehaviour.

    public void Start() 
	{
		// Called once
		Cement.Log("Loaded my mod!");
    }
    

public class PlayerController : MonoBehaviour
{
    public Color playerColor;
    public float baseSize = 1.0f;
    public float sizeMultiplier = 2.0f;

    private bool isRed = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleRed();
        }
    }

    private void ToggleRed()
    {
        isRed = !isRed;

        if (isRed)
        {
            playerColor = Color.red;
            transform.localScale = new Vector3(baseSize * sizeMultiplier, baseSize * sizeMultiplier, 1.0f);
        }
        else
        {
            playerColor = Color.white;
            transform.localScale = new Vector3(baseSize, baseSize, 1.0f);
        }
    }
}


    public void Update() 
	
		