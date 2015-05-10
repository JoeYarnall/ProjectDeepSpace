using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour, ISelectable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Selected()
    {
        Debug.Log("Planet Selected!");
    }
}
