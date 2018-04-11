using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public int gameSpeed;


	public abstract class Entity {
		// Note: abstract class
		private string entityName;

		public string getName() { return entityName;}
		
		public void setName(string newName) { entityName = newName; }

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


	}

	public class Projectile {
		private int damage;

		public int getDamage() { return damage; }

		public void setDamage(int newDamage) { damage = newDamage; }

	}

    void setGameScore() { }

	// Use this for initialization
	void Start () {
		Debug.Log(gameSpeed);
        
		gameSpeed = 5;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
