using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private int score;
    private int mejorscore;
    public Image fadeScreen2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeScreen2.DOFade(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            score += 10;
        }
        if( Input.GetKeyDown(KeyCode.DownArrow))
        {
            score -= 10;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            MejorPuntuacion();
        }
    }
    private void MejorPuntuacion()
    { 
        if (score >= PlayerPrefs.GetInt("MejorPuntuacion"))
        { 
            PlayerPrefs.SetInt("MejorPuntuacion",score);
            mejorscore = score;
            //PlayerPrefs.DeleteKey("MejorPuntuacion");
        }
    }
}
