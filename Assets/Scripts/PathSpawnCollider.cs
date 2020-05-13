using UnityEngine;

public class PathSpawnCollider : MonoBehaviour
{
    public Transform[] PathSpawnPoints;

    public GameObject Path;

    internal void OnTriggerEnter(Collider hit)
    {
        //player has hit the collider
        if (hit.gameObject.tag == Constants.PlayerTag)
        {
            //find whether the next path will be straight, left or right
            int SpawnPoint = Random.Range(0, PathSpawnPoints.Length);
            for (int i = 0; i < PathSpawnPoints.Length; i++)
            {
                //instantiate the path
                if (i == SpawnPoint)
                    Instantiate(Path, PathSpawnPoints[i].position, PathSpawnPoints[i].rotation);
                else
                {
                    Vector3 position = PathSpawnPoints[i].position;
                }
            }

        }
    }
}
