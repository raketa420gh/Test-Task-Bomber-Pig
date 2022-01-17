using UnityEngine;
using UnityEngine.SceneManagement;

namespace Raketa420
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private UserInput input;
        [SerializeField] private PlayerCharacter playerCharacter;
        [SerializeField] private Enemy enemy;

        private void Start()
        {
            input.Initialize();
            playerCharacter.Initialize();
            enemy.Initialize();
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(SceneManager.sceneCountInBuildSettings - 1).name);
        }
    }
}
