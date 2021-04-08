//This script is for respawning the player if they reach a point there are not supposed to touch, returning them to a specified position
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public Transform player;//a designates a target object for transformation (relocation)
    public Transform respawnPoint;//designates a point where the player will return to when respawning

    private void OnTriggerEnter(Collider other)//Triggers if this object detects some other object entering it
    {
        if(other.CompareTag("Player"))//if the colliding object has the tag "Player"
        {
            player.transform.position = respawnPoint.transform.position;//transforms the position of the player to that of the respawn point
            Physics.SyncTransforms();//syncronizes the physics engine
        }
    }
}
