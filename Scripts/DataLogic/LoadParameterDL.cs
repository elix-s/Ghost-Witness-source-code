using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Компонент загрузки параметров
/// </summary>
public class LoadParameterDL : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Загрузка параметров
    /// </summary>
    /// <param name="parameterList">Список параметров</param>
    public void LoadParameters(List<ParameterEntity> parameterList)
    {
        try
        {
            parameterList.Clear();

            parameterList.Add(new ParameterEntity("0РуфусОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[0].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[0].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[0].visiblesRangeList[0].Text = "Отношение с Руфусом: подозрение";
            //parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Руфусом: сомнение"));
            //parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Руфусом: нейтральное"));
            //parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Руфусом: доверие"));
            //parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Руфусом: дружелюбие"));
            parameterList[0].visiblesRangeList[0].Text = "Отношение с Руфусом: подозрение <>";
            parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Руфусом: сомнение <>"));
            parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Руфусом: нейтральное <>"));
            parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Руфусом: доверие <>"));
            parameterList[0].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Руфусом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("1СтерлингОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[1].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[1].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[1].visiblesRangeList[0].Text = "Отношение со Стерлингом: подозрение";
            //parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение со Стерлингом: сомнение"));
            //parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение со Стерлингом: нейтральное"));
            //parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение со Стерлингом: доверие"));
            //parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение со Стерлингом: дружелюбие"));
            parameterList[1].visiblesRangeList[0].Text = "Отношение со Стерлингом: подозрение <>";
            parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение со Стерлингом: сомнение <>"));
            parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение со Стерлингом: нейтральное <>"));
            parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение со Стерлингом: доверие <>"));
            parameterList[1].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение со Стерлингом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("2ДжонсонОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[2].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[2].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[2].visiblesRangeList[0].Text = "Отношение с Джонсоном: подозрение";
            //parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Джонсоном: сомнение"));
            //parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Джонсоном: нейтральное"));
            //parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Джонсоном: доверие"));
            //parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Джонсоном: дружелюбие"));
            parameterList[2].visiblesRangeList[0].Text = "Отношение с Джонсоном: подозрение <>";
            parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Джонсоном: сомнение <>"));
            parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Джонсоном: нейтральное <>"));
            parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Джонсоном: доверие <>"));
            parameterList[2].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Джонсоном: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("3АннаОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[3].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[3].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[3].visiblesRangeList[0].Text = "Отношение с Анной: подозрение";
            //parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Анной: сомнение"));
            //parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Анной: нейтральное"));
            //parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Анной: доверие"));
            //parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Анной: дружелюбие"));
            parameterList[3].visiblesRangeList[0].Text = "Отношение с Анной: подозрение <>";
            parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Анной: сомнение <>"));
            parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Анной: нейтральное <>"));
            parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Анной: доверие <>"));
            parameterList[3].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Анной: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("4ЛизаОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[4].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[4].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[4].visiblesRangeList[0].Text = "Отношение с Лизой: подозрение";
            //parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Лизой: сомнение"));
            //parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Лизой: нейтральное"));
            //parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Лизой: доверие"));
            //parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Лизой: дружелюбие"));
            parameterList[4].visiblesRangeList[0].Text = "Отношение с Лизой: подозрение <>";
            parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Лизой: сомнение <>"));
            parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Лизой: нейтральное <>"));
            parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Лизой: доверие <>"));
            parameterList[4].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Лизой: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("5БиллОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[5].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[5].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[5].visiblesRangeList[0].Text = "Отношение с Биллом: подозрение";
            //parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Биллом: сомнение"));
            //parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Биллом: нейтральное"));
            //parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Биллом: доверие"));
            //parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Биллом: дружелюбие"));
            parameterList[5].visiblesRangeList[0].Text = "Отношение с Биллом: подозрение <>";
            parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Биллом: сомнение <>"));
            parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Биллом: нейтральное <>"));
            parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Биллом: доверие <>"));
            parameterList[5].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Биллом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("6ЛианаОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[6].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[6].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[6].visiblesRangeList[0].Text = "Отношение с Лианой: подозрение";
            //parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Лианой: сомнение"));
            //parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Лианой: нейтральное"));
            //parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Лианой: доверие"));
            //parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Лианой: дружелюбие"));
            parameterList[6].visiblesRangeList[0].Text = "Отношение с Лианой: подозрение <>";
            parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Лианой: сомнение <>"));
            parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Лианой: нейтральное <>"));
            parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Лианой: доверие <>"));
            parameterList[6].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Лианой: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("7ДонОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[7].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[7].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[7].visiblesRangeList[0].Text = "Отношение с Доном: подозрение";
            //parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Доном: сомнение"));
            //parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Доном: нейтральное"));
            //parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Доном: доверие"));
            //parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Доном: дружелюбие"));
            parameterList[7].visiblesRangeList[0].Text = "Отношение с Доном: подозрение <>";
            parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Доном: сомнение <>"));
            parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Доном: нейтральное <>"));
            parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Доном: доверие <>"));
            parameterList[7].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Доном: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("8НейтонОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[8].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[8].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[8].visiblesRangeList[0].Text = "Отношение с Нейтом: подозрение";
            //parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Нейтом: сомнение"));
            //parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Нейтом: нейтральное"));
            //parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Нейтом: доверие"));
            //parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Нейтом: дружелюбие"));
            parameterList[8].visiblesRangeList[0].Text = "Отношение с Нейтом: подозрение <>";
            parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Нейтом: сомнение <>"));
            parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Нейтом: нейтральное <>"));
            parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Нейтом: доверие <>"));
            parameterList[8].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Нейтом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("9ДаниэльОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[9].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[9].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[9].visiblesRangeList[0].Text = "Отношение с Даниэлем: подозрение";
            //parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Даниэлем: сомнение"));
            //parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Даниэлем: нейтральное"));
            //parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Даниэлем: доверие"));
            //parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Даниэлем: дружелюбие"));
            parameterList[9].visiblesRangeList[0].Text = "Отношение с Даниэлем: подозрение <>";
            parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Даниэлем: сомнение <>"));
            parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Даниэлем: нейтральное <>"));
            parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Даниэлем: доверие <>"));
            parameterList[9].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Даниэлем: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("10РальфОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[10].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[10].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[10].visiblesRangeList[0].Text = "Отношение с Ральфом: подозрение";
            //parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Ральфом: сомнение"));
            //parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Ральфом: нейтральное"));
            //parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Ральфом: доверие"));
            //parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Ральфом: дружелюбие"));
            parameterList[10].visiblesRangeList[0].Text = "Отношение с Ральфом: подозрение <>";
            parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Ральфом: сомнение <>"));
            parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Ральфом: нейтральное <>"));
            parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Ральфом: доверие <>"));
            parameterList[10].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Ральфом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("11АльфредОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[11].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[11].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[11].visiblesRangeList[0].Text = "Отношение с Альфредом: подозрение";
            //parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Альфредом: сомнение"));
            //parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Альфредом: нейтральное"));
            //parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Альфредом: доверие"));
            //parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Альфредом: дружелюбие"));
            parameterList[11].visiblesRangeList[0].Text = "Отношение с Альфредом: подозрение <>";
            parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Альфредом: сомнение <>"));
            parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Альфредом: нейтральное <>"));
            parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Альфредом: доверие <>"));
            parameterList[11].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Альфредом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("12ГенриОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[12].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[12].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[12].visiblesRangeList[0].Text = "Отношение с Генри: подозрение";
            //parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Генри: сомнение"));
            //parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Генри: нейтральное"));
            //parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Генри: доверие"));
            //parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Генри: дружелюбие"));
            parameterList[12].visiblesRangeList[0].Text = "Отношение с Генри: подозрение <>";
            parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Генри: сомнение <>"));
            parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Генри: нейтральное <>"));
            parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Генри: доверие <>"));
            parameterList[12].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Генри: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("13МайкОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[13].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[13].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[13].visiblesRangeList[0].Text = "Отношение с Майком: подозрение";
            //parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Майком: сомнение"));
            //parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Майком: нейтральное"));
            //parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Майком: доверие"));
            //parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Майком: дружелюбие"));
            parameterList[13].visiblesRangeList[0].Text = "Отношение с Майком: подозрение <>";
            parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Майком: сомнение <>"));
            parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Майком: нейтральное <>"));
            parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Майком: доверие <>"));
            parameterList[13].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Майком: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("14БенджаминОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[14].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[14].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[14].visiblesRangeList[0].Text = "Отношение с Бенджамином: подозрение";
            //parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Бенджамином: сомнение"));
            //parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Бенджамином: нейтральное"));
            //parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Бенджамином: доверие"));
            //parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Бенджамином: дружелюбие"));
            parameterList[14].visiblesRangeList[0].Text = "Отношение с Бенджамином: подозрение <>";
            parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Бенджамином: сомнение <>"));
            parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Бенджамином: нейтральное <>"));
            parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Бенджамином: доверие <>"));
            parameterList[14].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Бенджамином: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("15МиланаОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[15].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[15].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[15].visiblesRangeList[0].Text = "Отношение с Миланой: подозрение";
            //parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Миланой: сомнение"));
            //parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Миланой: нейтральное"));
            //parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Миланой: доверие"));
            //parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Миланой: дружелюбие"));
            parameterList[15].visiblesRangeList[0].Text = "Отношение с Миланой: подозрение <>";
            parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Миланой: сомнение <>"));
            parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Миланой: нейтральное <>"));
            parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Миланой: доверие <>"));
            parameterList[15].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Миланой: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("16ЭдвардОтношение[0, 20]", 0, 20, 10, false, true));
            parameterList[16].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[16].visiblesRangeList[0].StopRangeVisibleValue = 3;
            //parameterList[16].visiblesRangeList[0].Text = "Отношение с Эдвардом: подозрение";
            //parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Эдвардом: сомнение"));
            //parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Эдвардом: нейтральное"));
            //parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Эдвардом: доверие"));
            //parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Эдвардом: дружелюбие"));
            parameterList[16].visiblesRangeList[0].Text = "Отношение с Эдвардом: подозрение <>";
            parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(4, 8, "Отношение с Эдвардом: сомнение <>"));
            parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(9, 11, "Отношение с Эдвардом: нейтральное <>"));
            parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(12, 16, "Отношение с Эдвардом: доверие <>"));
            parameterList[16].visiblesRangeList.Add(new VisiblesRangeEntity(17, 20, "Отношение с Эдвардом: дружелюбие <>"));

            parameterList.Add(new ParameterEntity("17РезервОтношение02[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("18РезервОтношение03[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("19РезервОтношение04[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("20РезервОтношение05[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("21РезервОтношение06[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("22РезервОтношение07[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("23РезервОтношение08[0, 20]", 0, 20, 10, false, true));
            parameterList.Add(new ParameterEntity("24РезервОтношение09[0, 20]", 0, 20, 10, false, true));

            parameterList.Add(new ParameterEntity("25Записки Джимии:", 0, 0, 0, true, true));
            parameterList[25].visiblesRangeList[0].Text = "\r\nЗаписки Джимии:";

            parameterList.Add(new ParameterEntity("26АктивностьДиалогРуфус[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("27АктивностьДиалогДжонсон[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("28АктивностьДиалогАнна[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("29ПосещениеПолиции[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("30ПосещениеОтеля[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("31Резерв101[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("32Резерв102[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("33Резерв103[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("34Резерв104[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("35Резерв105[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("36Резерв106[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("37Резерв107[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("38Резерв108[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("39Резерв109[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("40Записи2День[0, 0]", 0, 0, 0, false, true));
            parameterList[40].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[40].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[40].visiblesRangeList[0].Text = "Вторник, 11 сентября.";

            parameterList.Add(new ParameterEntity("41ИнформацияОЗанятииОриентированием[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("42БиллВремяКарл[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("43АктивностьДиалогЛианнна[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("44АктивностьДиалогБилл[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("45ВыходИзДомаВигсов[0, 3]", 0, 3, 0, false, true));
            parameterList.Add(new ParameterEntity("46ОсмотрКомнатыКарла[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("47АктивностьДиалогСемьяУисли[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("48АктивностьДиалогДон[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("49АктивностьДиалогНейт[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("50АктивностьДиалогРальф[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("51АктивностьДиалогДаниэль[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("52ВозвращениеВОтель[0, 3]", 0, 3, 0, false, true));

            parameterList.Add(new ParameterEntity("53ДонИНейтОтношение[0, 1]", 0, 1, 0, false, true));
            parameterList[53].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[53].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[53].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Дон в разговоре с Руфусом как-то сказал, что Нейт больше любит Билла, чем его. В целом создается впечатление, что в их отношениях далеко не все гладко."));

            parameterList.Add(new ParameterEntity("54КарлИБиллОтношение[0, 1]", 0, 1, 0, false, true));
            parameterList[54].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[54].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[54].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Во время общения с Биллом он был закрыт и скрытен. Лиана рассказала о том, что Билл мало уделял время Карлу."));

            parameterList.Add(new ParameterEntity("55ЗакрытостьНейта[0, 1]", 0, 1, 0, false, true));
            parameterList[55].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[55].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[55].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Нейт не сильно горел желанием что-либо рассказывать о Карле. Также он упомянул о том, что в последнее время они не общались."));

            parameterList.Add(new ParameterEntity("56ИнформацияОЖенеДона[0, 1]", 0, 1, 0, false, true));
            parameterList[56].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[56].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[56].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"По словам Дона, родители Нейта в разводе. По каким-то причинами Нейт не знает, почему развелись его родители."));

            parameterList.Add(new ParameterEntity("57ИнформацияОСтефане[0, 1]", 0, 1, 0, false, true));
            parameterList[57].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[57].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[57].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Ральф рассказал о том, что его друг Альфред видел Стефана. Стефан - сбежавший преступник. Возможно исчезновение Карла может быть связано со Стефаном?"));

            parameterList.Add(new ParameterEntity("58Резерв201[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("59Резерв202[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("60Резерв203[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("61Резерв204[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("62Резерв205[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("63Резерв206[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("64Резерв207[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("65Резерв208[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("66Резерв209[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("67Записи3День[0, 0]", 0, 0, 0, false, true));
            parameterList[67].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[67].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[67].visiblesRangeList[0].Text = "\r\nСреда, 12 сентября.";

            parameterList.Add(new ParameterEntity("68ЗнаниеРуфусаОСтефане[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("69АктивностьДиалогаСРуфусом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("70АктивностьДиалогаСоСтерилингом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("71АктивностьДиалогаСДжонсоном[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("72АктивностьДиалогаСАнной[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("73ВыходИзУчастка[0, 3]", 0, 3, 0, false, true));
            parameterList.Add(new ParameterEntity("74ЭдвардРэдлиИнформация[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("75АктивностьДиалогаСЭдвардом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("76ИнформацияОБене[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("77АктивностьДиалогаСАльфредом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("78Резерв300[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("79ВозвращениеВОтель[0, 4]", 0, 4, 0, false, true));

            parameterList.Add(new ParameterEntity("80СвязьГенриСНаркотиками[0, 1]", 0, 1, 0, false, true));
            parameterList[80].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[80].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[80].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Случаи употребления наркотиков совпали с приходом к руководству заводом Генри Мартона. Несколько людей высказали подозрения по этому поводу. Альфред даже устроил свое небольшое расследование и проник на территорию завода. Альфред заметил, что количество охраны на территории завода резко возросло."));

            parameterList.Add(new ParameterEntity("81БоязньДжонсонаВозвращенияСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList[81].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[81].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[81].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Волнительная реакция Джонсона но возможное возвращение убийцы его отца вполне объяснима. Однако Джимми увидел в реакции Джонсона нечто другое. Он увидел там неподдельный страх."));

            parameterList.Add(new ParameterEntity("82ЗащитаАннойСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList[82].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[82].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[82].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"То, что Анна и Стефан дружили в школьные годы стало для Джимми сюрпризом. Похоже, что Анна пытается даже оправдать Стефана. Или это Джимми только показалось?"));

            parameterList.Add(new ParameterEntity("83УгрозыГенриЭдварду[0, 1]", 0, 1, 0, false, true));
            parameterList[83].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[83].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[83].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Эдвард поделился информацией о том, что Генри Мартон угражал ему при совершении сделки по продаже акций. Генри это отрицает, оправдываясь жадностью Эдварда. На чьей стороне правда?"));

            parameterList.Add(new ParameterEntity("84ИнформацияОБене[0, 1]", 0, 1, 0, false, true));
            parameterList[84].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[84].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[84].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Пару лет назад в лесу видели странного человека, который сказал, что его зовут Бен. На рисунке Карла тоже было написано это имя. Это просто совпадение или что-то большее?"));

            parameterList.Add(new ParameterEntity("85ВзволнованностьГенриПослеНовостиОСтефане[0, 1]", 0, 1, 0, false, true));
            parameterList[85].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[85].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[85].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Поведение Генри Мартона было весьма странным. Вначале он держался очень спокойно и хладнокровно. Но все изменила новость о том, что Альфред видел Стефана Кнайта. На несколько мгновений на лице Генри отобразилось искреннее изумление и даже страх. Что еще мог знать Генри о Стефане?"));

            parameterList.Add(new ParameterEntity("86Резерв301[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("87Резерв302[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("88Резерв303[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("89Резерв304[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("90Резерв305[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("91Резерв306[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("92Резерв307[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("93Резерв308[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("94Резерв309[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("95Записи4День[0, 0]", 0, 0, 0, false, true));
            parameterList[95].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[95].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[95].visiblesRangeList[0].Text = "\r\nЧетверг, 13 сентября.";

            parameterList.Add(new ParameterEntity("96РазговорСоСтерлингом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("97РазговорСДоном[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("98ПропажаМэриУисли[0, 1]", 0, 1, 0, false, true));
            parameterList[98].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[98].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[98].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Выяснилось, что Дон не развелся со своей женой, а она таинственным образом исчезла. Ее судьба до сих пор не известна. Полиция не нашла доказательств причастия Дона к пропаже Мэри."));

            parameterList.Add(new ParameterEntity("99ЗавистьНейта[0, 1]", 0, 1, 0, false, true));
            parameterList[99].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[99].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[99].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"В разговоре с Нейтом Джимми не увидел сильного расстройства и переживаний Нейта из-за пропажи Карла. Джимми показалось, что Нейт завидует, что у Карла более хорошие условия для учебы и занятий спорта, чем у Нейта."));

            parameterList.Add(new ParameterEntity("100ПодозрениеДона[0, 1]", 0, 1, 0, false, true));
            parameterList[100].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[100].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[100].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Лиза сказала о том, что Дон возможно знал об отношениях Мэри на стороне. Могло ли это явиться причиной исчезновения Мэри?"));

            parameterList.Add(new ParameterEntity("101ДовериеКДонуСоСтороныСтерлинга[0, 1]", 0, 1, 0, false, true));
            parameterList[101].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[101].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[101].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"После исчезновения Мэри Дон должен был являться главным подозреваемым. Ведь у него был серьезный мотив для преступления. Но Стерлинг достаточно быстро снял подозрения с Дона, в виду его не слишком сильного алиби. Это недоработка или есть какой-то умысел?"));

            parameterList.Add(new ParameterEntity("102ОтношенияМэриНаСтороне[0, 1]", 0, 1, 0, false, true));
            parameterList[102].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[102].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[102].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"По всей видимости, у Дона были серьезные причины для ревности к Мэри. Мэри была общительной, у нее было много друзей мужчин и она была довольно легкомысленной. Мэри призналась Лизе, что ходила на свидание с мужчиной в тайне от Дона. Осталось ли это тайной для него?"));

            parameterList.Add(new ParameterEntity("103Резерв401[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("104Резерв402[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("105Резерв403[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("106Резерв404[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("107Резерв405[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("108Резерв406[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("109Резерв407[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("110Резерв408[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("111Резерв409[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("112Записи5День[0, 0]", 0, 0, 0, false, true));
            parameterList[112].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[112].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[112].visiblesRangeList[0].Text = "\r\nПятница, 14 сентября.";

            parameterList.Add(new ParameterEntity("113АктивностьРазговораСРальфом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("114ПосещениеМестаПроисшествия[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("115НежеланиеСтерлингаНачатьРасследование[0, 1]", 0, 1, 0, false, true));
            parameterList[115].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[115].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[115].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Несмотря на то, что существуют серьезные основания для того, чтобы начать расследование, Стерлинг не принимает доводов и классифицирует случившееся как несчастный случай."));

            parameterList.Add(new ParameterEntity("116НежеланиеДжонсонаНачатьРасследование[0, 1]", 0, 1, 0, false, true));
            parameterList[116].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[116].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[116].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Джонсон осмотрел место происшествия и принял однозначное решение о том, что это несчастный случай. Он упустил из вида то, что есть лица, которые заинтересованы в смерти Альфреда."));

            parameterList.Add(new ParameterEntity("117ОтрицаниеДжонсонаВозможностиВозвращенияСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList[117].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[117].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[117].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Несмотря на то, что Альфред убедительно утверждал, что видел Стефана, Джонсон по прежнему не верит в эту возможность и списывает все на слабость зрения Альфреда."));

            parameterList.Add(new ParameterEntity("118ОтсутствиеРальфа", 0, 1, 0, false, true));
            parameterList[118].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[118].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[118].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Ральф крайне редко покидает территорию дома престарелых. Но в момент гибели Альфреда, его там не было. Где же он был?"));

            parameterList.Add(new ParameterEntity("119ИнтересГенриКСтефану[0, 1]", 0, 1, 0, false, true));
            parameterList[119].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[119].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[119].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Как утверждает Генри, он не знал Стефана. Но откуда этот непонятный интерес Генри к Стефану? Это чистое любопытство или что-то другое?"));

            parameterList.Add(new ParameterEntity("120РальфШелПоНаправлениюКАльфреду[0, 1]", 0, 1, 0, false, true));
            parameterList[120].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[120].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[120].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Даниэль утверждает, что видел как утром Ральф шел по Гастингс Стрит по направлению к дому Альфреда. Что ему там понадобилось в столь ранний час?"));

            parameterList.Add(new ParameterEntity("121Резерв501[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("122Резерв502[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("123Резерв503[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("124Резерв504[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("125Резерв505[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("126Резерв506[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("127Резерв507[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("128Резерв508[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("129Резерв509[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("130Записи6День[0, 0]", 0, 0, 0, false, true));
            parameterList[130].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[130].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[130].visiblesRangeList[0].Text = "\r\nСуббота, 15 сентября.";

            parameterList.Add(new ParameterEntity("131РазговорСРуфусомАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("132ИнформацияОБенджаминеХартоне[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("133ПодозрениеСтерлингаДжонсона[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("134ПодозрениеАнныДжонсоном[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("135РазговорСоСтерлингомАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("136РазговорСДжонсономАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("137РазговорСАннойАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("138ДружбаДонаИЛианы[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("139РазговорСЛианойАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("140РазговорСБилломАктивность[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("141ПосещениеПолицейскогоУчасткаАктивность[0, 3]", 0, 3, 0, false, true));
            parameterList.Add(new ParameterEntity("142АктивностьПосещенияДомаВигсов[0, 2]", 0, 2, 0, false, true));
            parameterList.Add(new ParameterEntity("143АктивностьРазговораСДоном[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("144АктивностьРазговораСНейтом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("145АктивностьПосещенияДомаВигсов[0, 2]", 0, 2, 0, false, true));
            parameterList.Add(new ParameterEntity("146ПобегМэри[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("147АктивностьРазговораСЛизой[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("148АктивностьРазговораСДаниэлем[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("149РазногласиеАльфредаИРуфуса[0, 1]", 0, 1, 0, false, true));
            parameterList[149].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[149].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[149].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Между Альфредом и Руфусом когда-то произошел конфликт, связанный с тем, что они любили одну женщину. В итоге, на этой женщине женился Альфред."));

            parameterList.Add(new ParameterEntity("150АктивностьРазговораСРальфом[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("151АктивностьРазговораСГенри[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("152ЭдвардИНаркотики [0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("153АктивностьРазговораСЭдвардом[0, 1]", 0, 1, 1, false, true));
            parameterList.Add(new ParameterEntity("154ВозвращениеВОтельКонецДня[0, 13]", 0, 13, 0, false, true));

            parameterList.Add(new ParameterEntity("155ПотдверждениеВозвращенияСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList[155].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[155].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[155].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Анна призналась в том, что Стефан один раз связывался по телефону с ней и сообщил о своем намерении вернуться в Лонлифарм."));

            parameterList.Add(new ParameterEntity("156УгрозаКарлуСоСтороныДона[0, 1]", 0, 1, 0, false, true));
            parameterList[156].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[156].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[156].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Нейт рассказал о том, что однажды в спышке гнева Дон угрожал убить Карла. Был ли это просто эмоциональный срыв или что-то более серьезное?"));

            parameterList.Add(new ParameterEntity("157ПодозренийНейтаОтца[0, 1]", 0, 1, 0, false, true));
            parameterList[157].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[157].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[157].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Нейт считает, что в исчезновении его мамы виновен Дон."));

            parameterList.Add(new ParameterEntity("158НамерениеМэриУбежатьОтДона[0, 1]", 0, 1, 0, false, true));
            parameterList[158].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[158].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[158].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Лиза вспомнила подробность о том, что однажды Мэри на эмоциях сказала Лизе о том, что хочет убежать от Дона. Были ли это просто слова или Мэри реализовала свое намерение?"));

            parameterList.Add(new ParameterEntity("159ЕщеОдинСвидетельСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList[159].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[159].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[159].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Приятель Даниэля видел в машине человека, похожего на Стефана. Машина двигалась по направлению к заводу."));

            parameterList.Add(new ParameterEntity("160Резерв600НеубедительнаяВерсияРальфа[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("161ВзяткаГенри[0, 1]", 0, 1, 0, false, true));
            parameterList[161].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[161].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[161].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Генри не на шутку испугался возможной проверки их деятельности и предложил серьезную взятку."));

            parameterList.Add(new ParameterEntity("162РастерянностьЭдварда[0, 1]", 0, 1, 0, false, true));
            parameterList[162].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[162].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[162].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Эдвард Рэдли резко поменял свое поведение после просьбы рассказать об уголовном деле, которое завели на него в связи с подозрением в распространении наркотиков. О том, что такое дело действительно существовало, рассказал Генри Мартон."));

            parameterList.Add(new ParameterEntity("163МахинацияГенри[0, 1]", 0, 1, 0, false, true));
            parameterList[163].visiblesRangeList[0].StartRangeVisibleValue = 0;
            parameterList[163].visiblesRangeList[0].StopRangeVisibleValue = 0;
            parameterList[163].visiblesRangeList.Add(new VisiblesRangeEntity(1, 1, @"Эдвард Рэдли продал свою часть акций завода под влиянием странного уголовного процесса. Есть основания полагать, что данный процесс инициирован Генри Мартоном, с целью создать давление на Эдварда."));

            parameterList.Add(new ParameterEntity("164СогласиеНаВзяткуОтГенри[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("165Резерв601[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("166Резерв602[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("167Резерв603[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("168Резерв604[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("169Резерв605[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("170Резерв606[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("171Резерв607[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("172Резерв608[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("173Резерв609[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("174Резерв610[0, 1]", 0, 1, 0, false, true));

            parameterList.Add(new ParameterEntity("175ОбвинениеСтерлинг[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("176ОбвинениеДжонсона[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("177ОбвинениеАнны[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("178ОбвинениеБилла[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("179ОбвинениеЛианы[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("180ОбвинениеДона[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("181ОбвинениеЛизы[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("182ОбвинениеДаниэля[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("183ОбвинениеРальфа[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("184ОбвинениеЭдварда[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("185ОбвинениеРуфуса[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("186ОбвинениеСтефана[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("187ОбвинениеГенри[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("188ОбвинениеБенджамина[0, 1]", 0, 1, 0, false, true));
            parameterList.Add(new ParameterEntity("189Успех[0, 1]", 0, 1, 0, false, true));
        }
        catch
        {
            Debug.LogError("LoadParameters");
            parameterList.Clear();
        }
    }
}
