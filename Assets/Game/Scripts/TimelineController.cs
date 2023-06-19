using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timeline;
    public string LevelName;

    private void Start()
    {
        timeline.stopped += OnTimelineFinish;
    }

    private void OnTimelineFinish(PlayableDirector director)
    {
        SceneManager.LoadScene(LevelName);
    }
}