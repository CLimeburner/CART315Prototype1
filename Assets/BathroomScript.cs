using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BathroomScript : MonoBehaviour
{
    public GameObject player;
    public GameObject popupBackdrop;
    public GameObject popupPrompt;
    private string winnerMessage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter (Collision collision)
    {
      if(collision.collider.gameObject == player) {
        popupBackdrop.SetActive(true);
        popupPrompt.SetActive(true);
        if(popupPrompt == GameObject.Find("WinnerPrompt")) {
          winnerMessage = "Congratulations, you can now relieve yourself! It took you " + Time.time + " seconds to find a washroom. \n Please record your time and submit it with your feedback.";
          popupPrompt.GetComponent<Text>().text = winnerMessage;
        }
      }
    }

    void OnCollisionExit (Collision collision)
    {
      if(collision.collider.gameObject == player) {
        popupBackdrop.SetActive(false);
        popupPrompt.SetActive(false);
      }
    }
}
