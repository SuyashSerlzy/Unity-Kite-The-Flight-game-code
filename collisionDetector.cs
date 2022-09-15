//serlzy.me@me.missypubsband.github


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collisiondetector : MonoBehaviour
{
    public playerMovement playerMovement;
    public GameObject ui;
    public GameObject youlost;
    public void ProcessCollision(GameObject collider)
    {
       playerMovement.enabled = false;
       youlost.SetActive(true);
    }
    void CompleteLevel()
    {
        ui.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Crow enemy"))
        {
            ProcessCollision(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("New lavel"))
        {
            print("You won the this lavel");
            CompleteLevel();
        }
        if (collision.gameObject.CompareTag("cheat detector"))
        {
            youlost.SetActive(true);
            playerMovement.enabled = false;
        }
    }
}
