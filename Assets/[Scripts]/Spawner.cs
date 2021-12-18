/* SPAWNER.CS,
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

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
