using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text textScore;

    // Update is called once per frame
    void Update()
    {
        textScore.text = player.position.z.ToString("0");
    }
}
