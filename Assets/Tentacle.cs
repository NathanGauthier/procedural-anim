using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tentacle : MonoBehaviour
{
    public int trailLength;
    public LineRenderer lineRender;
    public Vector3[] segmentPoses;
    public Vector3[] segmentV;

    public Transform targetDir;
    public float targetDist;
    public float smoothSpeed;
    public float trailSpeed;



    private void Awake()
    {
       
    }
    public void Start()
    {
        trailSpeed = TrailManager.instance.trailSpeed;
        trailLength = TrailManager.instance.length;
        lineRender.positionCount = trailLength;
        segmentPoses = new Vector3[trailLength];
        segmentV = new Vector3[trailLength];
    }

    private void Update()
    {

        trailSpeed = TrailManager.instance.trailSpeed;
        trailLength = TrailManager.instance.length;

        segmentPoses[0] = targetDir.position;

        for(int i = 1; i < segmentPoses.Length; i++)
        {
            segmentPoses[i] = Vector3.SmoothDamp(segmentPoses[i], segmentPoses[i - 1] + targetDir.right * targetDist, ref segmentV[i], smoothSpeed + i/ trailSpeed) ;
        }

        lineRender.SetPositions(segmentPoses);
    }
}
