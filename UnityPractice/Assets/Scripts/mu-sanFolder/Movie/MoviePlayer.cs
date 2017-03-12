using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlayer : MonoBehaviour {

	// Use this for initialization
    protected void Start () {
        var movieTexture=(MovieTexture)GetComponent<Renderer>().material.mainTexture;
        movieTexture.loop = true;
        movieTexture.Play();
    }
}
