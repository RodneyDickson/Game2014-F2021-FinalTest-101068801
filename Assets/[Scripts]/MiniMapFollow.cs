/* MINIMAPFOLLOW.CS,
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

public class MiniMapFollow : MonoBehaviour
{
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0.0f, 0.0f, -10f);
    }
}
