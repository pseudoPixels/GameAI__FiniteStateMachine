using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    Miner minerBob;

    float elapsedTime = 0;
    public float coolDownTime = 5.0f;

   

	// Use this for initialization
	void Start () {
        minerBob = new Miner((int)EntityNames.entityNames.ent_Miner_Bob);    
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;

        if(elapsedTime>= coolDownTime)
        {
            minerBob.Update();

            elapsedTime = 0;
        }

        
	}
}
