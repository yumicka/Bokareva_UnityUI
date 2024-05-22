using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject helmet1;
    public GameObject helmet2;
    public GameObject helmet3;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public GameObject sizeSlider;
    public GameObject rotationSlider;
    public GameObject scroll;

    public void showHelmet1(bool value)
    {
        helmet1.SetActive(value);
    }

    public void showHelmet2(bool value)
    {
        helmet2.SetActive(value);
    }

    public void showHelmet3(bool value)
    {
        helmet3.SetActive(value);
    }

    public void changeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[index];
            imageHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(
                spriteArray[index].rect.width,
                spriteArray[index].rect.height
            );
            if(index == 0) {
                scroll.GetComponent<Text>().text = "Alex is a girl about to goon a dangerous adventure! Many biomes, challenges and monsters are waiting for her. Help her to choose a good outfit so that she can face all the adventures with courage!";
            }
            
            else if(index == 1) {
                scroll.GetComponent<Text>().text = "Yuma is a guy who likes fire and danger. His favourite biome is the Nether, where he lives and travels around exploring Bastions and Fortresses. Pretty soon Yuma will have to go to the depths of Nether again, I think he needs the right clothes for that...";
            }

        }
    }


    public void changeSize()
    {
        float size = sizeSlider.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(size, size);
    }

    public void changeRotation()
    {
        float rotation = rotationSlider.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation * 360);
    }
}
