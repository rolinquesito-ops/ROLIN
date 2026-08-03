using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarAlMapa : MonoBehaviour
{
    public void IniciarJuego()
    {
        if (SeleccionarPersonaje.personajeSeleccionado == -1)
        {
            Debug.Log("Debes elegir un personaje antes de continuar");
            return;
        }

        SceneManager.LoadScene("SeleccionDelMapa");
    }

    public void IrASeleccionDePersonajes()
    {
        SceneManager.LoadScene("SeleccionDePersonajes");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }

    public void IrAMapa1()
    {
        SceneManager.LoadScene("Mapa1");
    }

    public void IrAMapa2()
    {
        SceneManager.LoadScene("Mapa2");
    }
}