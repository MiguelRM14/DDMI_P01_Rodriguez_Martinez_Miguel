using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
public class botones : MonoBehaviour
{
    public RectTransform BotonInicio;
    public Ease startButtonEase;
    public Image fadeScreen;
    public int Escala = 2;
    public int Tiempo = 2;

    private void Start()
    {
        BotonInicio.DOScale(Escala, Tiempo).SetEase(Ease.InOutExpo).OnComplete(() => {
            BotonInicio.DOShakePosition(1, 100, vibrato: 100).SetLoops(-1);
        });//SetLoops(-1);
    }
    public  void CargarJuego()
    {
        fadeScreen.DOFade(1, 2).OnComplete(( ) => {
            SceneManager.LoadScene("juego");
        });
    }
}
