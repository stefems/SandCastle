using UnityEngine;
using System.Collections;

public class grainObject : MonoBehaviour
{

    /* class variables */
        private static Sprite[] spriteArray = Resources.LoadAll<Sprite>("sprites");

    /*instance variables*/
        //this is the gameobject that the script is attached to.
        private GameObject self;
        //moisture affects the color, rigidity, and when too high will
        // delete the grain. 
        private int moisture;
        // 0 - 20 :: 0 is no rigidity, 20 is best rigidity 
        private int rigidity;
        //the greater the moisture the darker the color
        private int color;
        //active grains are exposed to water and the air or are near
        // other active grains.
        private bool active;
        //whether or not the grain is currently picked up.
        private bool grabbed;
        //the current x,y position of the grain
        private Vector2 position;
    /*instance components*/
        //Sprite for the image of the sand, of course
        private SpriteRenderer spriteRendererComp;
        private BoxCollider2D boxColliderComp;
        private Rigidbody2D rigidBodyComp;
        

    // Use this for initialization
    public void Start()
    {
        //assigning the self variable to the object
        self = this.gameObject;
        //setting the transform so each isn't fuckin huge
        self.transform.localScale = new Vector3(0.01F, 0.01F, 0);
        //adding the sprite renderer object that we've set as an instance variable
        spriteRendererComp = self.AddComponent<SpriteRenderer>();
        //adding the box collider object that we've set as an instance variable
        boxColliderComp = self.AddComponent<BoxCollider2D>();
        //adding the rigid body object that we've set as an instance variable
        rigidBodyComp = self.AddComponent<Rigidbody2D>();
        //setting the sprite to the static sprite variable
        spriteRendererComp.sprite = spriteArray[0];

        //method to randomly assign position

    }

    // Update is called once per frame
    void Update()
    {

    }

    public grainObject()
    {

    }

    private int getRigidity()
    {
        return rigidity;
    }

    private int getColor()
    {
        return color;
    }

    private int getMoisture()
    {
        return moisture;
    }

    private bool getGrabbed()
    {
        return grabbed;
    }

    private bool getActive()
    {
        return active;
    }

    public Vector2 getPosition()
    {
        return position;
    }
}
