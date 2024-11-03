using UnityEngine;

namespace SingletonPattern
{
    public enum GameState
    {
        Pause,
        PlayerTurn,
        EnemyTurn,
    }

    public class GameManager : MonoBehaviour
    {
        public GameState currentState;
        public GameState previousState;

        public static GameManager instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != null &&  instance != this)
                Destroy(gameObject);

            currentState = GameState.PlayerTurn;
            previousState = GameState.Pause;
        }

        public void ChangeState(GameState newState)
        {
            if (!currentState.Equals(newState))
            {
                previousState = currentState;
                currentState = newState;
            }
        }
    }
}
