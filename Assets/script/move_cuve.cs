using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cuve : DualBehaviour
{
    public float moveSpeed = .3f;
    public float rotationSpeed = 8f;

    //enumeration statut
    public enum e_characterState  //etat du characterstate

    {

        invalid = -1,

        standing,

        moving,

        jumping,

        diving,

        ducking
    }
    public e_characterState m_characterestate = e_characterState.standing;
    //if fonction
    
    void move_Global()
    {
        if (Input.GetKey(KeyCode.UpArrow))


            {

                transform.Translate(Vector3.forward * moveSpeed);

        }

        else if (Input.GetKey(KeyCode.DownArrow))

        {

            transform.Translate(-Vector3.forward * moveSpeed);

        }



        if (Input.GetKey(KeyCode.RightArrow))

        {

            transform.Rotate(Vector3.up * rotationSpeed);

        }

        else if (Input.GetKey(KeyCode.LeftArrow))

        {

            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
    }
    /*switch standing
    switch (standing)
        {
            case  :
            //traitement
            break;
        case :
        //
        break;
        default :
        //si la valeur n'a pas de case
        break;
        }
    //switch moving
  switch (moving)
        {
            case e_characterState.moving :
            
            break;
        case :
        //
        break;
        default :
        //si la valeur n'a pas de case
        break;
        }*/

    #region Public Members

    #endregion

    #region Public Void

    #endregion

    #region System

    void Start () 
    {
		
	}

    void Update()
    {
    move_Global();
    }
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
   
    #endregion
}


