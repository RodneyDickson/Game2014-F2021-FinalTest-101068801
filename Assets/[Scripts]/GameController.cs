/* GAMECONTROLLER.CS,
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
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Bullet Related")]
    public int MaxBullets;
    public BulletType enemyBulletType;
    public BulletType playerBulletType;

    [Header("Moving Platforms")] 
    public List<MovingPlatformController> movingPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        movingPlatforms = FindObjectsOfType<MovingPlatformController>().ToList();


        // Kickoff the BulletManager
        BulletManager.Instance().Init(MaxBullets, enemyBulletType, playerBulletType);
    }

    public void ResetAllPlatforms()
    {
        foreach (var platform in movingPlatforms)
        {
            platform.Reset();
        }
    }

}
