﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  //------------------------------------------------------------------------//
// NetworkSmoothing.cs
// By: Mike Loscocco
// Applies smoothing to a GameObject's movement/rotation over the network
// Attach this component to a GameObject, and drag it into its PhotonView observe field
// Replace observing this object's Transform with observing this script
//------------------------------------------------------------------------//

public class NetworkSmoothing
{

    //private Vector3 realPos = Vector3.zero;
    //private Quaternion realRot = Quaternion.identity;

    //private Vector3 lastPos;
    //private Vector3 velocity;

    //[Range(0.0f, 1.0f)]
    //public float predictionCoeff = 1.0f; //How much the game should predict an observed object's velocity: between 0 and 1

    //public bool isAuthoritative = false; //Only the master client can send this object's data

    //void Start()
    //{
    //    realPos = this.transform.position;
    //    realRot = this.transform.rotation;
    //    //predictionCoeff = Mathf.Clamp(predictionCoeff, 0.0f, 1.0f);  //Uncomment this to ensure the prediction is clamped

    //    //Turn this script off if the game is being played locally
    //    if (PhotonNetwork.offlineMode || !PhotonNetwork.inRoom)
    //    {
    //        this.enabled = false;
    //    }
    //}

    //public void Reset()
    //{
    //    realPos = this.transform.position;
    //    realRot = this.transform.rotation;
    //    lastPos = realPos;
    //    velocity = Vector3.zero;
    //}

    //void Update()
    //{
    //    lastPos = realPos;
    //    if (!photonView.isMine)
    //    {
    //        //Set the position & rotation based on the data that was received
    //        transform.position = Vector3.Lerp(transform.position, realPos + (predictionCoeff * velocity * Time.deltaTime), Time.deltaTime);
    //        transform.rotation = Quaternion.Lerp(transform.rotation, realRot, Time.deltaTime);
    //    }
    //}

    //public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    //{
    //    if (stream.isWriting && photonView.isMine)
    //    {
    //        //Send position over network
    //        stream.SendNext(transform.position);
    //        stream.SendNext(transform.rotation);
    //        //Send velocity over network
    //        stream.SendNext((realPos - lastPos) / Time.deltaTime);
    //    }
    //    else if (stream.isReading)
    //    {
    //        //Receive positions
    //        realPos = (Vector3)(stream.ReceiveNext());
    //        realRot = (Quaternion)(stream.ReceiveNext());
    //        //Receive velocity
    //        velocity = (Vector3)(stream.ReceiveNext());
    //    }
    //}
}
