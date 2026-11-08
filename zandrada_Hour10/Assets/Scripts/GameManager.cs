using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;

    private bool isGameOver = true;
    private float elapsedTime = 0;

    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        if (!isGameOver)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 120);
            GUI.Box(rect, "Game Over");

            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 15, 100, 30);
            GUI.Label(rect2, "Good Job!");

            Rect rect3 = new Rect(Screen.width / 2 - 30, Screen.height / 2 + 15, 100, 30);
            GUI.Label(rect3, "Time: " + elapsedTime.ToString("F2"));
        }
        else
        {
            GUI.Box(new Rect(10, 10, 150, 40), "Time: " + elapsedTime.ToString("F2"));
        }
    }
}