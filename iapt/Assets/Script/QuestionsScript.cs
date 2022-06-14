using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionsScript : MonoBehaviour
{
    public TextMeshProUGUI questions_text;
    public TextMeshProUGUI choices_text1;
    public TextMeshProUGUI choices_text2;
    public TextMeshProUGUI choices_text3;
    public TextMeshProUGUI choices_text4;
    int i = 0;
    //Creating a multi-dimentional array for questions and answers with 10 rows and 5 columns(1 for question and 4 for choices )
    string[,] questions_and_choices = new string[10, 5] {
                {"1)    Is cluster analysis (or clustering) a supervised or unsupervised machine learning task?",
                    "a)	Supervised.",
                    "b)	Neither",
                    "c)	Both",
                    "d)	Neither"},

                {"2)    Which of these is not a clustering technique?",
                    "a)	Density based techniques",
                    "b)	K-means",
                    "c)	Linear regression",
                    "d)	Gaussian Mixture Models"},

                {"3)	What does the “K” in the K-means technique mean?",
                    "a)	The number of centroids you need in the dataset",
                    "b)	The number of groups you divide the data in (number of clusters)",
                    "c)	Both of these are correct",
                    "d)	Neither of these are correct"},

                {"4)	Which is the most used clustering technique?",
                    "a)	Hierarchical clustering",
                    "b)	Spectral Clustering",
                    "c)	Agglomerative Clustering",
                    "d)	K-means Clustering"},

                {"5)	Which of these is not a way to decide on how to cluster?",
                    "a)	Single linkage clustering",
                    "b)	Average linkage clustering",
                    "c)	Median linkage clustering ",
                    "d)	Ward Clustering"},

                {"6)	What is the goal of clustering?",
                    "a)	Divide the data into groups ",
                    "b)	Classify the data into different classes",
                    "c)	Predict the output values of input data points",
                    "d)	All of the above"},

                {"7)	Which data type is not required for clustering?",
                    "a)	Labeled data",
                    "b)	Unlabeled data",
                    "c)	Numerical data",
                    "d)	Categorical data"},

                {"8)	What is the final output of Hierarchical clustering?",
                    "a)	The number of cluster centroids",
                    "b)	The tree representing how close the data points are to each other",
                    "c)	A map defining the similar data points into individual groups",
                    "d)	All of the above"},

                {"9)	Which of the following sentences is not true?",
                    "a)	K-means clustering tries to group n observations into k clusters",
                    "b)	K-nearest neighbors is the same as K-means",
                    "c)	K-means clustering is a vector quantization method",
                    "d)	Clusters are always convex in space"},

                {"10)	What is a dendrogram?",
                    "a)	A hierarchical structure",
                    "b)	A diagram structure",
                    "c)	A graph structure",
                    "d)	None of these"},



                };
    char[] answers = new char[10] { 'b', 'c', 'c', 'd', 'c', 'a', 'a', 'b', 'b', 'a' };

    // Start is called before the first frame update
    void Start()
    {
        questions_text.SetText(questions_and_choices[i, 0]);
        choices_text1.SetText(questions_and_choices[i, 1]);
        choices_text2.SetText(questions_and_choices[i, 2]);
        choices_text3.SetText(questions_and_choices[i, 3]);
        choices_text4.SetText(questions_and_choices[i, 4]);
    }

    public void choiceKing() 
    {
        char choice = 'a';
        if (choice == answers[i])
        {
            choices_text1.color = new Color32(0, 255, 0, 255);
            
        }
        else
        {
            if(answers[i] == 'b')
            {
                choices_text2.color = new Color32(0, 255, 0, 255);
                choices_text1.color = new Color32(255 ,0, 0, 255);

            }

            if(answers[i] == 'c')
            {
                choices_text3.color = new Color32(0, 255, 0, 255);
                choices_text1.color = new Color32(255, 0, 0, 255);
            }

            if(answers[i] == 'd')
            {
                choices_text4.color = new Color32(0, 255, 0, 255);                
                choices_text1.color = new Color32(255, 0, 0, 255);
            }
        }

        i++;
    }

    public void choiceQueen()
    {
        char choice = 'b';
        if (choice == answers[i])
        {
            choices_text2.color = new Color32(0, 255, 0, 255);
        }
        else
        {
            if (answers[i] == 'a')
            {
                choices_text1.color = new Color32(0, 255, 0, 255);
                choices_text2.color = new Color32(255, 0, 0, 255);
            }

            if (answers[i] == 'c')
            {
                choices_text3.color = new Color32(0, 255, 0, 255);
                choices_text2.color = new Color32(255, 0, 0, 255);

            }

            if(answers[i] == 'd')
            {
                choices_text2.color = new Color32(255, 0, 0, 255);
                choices_text4.color = new Color32(0, 255, 0, 255);
            }
        }

        i++;
    }

    public void choiceJack()
    {
        char choice = 'c';
        if (choice == answers[i])
        {
            choices_text3.color = new Color32(0, 255, 0, 255);
        }
        else
        {
            if (answers[i] == 'a')
            {
                choices_text1.color = new Color32(0, 255, 0, 255);
                choices_text3.color = new Color32(255, 0, 0, 255);
            }

            if (answers[i] == 'b')
            {
                choices_text2.color = new Color32(0, 255, 0, 255);
                choices_text3.color = new Color32(255, 0, 0, 255);
            }

            if(answers[i] == 'd')
            {
                choices_text3.color = new Color32(255, 0, 0, 255);
                choices_text4.color = new Color32(0, 255, 0, 255);
            }
        }

        i++;
    }

public void choiceTen()
    {
        char choice = 'd';
        if (choice == answers[i])
        {
            choices_text4.color = new Color32(0, 255, 0, 255);
        }
        else
        {
            if (answers[i] == 'a')
            {
                choices_text1.color = new Color32(0, 255, 0, 255);
                choices_text4.color = new Color32(255, 0, 0, 255);
            }

            if(answers[i] == 'b')
            {
                choices_text2.color = new Color32(0, 255, 0, 255);
                choices_text4.color = new Color32(255, 0, 0, 255);
            }

            if (answers[i] == 'c')
            {
                choices_text3.color = new Color32(0, 255, 0, 255);
                choices_text4.color = new Color32(255, 0, 0, 255);
            }
  
        }

        i++;
    }

    public void rewrite()
    {
        if (i > 9)
        {
            i = 0;
        }
        choices_text1.color = new Color32(255, 255, 255, 255);
        choices_text2.color = new Color32(255, 255, 255, 255);
        choices_text3.color = new Color32(255, 255, 255, 255);
        choices_text4.color = new Color32(255, 255, 255, 255);
        questions_text.SetText(questions_and_choices[i, 0]);
        choices_text1.SetText(questions_and_choices[i, 1]);
        choices_text2.SetText(questions_and_choices[i, 2]);
        choices_text3.SetText(questions_and_choices[i, 3]);
        choices_text4.SetText(questions_and_choices[i, 4]);
    }
}
