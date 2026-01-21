using System.Runtime.InteropServices;
using UnityEngine;

public class LevelManager : MonoBehaviour
{


    public GameObject level01;
    public GameObject level02;


    private GameObject currentActiveLevel;

    private GameObject player;

    private void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;

        
        level01.SetActive(true);
        level02.SetActive(false);

        currentActiveLevel = level01;
    }

    public void LevelChange(Transform playerSpawner, GameObject player, GameObject targetLevel)
    {



        currentActiveLevel.SetActive(false);
        targetLevel.SetActive(true);
        currentActiveLevel = targetLevel;

        player.transform.position = playerSpawner.position;

        
    }

}
