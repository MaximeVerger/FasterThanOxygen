using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Animator PlayerAnimator;
    Vector3 StartPosition;
    GameObject Sprite;

    void Start()
    {
        PlayerAnimator.SetBool("Above", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopAbove()
    {
        PlayerAnimator.SetBool("Above", false);
    }

    public void StopRight()
    {
        PlayerAnimator.SetBool("Right", false);
    }

    public void StopLeft()
    {
        PlayerAnimator.SetBool("Left", false);
    }

    public void StopBottom()
    {
        PlayerAnimator.SetBool("Bottom", false);
    }

}
