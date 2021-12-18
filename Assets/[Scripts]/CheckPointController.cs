/* CHECKPOINTCONTROLLER.CS,
 * RODNEY KRISTIAN DICKSON
 * 101068801
 * DECEMBER 17, 2021
 * GAME 2014 - FALL 2021 - FINAL TEST
 * REVISION HISTORY:
 *      - ADDED SHRINKING PLATFORM
 *      - ADDED RESPAWNING PLATFORM
 *      - ADDED PLATFORM SHRINKING/RESPAWNING SOUNDS
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Transform spawnPoint;
    public PlayerBehaviour player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.spawnPoint = spawnPoint;
        }
    }
}
