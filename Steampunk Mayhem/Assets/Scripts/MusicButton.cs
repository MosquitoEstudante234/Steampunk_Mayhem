using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    public void Jump()
    {
    FindObjectOfType<AudioManager>().Play("JumpSound");
    }
    public void PowerUp()
    {
    FindObjectOfType<AudioManager>().Play("PowerUP");
    }
}
