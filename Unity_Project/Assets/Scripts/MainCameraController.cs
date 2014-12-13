using Assets.Scripts;
using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MainCameraController : MonoBehaviour
{

    public GameObject Rosetta;
    public static MainCameraController Instance;

    public Vector3 defaultCamPos1;
    public Vector3 defaultCamRotation1;

    private void Awake()
    {
        Instance = this;
        GlobalEventListener.Instance.ReturnObjectsToDefaultAction += ResetPosAndRot;
    }

    private void OnDestroy()
    {
        GlobalEventListener.Instance.ReturnObjectsToDefaultAction -= ResetPosAndRot;
    }
	void Start () 
    {
	
	}
	
	void Update ()
	{
	    transform.LookAt(Rosetta.transform);
        transform.RotateAround(Rosetta.transform.position, Vector3.up, 5 * Time.deltaTime);
	}

    public void ResetPosAndRot()
    {
        
    }
}
