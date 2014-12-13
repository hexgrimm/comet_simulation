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

    public static VideoScreenComponent Instance { get; set; }
    private static VideoScreenComponent instance;

    public MovieTexture Start;
    public MovieTexture Maneures;
    public MovieTexture LuteciaMeet;
    public MovieTexture WakeUpRosetta;
    public MovieTexture FilaeEnter;
    public MovieTexture EndPresentation;

    private void Awake()
    {
        instance = this;
    }

    [ContextMenu("Play")]
    public float PlayMaterialFile(MovieTexture mov)
    {
        renderer.material.mainTexture = mov;
        mov.Stop();
        mov.Play();
        return mov.Duration;
    }


    //http://www.youtube.com/watch?v=rEslUpel6s4 = rosetta start
    public void StopVideo()
    {
        var mov = renderer.material.mainTexture as MovieTexture;
        mov.Stop();
    }

    public void PauseVideo()
    {
        var mov = renderer.material.mainTexture as MovieTexture;
        mov.Pause();
    }

    public void Hide()
    {
        StartCoroutine(HidePanel());
    }

    public void Show()
    {
        StartCoroutine(ShowPanel());
    }

    private IEnumerator HidePanel()
    {
        
    }

    private IEnumerator ShowPanel()
    {

    }
}
