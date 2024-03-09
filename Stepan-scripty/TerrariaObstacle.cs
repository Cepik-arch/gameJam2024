using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrariaObstacle : MonoBehaviour
{
    public Collider2D colider;
    public player_script playerS;
    public bool onPlatform = false;

    void Start()
    {
        colider = GetComponent<Collider2D>();
    }

    void Update(){
        if(playerS.IsGrounded() && !onPlatform){
            colider.enabled = false;
        }
        else if(!playerS.IsGrounded()){
            colider.enabled = true;
            //onPlatform = true;
        }
    }
}
