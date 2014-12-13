using UnityEngine;
using System.Collections;

public class VideoScreenComponent : MonoBehaviour
{
    public MovieTexture StartVideo;
    public MovieTexture TrajectoryVideo;
    public MovieTexture VideoFileLutecia;
    public MovieTexture VideoFileWakeUpRosetta1;
    public MovieTexture VideoFileWakeUpRosetta2;
    public MovieTexture Randevou;
    public MovieTexture FilieSending;

    public Vector3 HiddenPos;
    public Vector3 ShownPos;

    public static VideoScreenComponent Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    [ContextMenu("Play")]
    public float PlayMaterialFile(MovieTexture mov)
    {
        renderer.material.mainTexture = mov;
        mov.Stop();
        mov.Play();
        return mov.duration;
    }

    public void StopVideo()
    {
        var mov = renderer.material.mainTexture as MovieTexture;
        mov.Stop();
        StopAllCoroutines();
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
        transform.localPosition = Vector3.Lerp(transform.localPosition, HiddenPos, Time.deltaTime);
    }

    private IEnumerator ShowPanel()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, ShownPos, Time.deltaTime);
    }
}
