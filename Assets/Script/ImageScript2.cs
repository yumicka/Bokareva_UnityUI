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
            // Устанавливаем размер изображения в соответствии с оригинальным размером спрайта
            imageHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(
                spriteArray[index].rect.width,
                spriteArray[index].rect.height
            );
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
