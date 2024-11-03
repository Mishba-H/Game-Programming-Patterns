using UnityEngine;

namespace SingletonPattern
{
    public class Player : MonoBehaviour
    {
        GameManager gm;

        private void Start()
        {
            gm = GameManager.instance;    
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && gm.currentState == GameState.Pause)
            {
                gm.ChangeState(gm.previousState);
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && gm.currentState != GameState.Pause)
            {
                gm.ChangeState(GameState.Pause);
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && gm.currentState == GameState.PlayerTurn)
            {
                gm.ChangeState(GameState.EnemyTurn);
            }
            else if (Input.GetKeyDown(KeyCode.RightShift) && gm.currentState == GameState.EnemyTurn)
            {
                gm.ChangeState(GameState.PlayerTurn);
            }
        }
    }
}