using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine;

public class VideoController : MonoBehaviour {

    public VideoPlayer video;
    public Slider slider;
    bool isDone;

    public bool IsPlaying
    {
        get { return video.isPlaying; }
    }

    public bool IsLooping
    {
        get { return video.isLooping; }
    }
    
    public bool IsPrepared
    {
        get { return video.isPrepared; }
    }

    public bool IsDone
    {
        get { return IsDone; }
    }

    public double Time
    {
        get { return video.time; }
    }

    public ulong Duration
    {
        get { return (ulong)(video.frameCount / video.frameRate); }
    }

    public double NTime
    {
        get { return Time / Duration; }
    }

    void OnEnable() // when a component is enabled              what does it mean?
    {
        video.errorReceived += errorReceived;
        video.frameReady += frameReady;
        video.loopPointReached += loopPointReached;
        video.prepareCompleted += prepareCompleted;
        video.seekCompleted += seekCompleted;
        video.started += started;
    }
    void OnDisable()
    {
        video.errorReceived -= errorReceived;
        video.frameReady -= frameReady;
        video.loopPointReached -= loopPointReached;
        video.prepareCompleted -= prepareCompleted;
        video.seekCompleted -= seekCompleted;
        video.started -= started;
    }

    void errorReceived(VideoPlayer v, string msg)
    {
        Debug.Log("video player error: " + msg);
    }
    void frameReady(VideoPlayer v, long frame)
    {    }
    void loopPointReached(VideoPlayer v)
    {
        Debug.Log("video player loop point reached");
        isDone = true;
    }
    void prepareCompleted(VideoPlayer v)
    {
        Debug.Log("video player finshed preparing");
        isDone = false;
    }
    void seekCompleted(VideoPlayer v)
    {
        Debug.Log("video player finished seeking");
        isDone = false;
    }
    void started(VideoPlayer v)
    {
        Debug.Log("video player started");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
