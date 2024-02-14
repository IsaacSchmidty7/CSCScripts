using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomExit : MonoBehaviour
{
public int sceneBuildIndex;

private void onTriggerEnter(Collider other)
{
    print("Entering " + sceneBuildIndex);
    SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

}
}
