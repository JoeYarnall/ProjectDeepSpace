using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour, ISelectable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Selected()
    {
        Debug.Log("Sun selected!");
    }
}
