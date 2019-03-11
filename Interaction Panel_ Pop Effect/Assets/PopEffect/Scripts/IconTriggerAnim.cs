using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IconTriggerAnim : MonoBehaviour
{
    [Header("Pop Controller")]
    public Animator animLook_In;
    public Animator animUse_In;
    public Animator animTalk_In;
    public Animator animTake_In;

    ///Pop In Animations Only///
    public void LookAnimationEnter()
    {
        Debug.Log("PointEnter is Triggered");
        animLook_In.SetBool("IsHighlight", true);
    }
    public void LookAnimationExit()
    {
        Debug.Log("ExitEnter");
        animLook_In.SetBool("IsHighlight", false);
    }
    /// <summary>
    /// 
    /// </summary>
    public void TakeAnimationEnter()
    {
        Debug.Log("PointEnter is Triggered");
        animTake_In.SetBool("IsHighlight", true);
    }
    public void TakeAnimationExit()
    {
        Debug.Log("ExitEnter");
        animTake_In.SetBool("IsHighlight", false);
    }
    /// <summary>
    /// 
    /// </summary>
    public void UseAnimationEnter()
    {
        Debug.Log("PointEnter is Triggered");
        animUse_In.SetBool("IsHighlight", true);
    }
    public void UseAnimationExit()
    {
        Debug.Log("ExitEnter");
        animUse_In.SetBool("IsHighlight", false);
    }
    /// <summary>
    /// 
    /// </summary>
    public void TalkAnimationEnter()
    {
        Debug.Log("PointEnter is Triggered");
        animTalk_In.SetBool("IsHighlight", true);
    }
    public void TalkAnimationExit()
    {
        Debug.Log("ExitEnter");
        animTalk_In.SetBool("IsHighlight", false);
    }
}
