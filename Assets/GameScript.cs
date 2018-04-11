using UnityEngine;
using System.Collections;
<<<<<<< HEAD
using UnityEngine.UI;
=======
>>>>>>> parent of 7dfab68... something

public class GameScript : MonoBehaviour {

	public int gameSpeed;


	public abstract class Entity {
		// Note: abstract class
		private string entityName;

		public string getName() { return entityName;}
		
<<<<<<< HEAD
		public void setName(string newName) { entityName = newName; }
=======
		public void setName(int newName) { entityName = newName; }
>>>>>>> parent of 7dfab68... something

	}

	public class Player : Entity {
		// Note: inherits from Entity
		private string playerName;
		private int playerHealth;
		private int playerScore; 

		public Player(){
			playerName = "Guest";
			playerHealth = 100;
			playerScore = 0;
		}

		public Player(string name, int health, int score){
			playerName = name;
			playerHealth = health;
			playerScore = score;
		}

		public int getHealth() { return playerHealth; }

		public void setHealth(int newHealth) { playerHealth = newHealth; }

		public int getScore() { return playerScore; }

		public void setScore(int newScore) { playerScore = newScore; }

<<<<<<< HEAD
=======
		public override string getName() { return playerName;}
		
		public override void setName(int newName) { playerName = newName; } 
>>>>>>> parent of 7dfab68... something

	}

	public class Projectile {
		private int damage;

		public int getDamage() { return damage; }

		public void setDamage(int newDamage) { damage = newDamage; }

	}

<<<<<<< HEAD
    void setGameScore() { }
=======

>>>>>>> parent of 7dfab68... something

	// Use this for initialization
	void Start () {
		Debug.Log(gameSpeed);
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
>>>>>>> parent of 7dfab68... something
=======
        int score = 0;
        //gameScoreText.text = "Count:" + count.ToString();
>>>>>>> parent of b4b2494... UI stuff 2.0
		gameSpeed = 5;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
