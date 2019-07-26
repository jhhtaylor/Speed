using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScroller : MonoBehaviour {

	//tell the program how to find certain components
	public float scrollSpeed = 5.0f;
	public GameObject[] obstacles;
	public float frequency = 0.5f;
	float counter = 0.0f;
	public Transform obstaclesSpawnLocation;
	bool isGameOver = false;
	public int obstacleNum = 0;

	// Use this for initialization
	void Start () {
		GenerateObstacles();
	}
	
	// Update is called once per frame
	void Update () {

		if (isGameOver) return;

		//Generate Objects every 1 second, ie when the timer runs out, and then reset it to oen
		if(counter <= 0.0f)
		{
			GenerateObstacles();
		}
		else
		{
			//count
			counter -= Time.deltaTime * frequency;
		}
		//Scrolling
		GameObject currentChild;
		for (int i = 0; i < transform.childCount; i++){
			currentChild = transform.GetChild(i).gameObject;
			ScrollObstacle(currentChild);
			//when the object has gone past, delete it
			if(currentChild.transform.position.x <= -25)
			{
				Destroy(currentChild);
			}

		}
	}
	//moves obstacle towards player
	void ScrollObstacle(GameObject currentObstacle)
	{
		currentObstacle.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
	}

	void GenerateObstacles()
	{
		//if it's the first few blocks, maek it easy for the player: place easy diamonds,
		//then make it a bit harder, and after 5 easy blocks, they blocks and completely random and hard
		GameObject newObstacle;
		if (obstacleNum >= 6)
		{
			 newObstacle = (GameObject)Instantiate(obstacles[Random.Range(0, obstacles.Length-1)], obstaclesSpawnLocation.position, Quaternion.identity);
			 newObstacle.transform.parent = transform;

		}
		else if(obstacleNum == 0 ||obstacleNum == 1)
		{
			newObstacle = (GameObject)Instantiate(obstacles[7], obstaclesSpawnLocation.position, Quaternion.identity);
			newObstacle.transform.parent = transform;
		}

		else if(obstacleNum == 2 || obstacleNum == 3)
		{
			newObstacle = (GameObject)Instantiate(obstacles[2], obstaclesSpawnLocation.position, Quaternion.identity);
			newObstacle.transform.parent = transform;
		}
		else if (obstacleNum == 4)
		{
			newObstacle = (GameObject)Instantiate(obstacles[1], obstaclesSpawnLocation.position, Quaternion.identity);
			newObstacle.transform.parent = transform;
		}
		else if (obstacleNum == 5)
		{
			newObstacle = (GameObject)Instantiate(obstacles[4], obstaclesSpawnLocation.position, Quaternion.identity);
			newObstacle.transform.parent = transform;
		}
		obstacleNum++;
		counter = 1;
	}

	public void GameOver()
	{
		isGameOver = true;
		transform.GetComponent<GameController>().GameOver();
	}

	
}
