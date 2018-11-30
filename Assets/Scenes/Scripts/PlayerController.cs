using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //shows up in editor as an editable property since public
    public float speed;
    public Text countText;
    public Text winText;

    private int count;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //fixed update for when dealing with forces
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

     void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    private void setCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 12)
        {
            winText.text = "YOU WIN!";
        }

    }
}

