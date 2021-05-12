/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
         AudioSource MpPlayer;
     AudioClip FirstClip;
     AudioClip SecondClip;
     // Use this for initialization
     void Start () {
         MpPlayer.clip = FirstClip;
         MpPlayer.loop = false;
         MpPlayer.Play();
         StartCoroutine(WaitForTrackTOend());
     }
 
     IEnumerator WaitForTrackTOend()
     {
         while (MpPlayer.isPlaying)
         {
 
             yield return new WaitForSeconds(0.01f);
             
         }
         MpPlayer.clip = FirstClip;
         MpPlayer.loop = true ;
         MpPlayer.Play();
        
     }
    AudioSource $$anonymous$$pPlayer;
    AudioClip FirstClip;
    AudioClip SecondClip;
    // Use this for initialization
    void Start()
    {
         $$anonymous$$pPlayer.clip = FirstClip;
         $$anonymous$$pPlayer.loop = false;
         $$anonymous$$pPlayer.Play();
        StartCoroutine(WaitForTrackTOend());
    }

    IEnumerator WaitForTrackTOend()
    {
        while ($$anonymous$$pPlayer.isPlaying)
         {

            yield return new WaitForSeconds(0.01f);

        }
         $$anonymous$$pPlayer.clip = FirstClip;
         $$anonymous$$pPlayer.loop = true;
         $$anonymous$$pPlayer.Play();

    }
}
*/