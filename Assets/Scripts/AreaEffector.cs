using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public GameObject areaEffector1;
    public GameObject areaEffector2;
    private float time = 0.0f;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
        //sumo el tiempo a la variable time.
        time = time + Time.deltaTime;
        //enciendo los efectores por 5 segundos.
        if (time < 5)
        {
            areaEffector1.SetActive(true);
            areaEffector2.SetActive(true);
        }
        //los apago por 5 segundos.
        if(time >= 5 && time < 10)
        {
            areaEffector1.SetActive(false);
            areaEffector2.SetActive(false);
        }
        //reseteo el timer.
        if(time >= 10)
        {
            time = 0.0f;
        }
	}
}
