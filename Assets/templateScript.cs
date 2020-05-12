using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;

public class templateScript : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;

    //Logging
    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    void Awake () {
        moduleId = moduleIdCounter++;
        /*/
        foreach (KMSelectable object in keypad) {
            KMSelectable pressedObject = object;
            object.OnInteract += delegate () { keypadPress(pressedObject); return false; };
        }
        /*/

        //button.OnInteract += delegate () { PressButton(); return false; };
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
