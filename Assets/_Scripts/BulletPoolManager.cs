using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int maxBullet;

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {

        if (BulletPool.Count != 0) // if bullets are available (bullet > 0)
        {

            GetBullet = BulletPool.Dequeue(1); // retrieve bullet from queue
            GetBullet.SetActive(true); // set bullet (game object) to active (true)

        }
       
        else // if no bullets available in the queue
        {
            // add bullets to queue
            BulletPool.Enqueue(1);
        }

        return bullet;
       // return void;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        BulletPool.Enqueue(1);

        return bullet;
    }
 
     private Queue<int> BulletPool = new Queue<int>();


}
