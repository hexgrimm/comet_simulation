using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MainCameraController : MonoBehaviour
{

    public GameObject Rosetta;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.LookAt(Rosetta.transform);
        transform.RotateAround(Rosetta.transform.position, Vector3.up, 15 * Time.deltaTime);
	}
}
