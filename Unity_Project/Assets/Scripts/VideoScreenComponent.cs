using UnityEngine;
using System.Collections;

public class VideoScreenComponent : MonoBehaviour
{
    public Material StartVideo;
    public Material TrajectoryVideo;
    public Material VideoFileLutecia;
    public Material VideoFileWakeUpRosetta1;
    public Material VideoFileWakeUpRosetta2;
    public Material Randevou;
    public Material FilieSending;
	// Use this for initialization
    public static VideoScreenComponent Instance { get; set; }
    private static VideoScreenComponent instance;

    private void Awake()
    {
        instance = this;
    }

    [ContextMenu("Play")]
    public void PlayMaterialFile()
    {
        
        var mov = renderer.material.mainTexture as MovieTexture;
        mov.Stop();
        mov.Play();
    }
}
