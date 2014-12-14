﻿using UnityEngine;
using System.Collections;

public class Companion : Character {

	private Vector3 companionDestination;
	private Character character;

	public Companion(string name, int id, int life, float movementSpeed, bool canMove){
		character = new Character(name, id, life, movementSpeed, canMove);
	}

	public Companion(){
	}

    /// <summary>
    /// What happens when the player is knocked out.
    /// </summary>
	public void KnockOut(){
		
	}

	public Vector3 CompanionDestination{ get; set; }
}
