using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;
    private float startTime;
    private float timeTaken;
    private int collectablesPicked;
    public int maxCollectables = 10;
    private bool isPlaying;

    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get values
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        //set velocity
        rig.velocity = new Vector3(x, rig.velocity.y, z);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            collectablesPicked++;
            Destroy(other.gameObject);
            if (collectablesPicked == maxCollectables)
                End();
        }
    }
    public void Begin()
    {
        startTime = Time.time;
        isPlaying = true;
    }
    void End()
    {
        timeTaken = Time.time - startTime;
        isPlaying = false;
    }
}
