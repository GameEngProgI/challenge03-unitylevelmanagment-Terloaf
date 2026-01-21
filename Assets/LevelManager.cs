using UnityEngine;

public class LevelManager : MonoBehaviour
{


    public GameObject level01;
    public GameObject level02;

    private GameObject currentActiveLevel;




    public void LevelChange(Transform playerSpawner, GameObject player)
    {
        level01.SetActive(false);
        level02.SetActive(true);

        player.transform.position = playerSpawner.position;

        
    }

}
