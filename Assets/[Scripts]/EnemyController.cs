/* ENEMYCONTROLLER.CS,
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

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
