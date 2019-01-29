using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoController : MonoBehaviour {

    public GameObject[] hologramParticles;
	// Use this for initialization
	void Start () {
        StartCoroutine(CallChangeModels(6));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator CallChangeModels(float time)
    {
        for(int i=0;i<hologramParticles.Length;i++)
        {
            particlesEnable(i);
            yield return new WaitForSeconds(time);
            if (i >= hologramParticles.Length-1) i = 0;
        }
    }

    private void particlesEnable(int index)
    {
        foreach(GameObject go in hologramParticles)
        {
            go.SetActive(false);
        }
        hologramParticles[index].SetActive(true);
    }
}
