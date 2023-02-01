using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizManager : MonoBehaviour
{
    private Text message;
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;


    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    public TextMeshProUGUI mensajeCN; //es para mandar el mensaje de muy bien 
     public TextMeshProUGUI mensajeInco; //para el incorrecto
    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion(); 

        
    }

   


    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }//construye la escena que est� activa
    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text= score + " / " +   totalQuestions;
    }


    public void correct()
    {
        //Agregar un tiempo 
       // GetComponent<Image>().color = Color.green;
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        //Destroy(TextMeshProUGUI.FindObjectOfType<GameObject>());
        
        mensajeCN.gameObject.SetActive(true); //muestra el mensaje de muy bien
         
        //message.text = "Respuesta correcta ";
    }//Respuestas Correctas

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        mensajeInco.gameObject.SetActive(true); //muestra el mensaje sigue intentando
    }//when you answeer es incorrecta

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<Answers>().isCorrect = false; //Aqui manda a llamar el scrip de respuestas 
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i];
            //options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1) 
            {
                options[i].GetComponent<Answers>().isCorrect = true; //Aqui vamos a obtener el script de respuestas 
            }

           

        }
    }

    //Hace que obtenga una pregunta aleatoria
    void generateQuestion()
    {
        if(QnA.Count >0)
        {

            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            setAnswers();
        }
        else
        {
            Debug.Log(" Fuera de pegunta ");
            GameOver();
        }
    }
   
   /* public void Mensajes()
    {
        TextMeshProUGUI textMeshProUGUI = Instantiate(mensajeCN);
        
    }
    */
}
