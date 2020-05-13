using UnityEngine;

/// <summary>
/// Defines the <see cref="Obstacle" />
/// </summary>
public class Obstacle : MonoBehaviour
{
    internal void OnTriggerEnter(Collider col)
    {
        //if the player hits one obstacle, it's game over
        if (col.gameObject.tag == Constants.PlayerTag)
        {
            GameManager.Instance.Die();
        }
    }
}
