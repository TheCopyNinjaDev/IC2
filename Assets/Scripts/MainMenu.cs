using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Этот класс управляет взаимодействием с главным меню.
public class MainMenu : MonoBehaviour
{
    // Ссылка на кнопку "Начать игру" в пользовательском интерфейсе.
    public Button StartButton;
    // Ссылка на кнопку "Выход" в пользовательском интерфейсе.
    public Button ExitButton;

    // Start вызывается перед первым обновлением кадра.
    void Start()
    {
        // Добавляем слушателя к кнопке "Начать игру", который вызывает метод OnStartClicked при нажатии.
        StartButton.onClick.AddListener(OnStartClicked);
        // Добавляем слушателя к кнопке "Выход", который вызывает метод OnExitClicked при нажатии.
        ExitButton.onClick.AddListener(OnExitClicked);
    }
    
    // Метод, вызываемый при нажатии кнопки "Начать игру".
    void OnStartClicked()
    {
        // Загружаем сцену с именем "Reactor".
        SceneManager.LoadScene("Reactor");
    }

    // Метод, вызываемый при нажатии кнопки "Выход".
    void OnExitClicked()
    {
        // Выходим из приложения.
        Application.Quit();
        // Выводим сообщение в консоль о выходе из приложения.
        Debug.Log("Exit app");
    }
}