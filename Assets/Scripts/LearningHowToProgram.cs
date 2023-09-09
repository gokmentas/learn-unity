using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{

    private Rigidbody body;
    private BoxCollider2D boxCollider;
    private AudioSource audioSource;
    private Animator animator;
    private Transform trans;

    private void Start()
    {

        body = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        animator = GetComponent<Animator>();

        trans = transform;

        trans.position = new Vector3(10, 20, 30);

    }


} // class
