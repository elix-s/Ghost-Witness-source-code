using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Компонент загрузки локаций и переходов
/// </summary>
public class LoadLocationPassageDL : MonoBehaviour
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
    /// Загрузка локаций и переходов
    /// </summary>
    /// <param name="locationDictionary">Словарь локаций и переходов</param>
    public void LoadLocationsPassages(Dictionary<int, LocationEntity> locationDictionary)
    {
        locationDictionary.Clear();

        #region Day 1
        LocationEntity locationEntity = new LocationEntity();
        locationEntity.Text = @"Понедельник, 27 сентября.
Тихое место.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 10, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RoadInTheMountains;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(0, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Прохладное утро сентября. За окном автомобиля проносится густой хвойный лес. На горизонте виднеются очертания горного массива.
Старший детектив полиции Джимми Хаксли прибавляет температуру в салоне и задумчиво смотрит на живописные пейзажи. 
Кто знает, чем закончится для него новое дело? Пятнадцать лет работы детективом полиции не прошли для Джимми даром - он мог интуитивно чувствовать, когда впереди ожидается нелегкая работа.
Впрочем, даже без помощи интуиции вполне очевидно, что дела, которые касаются детей расследовать особенно трудно.
Вот уже месяц, как в небольшом провинциальном городе Лонлифарм ведутся поиски без вести пропавшего Карла Вигса - двенадцатилетнего подростка. Полицией был прочесан весь город и окрестности - никаких следов. Куда он мог пропасть? В городе никогда не случалось ничего подобного.
Спустя три недели происходит нечто странное - в почтовом ящике семьи Вигсов находят некий рисунок - родственники Карла утверждают, что он нарисован Карлом. Вполне вероятно, что это похищение. Но почему не приходит требование о выкупе? Возможно подросток сам убежал из дома?
Все эти мысли не давали покоя Джимми.
И вот на горизонте показываются очертания города. Окруженный холмами, покрытыми густым лесным массивом, Лонлифарм выглядел одиноко, как будто все жители давно разъехались по большим городам. Стоящий с самого утра туман придавал всему происходящему нечто странное и таинственное.
Отбросив лишние мысли, Джимми Хаксли прибавляет скорость и въезжает в город.";
        locationEntity.passageList.Add(new PassageEntity("Ехать в отель.", 20, 0));
        locationEntity.passageList.Add(new PassageEntity("Ехать в полицейский участок.", 140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RoadInTheMountains;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(10, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"<b>Отель Вестбридж.</b>";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с администратором отеля.", 30, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(26, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Снять номер.", 100, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(20, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Администратор отеля был светловолосый человек среднего роста с мягким взглядом и широким лицом. На вид ему было лет сорок. Он приветливо смотрел на Карла.
- Джимми: Добрый день, мистер. Меня зовут Джимми Хаксли. Я детектив полиции. Я сегодня первый день в вашем городе. Я приехал в город для расследования исчезновения Карла Вигса. Найдете для меня пару минут?
- Руфус: Добрый день! Да, конечно. Меня зовут Руфус Бэнтли. Если потребуется - я готов оказать всю необходимую помощь. 
Кстати, можете не сомневаться, что наш отель является лучшим в Лонлифарме и вы не зря сделали, что решили остановиться у нас. Хотя выбора у вас особо и нет, потому что наш отель - единственный в городе. Итак, чем могу быть полезен?
- Джимми: Мне уже нравится ваш отель. Спокойное и уютное место. Вы давно тут работаете?
- Руфус: О да. Скоро будет уже пятнадцать лет. Я устроился сюда сразу же после переезда из Брэнхэма, где учился в колледже. Место здесь тихое, постояльцев много не бывает - работа не трудная, меня все тут устраивает. Не люблю я больших и шумных городов.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Вам нравится, что в вашем отеле мало постояльцев? Не сильно любите напрягаться?", 40, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Мне нравятся люди, которым нравится то, чем они занимаются. Думаю, вам много кто завидует.", 50, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(30, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Довольно странный вывод, должен заметить. У нас мало постояльцев потому что в наш город не так часто приезжают. Если бы я не любил работать, я бы тут не стоял.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 60, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(40, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Я уж не знаю на счет зависти. Я бы на месте других себе не завидовал. Но то, что мне нравится моя работа, мой отель и наш тихий городок - это чистая правда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 60, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(50, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Руфус. Вы лично знаете семью Вигсов?
- Руфус: Разумеется. Наш город совсем небольшой, я знаю тут всех. Очень порядочная и хорошая семья. Уму непостижимо, что могло случиться с Карлом. Весь город переживает по этому поводу. Такое у нас случается не часто, мягко говоря.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Хорошо. Мистер Руфус, основной версией на данный момент является похищение. Раз вы знаете тут всех, то возможно хотели бы поделиться со мной информацией о жителях Лонлифарма, которые потенциально способны на такое?", 70, 0));
        locationEntity.passageList.Add(new PassageEntity("Среди постояльцев отеля за последний месяц не было каких-либо подозрительных личностей?", 80, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(60, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Если бы я кого-то подозревал, то уже давно рассказал об этом полиции. Но у нас никогда ничего подобного не происходило - я просто не могу предположить, кто способен на такое в нашем городе.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 90, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(70, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Пожалуй, что нет. За последний месяц постояльцев было мало - в основном это люди, которые приезжают по рабочим делам на лесодобывающий завод и через несколько дней уезжают. Выделить кого-то я не могу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 90, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(80, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Хорошо, Руфус. Удачного рабочего дня.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 20, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(26, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(90, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подошел к стойке администратора. 
- Джимми: Доброе утро, мисс! Какой сегодня морозный денек. Мне бы снять недорогой номер на одного человека на неопределенный период времени.
- Мисс Тернер: Добрый день, мистер! Рада приветствовать вас в нашем скромного городке. У нас все номера недорогие и уютные. Я вас провожу в ваш номер.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 110, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"<b>Номер отеля.</b>";
        locationEntity.passageList.Add(new PassageEntity("Ехать в полицейский участок.", 140, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(29, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(30, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Осмотреть номер.", 115, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(29, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Осмотреть номер.", 120, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(29, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отдохнуть.", 130, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(29, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отдохнуть.", 370, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(29, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Мисс Тернер не соврала. Номер был и в правду небольшой и довольно скромно обставленный, но довольно уютный и аккуратно убранный. Джимми ненадолго задумался о том, насколько долго ему предстоит здесь остаться.
В номере имелся небольшой телевизор, просторная широкая кровать. Минимализм, но за небольшие деньги. Джимми остался вполне доволен.
Тем временем на часах было уже три часа дня. Скорее всего за сегодня удастся посетить только полицейский участок и познакомиться с местным составом. Пора выезжать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 110, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(115, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Мисс Тернер не соврала. Номер и в правду небольшой и скромно обставленный, но довольно уютный и хорошо прибранный. Джимми ненадолго задумался о том, сколько ему предстоит прожить в этом номере.
В номере имелся небольшой телевизор, просторный широкий диван. Минимализм, но за небольшие деньги. Джимми остался вполне доволен.
Но пора взяться за дела.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 110, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(120, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Отличная мысль, но немного несвоевременная. Еще ничего не сделано - Джимми нужно съездить в полицейский участок и ознакомиться с текущими подробностями расследования.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 110, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Полицейский участок в Лонлифарме выглядел примерно так, как представлял себе Джимми. Небольшое, старое двухэтажное здание из бетона. На втором этаже помещения сдавались под аренду, а на первом непосредственно располагался участок. Джимми вошел внутрь здания.
На входе никого не было. Джимми прошел по небольшому коридору и уперся в крепкую деревянную дверь с табличкой - Стерлинг Хансон - шеф полиции Лонлифарма. Джимми негромко постучался и вошел в кабинет.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 145, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Стерлингу было уже за пятьдесят лет. Работа шефом полиции - не самое спокойное занятие на свете. Видимо этот факт нашел отражение в глубоких морщинах на его лице. Стерлинг обладал внушительной комплекцией и широкими плечами.
- Джимми: Добрый день, мистер Стерлинг. Мое имя - Джимми Хаксли. Я старший детектив, меня прислали к вам из Йорк-Сити. Вам наверное сообщали обо мне.
- Стерлинг: Здравствуте мистер Хаксли! Да, разумеется, мне сообщили о вас дня три назад. Приветствую вас в нашем городе. Надеюсь ничто не будет мешать вам работать. Как вы доехали, без приключений?
- Джимми: Да, все в порядке. С утра было очень прохладно, я уже отвык от такой погоды.
- Стерлинг: Да, это вам не Йорк-Сити. В этом году похолодание наступило слишком быстро. Я сам тут мерзну, отопление в участок еще не дали - до зимы еще очень далеко.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Может быть вы мерзнете потому что не слишком активно работаете над установлением местоположения Карла?", 150, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Надеюсь я вам помогу в расследовании этой неприятной ситуации. За успешный исход расследования вам включат отопление куда быстрее.", 160, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(145, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да вы остряк. У вас в столице все такие высокомерные?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 170, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(150, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Не сомневаюсь, мистер Хаксли. А то просижу в холоде в этом чертовом кабинете всю зиму.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 170, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(160, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Расскажите пожалуйста поподробнее о пропаже Карла. Что известно на данный момент? Я читал лишь общий отчет.
- Стерлинг: Я думаю вам все известно из отчета. Карл Вигс, двенадцать лет. Пропал вечером третьего сентября. Ушел гулять в лес и не вернулся. Две недели весь состав полиции нашего города прочесывал лес, но ничего не нашли. Никаких следов. Карл был спортсменом, занимался спортивным ориентированием. В лесу у нас есть тренировочная трасса, там часто занимаются ребята из местного кружка. По всей видимости, он направлялся туда.
Самое загадочное то, что родители Карла в конце сентября обнаружили у себя в почтовом ящике некий рисунок. На нем детской рукой нарисован лес и написано слово - ""Бэн"". Родители Карла уверены, что рисунок нарисован Карлом, и никем иным. Рисунок мы отдавали на экспертизу, где подтвердилось, что он нарисован рукой Карла. Когда именно был сделан рисунок не понятно.
- Джимми: Возможно Карл просто сбежал из дома, а рисунок подкинул, чтобы родители не волновались ?
-Стерлинг : Конечно, это возможно. Но для этого мы не видим никаких предпосылок. Не мог же он просто взять и ни с того ни с сего убежать? Мы многократно допрашивали родителей Карла.У них всегда были хорошие отношения. Никаких разногласий. Все это подтверждают его друзья, учителя.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Не всегда правда то, что лежит на поверхности. Возможно вы недоработали родителей, они могут что-то не договаривать.", 180, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я вижу, что вы проделали серьезную работу. Похоже версия, что Карл просто убежал из дома не состоятельна.", 190, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(170, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Конечно, это так. Но, мы работаем в полиции не первый день. И кое-как, но умеем определять где правда, а где ложь. Но возможно вы сможете выведать у них что-то, что не получилось у нас.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 200, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(180, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да, это самое важное дело для нас за весь год. Мы прикладываем все усилия. Жаль, что пока все безрезультатно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 200, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(190, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Стерлинг, у кого мне можно получить список и контакты близких к Карлу людей - родителей, его друзей, учителей? Без более детального изучения окружения Карла я вряд ли куда-то продвинусь.
- Стерлинг: Да, конечно. Список окружения Карла есть у Анны Смит - секретаря нашего отдела. Обязательно поговорите с Джонсоном Купером - лейтенантом, который сейчас ведет это дело.
- Джимми: Большое спасибо, сэр.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 210, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Джонсоном.", 220, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(27, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Анной.", 290, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(28, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из участка.", 360, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(27, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(28, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(30, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из участка.", 365, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(27, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(28, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(30, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Кабинет Джонсона располагался по соседству с кабинетом Стерлинга. Джимми постучался и, не дожидаясь ответа, вошел. Рабочий кабинет Джонсона был крайне маленьким, из интерьера в нем присутствовали только стол и небольшой шкаф.
Джонсон был молодым парнем худощавого телосложения с темными густыми волосами. При этом он был довольно высокого роста. На вид ему было лет двадцать пять.
- Джимми: Привет, Джонсон. Я детектив из Йорк-Сити, меня прислали помочь вам в расследовании пропажи Карла. Надеюсь, не слишком вам мешать.
- Джонсон: Добрый день! Опытного детектива нам как раз и не хватает. Дело очень странное и сложное. Мы стараемся, но уже почти месяц нет никаких результатов. Есть надежда, что Карл жив. Вам наверняка известно про рисунок.
- Джимми: Да, если это действительно нарисовал Карл, то это дает нам шанс. Джонсон, как давно ты работаешь в полиции?
- Джонсон: Всего лишь третий год. Должен признать, что опыта расследования таких серьезных дел у меня пока нет.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Это видно. Неужели за месяц поисков вы не смогли не обнаружить вообще никаких следов Карла?", 230, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Все приходит с опытом. У тебя есть шанс проявить себя в этом деле.", 240, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(220, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Нет, к сожалению мы ничего не нашли. Карл как сквозь землю провалился.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 250, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(230, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Для меня важность этого дела не в том, чтобы проявить себя. На кону стоит жизнь ребенка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 250, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(240, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Джонсон, при всем уважении, мне кажется у тебя не так много опыта для расследования такого сложного дела. Я понимаю, почему вам потребовалась помощь из столицы.", 260, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Что же, Джонсон, я надеюсь мы сработаемся. Не смотря на молодость, я вижу в тебе стержень настоящего детектива.", 270, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(250, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Это только ваше мнение. Я работал и буду работать, пока Карл не найдется.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 280, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(260, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Приятно слышать. Мы немало наслышаны о вас. Особенно о том деле с ограблением центрального музея Йорк-Сити. Великолепная работа.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 280, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(270, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Я так понимаю у нас нет пока никаких зацепок, кроме этого рисунка?
- Джонсон: Увы, нет. В лесу мы не обнаружили никаких следов Карла. Но этот рисунок... Мы ломаем голову, чтобы могло значить это имя - Бен.
- Джимми: На сколько тщательно был исследованы близлежащие лесные массивы?
- Джонсон: Поиском занимались спасатели и полицейские из Вест-Сити. Привлекались вертолеты. После того, как Вигсы получили этот рисунок, версия того, что Карл мог просто заблудиться стала не очень актуальной. Скорее всего нужно искать не в лесу.
- Джимми: Хорошо, Джонсон, увидимся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 210, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(27, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(280, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Рабочее место Анны находилось в коридоре, рядом со входом в участок.
Анна сидела за столом и внимательно изучала какие-то документы. Ее волосы были русого цвета, а лицо слегка полноватым. Взгляд был приветливый и открытый.
- Джимми: Привет, Анна. Меня зовут Джимми Хаксли, и я намерен внести свою скромную часть в деле поиска Карла Вигса. За этим меня сюда и направили. Я хотел бы получить от тебя список всех близких к Карлу людей, если ты не против.
- Анна: Добрый день! Очень приятно познакомиться, мистер Хаксли! Мы ждем вас уже несколько дней. Как вам наш город?
- Джимми: Мне нравится. Весьма живописное и тихое место. После нашего Йорк-Сити самое то.
- Анна: Да, все так говорят, когда приезжают к нам из мегаполисов. Где вы поселились, наверняка в отеле Вестхаус?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("А ты всегда такая любопытная?", 300, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Да, как мне сказали, больше тут альтернатив нет. Но я вполне доволен, скромный, но уютный номер за небольшие деньги.", 310, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(30, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я пока еще не заселился в гостиницу. Но мне порекомендовали именно Вестхаус.", 310, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(30, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(290, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Нет конечно. Просто у нас не так часто бывают столь известные личности. Извините, если я вас немного напрягла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(300, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Это очень хорошо! У меня такое ощущение, что вы обязательно найдете Карла! О вас и вашем опыте у нас ходило много разговоров.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(310, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Анна, а что ты сама думаешь о пропаже Карла?
- Анна: Мне почему-то кажется, что с Карлом все в порядке и он скоро вернется. У него сейчас трудный и переломный возраст. Много недопонимания с родственниками. Такое случается. Вот он и решил уйти из дома. Конечно, очень тревожит мысли о том, где он может находится все это время.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Карла нет уже месяц. Как ты можешь столь уверенно говорить, что с ним все в порядке?", 330, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Вполне вероятно, что именно так оно и было. Я сам лично сталкивался с такими случаями. Да и что уж тут, сам убегал из дома когда мне было пятнадцать лет.", 340, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(320, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Конечно, я не могу быть в этом уверенной. Просто говорю, что думаю. Иногда подростки убегают из дома.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 350, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(330, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Ого, да вы бунтарь! А вот теперь жизнь сложилась так, что вам самим приходится искать таких трудных подростков. Понимание психологии подобных детей вам поможет в поисках Карла. Лично мое мнение.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 350, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(340, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Анна, было приятно поболтать. Но нужно начинать работать. День подходит к концу. Ты обещала дать мне информацию о окружении Карла.  
- Анна: Да, само-собой. Держите. И удачи вам!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 210, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(28, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(29, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(350, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми посетил полицейский участок Лонлифарма и познакомился с людьми, с которыми ему предстоит работать над этим нелегким делом. Не смотря на то, что многое указывало на то, что Карл просто решил уйти из дома, тем самым заставив родителей понервничать и осознать свою неправоту, на душе у Джимми было тревожно. 
Близился вечер. Джимми решил отправиться в свой номер и спокойно изучить все детали дела.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 370, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(360, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми посетил полицейский участок Лонлифарма и познакомился с людьми, с которыми ему предстоит работать над этим нелегким делом. Не смотря на то, что многое указывало на то, что Карл просто решил уйти из дома, тем самым заставив родителей понервничать и осознать свою неправоту, на душе у Джимми было тревожно. Близился вечер. Джимми решил отправиться в отель и снять номер.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 20, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(365, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Не смотря на то, что под вечер на улице сильно похолодало, в номере Джимми было тепло. Удобно устроившись на широком диване, Джимми стал вдумчиво изучать все детали дела. Больше всего его интересовали люди, с которыми жил и общался Карл. Именно в его отношениях с этими людьми пряталась загадка его исчезновения - так рассуждал Джимми.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 380, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(370, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Досье на Билла Вигса - отца Карла.", 390, 0));
        locationEntity.passageList.Add(new PassageEntity("Досье на Лиану Вигс - маму Карла.", 400, 0));
        locationEntity.passageList.Add(new PassageEntity("Досье на Руфуса Вигса - деда Карла.", 410, 0));
        locationEntity.passageList.Add(new PassageEntity("Досье на Нейта Уисли - лучшего друга Карла.", 420, 0));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение досье.", 430, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(380, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Билл Вигс - 45 лет. Работает на лесодобывающем заводе уже двадцать пять лет. В день исчезновения Карла был на работе. Сильно переживает. По некоторым данным, после исчезновения Карла у Билла начались проблемы с алкоголем. С Карлом они никогда сильно не ругались. Тем не менее в их отношения была некая отдаленность, они не были очень близки. У Билла не находилось много времени на Карла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 380, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(390, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Лиана Вигс, 40 лет. Ранее работала библиотекарем, но уже пять лет как не работает. В день исчезновения Карла была дома, по ее собственным словам. Любила Карла, всегда уделяла ему много внимания и поддерживала. Не видит никаких причин для побега Карла. Считает, что это похищение. Уверена, что рисунок, который они обнаружили в почтовом ящике нарисован Карлом. Старается держаться и сохраняет хладнокровие.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 380, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(400, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Ральф Вигс, 75 лет. Ранее служил в армии, во флоте. Давно на пенсии. В последнее время стало подводить здоровье, в настоящее время проживает в доме престарелых. Сильно взволнован новостью о пропаже Карла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 380, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(410, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Нейт Уисли - 13 лет. Лучший друг Карла с семи лет. Учатся в одном классе, вместе занимаются спортивным ориентированием. В день пропажи Карла был дома.  Немногословный, обладает непростым характером. Тем не менее, по утверждения близких, с Карлом они никогда не ссорились. На контакт с полицией не идет. Имел хорошие отношения со всей семьей Вигсов. По утверждению Лианы Вигс, они отлично ладили с Биллом. Был частым гостем в семье Вигсов.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 380, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(420, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми изучил весь доступный материал. Было уже около одиннадцати часов ночи. Время пробежало незаметно. Джимми любил ложиться спать поздно и часто просиживал до двух-трех часов ночи. Но сегодня на него накатилась сильная усталость. Он подумал о том, что уже нет смысла что-то делать, а завтра нужно обязательно навестить семью Вигсов и поговорить с Нейтом. Все-таки это были самые близкие к Карлу люди, вдруг они что-то знают, но по каким-то причинам скрывают.";
        locationEntity.passageList.Add(new PassageEntity("Почитать местную газету.", 440, 0));
        locationEntity.passageList.Add(new PassageEntity("Лечь спать.", 450, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(430, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Большинство новостей о жизни города Лонлифарма были не слишком интересные. Многие статьи были о деятельности лесодобывающей компании. Директор завода - Генри Мартон - ожидает на днях крупную делегацию из столицы - ожидаются серьезные инвестиции.
Небольшая колонка была посвящена делу о пропаже Карла. В ней писалось о том, что местная полиция ждет приезда известного сыщика из Йорк-Сити для помощи в расследовании. Между строчками проскальзывало недвусмысленное недовольство действиями местной полиции. Утверждалось, что они не делают ровным счетом ничего.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 450, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(440, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми хотелось еще раз обдумать все детали пропажи Карла и спланировать план действий на ближайшие дни. Что-то его в этом деле сильно тревожило и не давало покоя. Но усталость от довольно долгой дороги взяла свое. Обычно Джимми требовался минимум час, чтобы уснуть, но через пять минут от уже спал крепким сном без каких-либо сновидений.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 460, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(450, locationEntity);
        #endregion
        #region Day 2
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Вторник, 28 сентября.
Тени прошлого.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 470, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(460, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"После крепкого сна Джимми ощутил в себе прилив сил и желание как можно быстрее приступить к работе. Немного размявшись, он быстро собрался и спустился на первый этаж.
За сегодняшний день предстоит много всего сделать. Однако, было бы неплохо для начала полноценно перекусить. Джимми решил поговорить с Руфусом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 480, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(470, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Доброе утро Руфус! Как там у нас сегодня погода?
- Руфус: Доброе утро, мистер Хаксли! Погода практически как вчера, довольно прохладно. Одевайтесь хорошо.
Как вас спалось?
- Джимми: Спал как младенец, давно не получалось так хорошо выспаться. Скажите, Руфус, есть ли тут неподалеку какое-нибудь нормальное кафе с приемлемыми ценами?
- Руфус: - О, да! Проедете вниз от отеля по Зеленой улице буквально метров сто и на пересечении с Централ Стрит будет небольшое кафе - часто хожу туда перекусить. Готовят хорошо, по домашнему. Кафе называется ""Розали"". Передавайте от меня привет Лизе - официантке.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Руфус, боюсь, что у меня на данный момент несколько другие заботы, чем помнить о таких вещах.", 490, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Конечно, Руфус, не вопрос.", 500, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(480, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Ну хорошо, я просто пошутил.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(490, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Спасибо! Лиза - отличная девушка и хороший собеседник.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(500, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Руфус, что ты вообще думаешь о семье Вигсов? Я везде слышу, что все у них было в полном порядке. Но не исключается, что Карл просто убежал из дома. А это уже несколько не вяжется с образом примерной семьи. Могли быть у них какие-то разногласия?
- Руфус: Я не на столько близко знаком с семьей Вигсов, хотя мы периодически общаемся с Биллом.  Про проблемы в семье он никогда не говорил. Хотя одну странность я могу вспомнить. Мы давно дружим с Доном Уисли. А сын Дона - Нейт, насколько мне известно, хорошо дружил с Карлом. Так вот, мы однажды сидели с Доном в кафе, пили пиво. Тогда он обронил фразу о том, что ему кажется, что Нейт любит больше Билла, чем его и все время пропадает у Вигсов. Я тогда не стал углубляться с Доном в эту тему. Все-таки это личное.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Это уже что-то. Но мне кажется раз вы общались на такие темы, то могли бы мне рассказать побольше.", 520, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это весьма интересно. Спасибо за информацию Руфус.", 530, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(510, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Нет, это не так. Да, мы периодически общаемся с Доном, но я не лезу в личные семейные дела. Мне не до этого.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 540, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(520, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Рад помочь. Если я вспомню еще что-то, то обязательно сообщу об этом вам.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 540, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(530, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми предчувствовал, что для того, чтобы узнать, что случилось с Карлом, ему предстоит покопаться в делах семейных и отношениях между людьми. Без этого не обходилось практически ни одно дело в карьере Джимми Хаксли.
Тем временем организм Джимми начал негодовать и Джимми решил больше не тянуть и отправиться перекусить в кафе.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 550, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(540, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Руфус не обманул, кафе находилось действительно рядом с отелем и цены были вполне нормальные. Людей в кафе практически не было и Джимми уселся на свободное место у окна.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 555, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(550, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К нему подошла молодая светловолосая официантка приятной наружности. Джимми сразу отметил ее добрый приветливый взгляд.
- Лиза: Добрый день, мистер! Вижу новые лица в нашем городке! Дайте угадаю - вы полицейский! Как вам в нашем городе? Кстати - меня зовут Лиза.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Добрый день. Честно говоря, я бы просто хотел поесть. Можно глянуть меню?", 560, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Привет Лиза. Ты меня расколола за несколько секунд, у тебя настоящий детективный талант. Мне как-раз нужен помощник.", 570, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(555, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Как скажете, сэр. Вот меню.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 580, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(560, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Лиза: Спасибо! Но боюсь что вы меня немного перехвалили - о вашем приезде я прочитала в газете. Учитывая, что наше кафе находится рядом с отелем, я была уверена, что вы к нам загляните. Но я вижу, что вы очень голодны, держите меню.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 580, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(570, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Так, посмотрим, что у вас тут имеется. Мне, пожалуйста, яичницу с беконом, имбирные печенья и крепкий кофе. Лиза, ты не подскажешь - где тут поблизости можно заправить машину?
- Лиза: Езжайте дальше по Зеленой улице и метров через пятьсот будет заправка, рядом с универмагом Харли. Вы не проедете мимо. Кстати, наверное сегодня там смена у Даниэля - моего знакомого. Он работает заправщиком. Забавный парень. Он знает практически всех в нашем небольшом городе, может быть вам будет интересно с ним поговорить. Ваш заказ будет готов через десять минут.
- Джимми: Отлично. Спасибо за информацию.
- Лиза: Обращайтесь по любым вопросам, всегда буду рада помочь.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Пока Лиза. Надеюсь, заказ принесут без задержек.", 600, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Приятно было познакомиться. Кстати - тебе привет от Руфуса - заведующего отелем.", 590, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(580, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Спасибо! Да, Руфус часто обедает у нас. Мы с ним знакомы уже лет десять.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 600, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(590, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Быстро и с аппетитом съев всю заказанную еду, Джимми стал обдумывать план действий на день. В первую очередь нужно поговорить с родителями Карла. Возможно, стоит увидеться с близким другом Карла - как его зовут, Нейт кажется?";
        locationEntity.passageList.Add(new PassageEntity("Отправиться к родителям Карла.", 610, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(600, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к дому семьи Вигсов. Улица, где жили Вигсы находилась на окраине города, но не смотря на это, Джимми доехал до них за пять минут. Тихая и спокойная улица, состоявшая из небольших частных домов. Людей вокруг практически не было, лишь пожилая пара прогуливалась с собакой.
Дом Вигсов был покрашен в белый цвет и выглядел весьма аккуратно. Небольшой садовый участок с ровно остриженным газоном был ухожен и содержался в полном порядке. Джимми позвонил в дверь.
Ему открыла женщина с темными волосами и короткой стрижкой. Усталый вид говорил о всех тех неприятных моментах, которые ей пришлось пережить за последнее время.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 612, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(610, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день. Меня зовут Джимми Хаксли, я детектив из Йорк-Сити. Моя задача помочь местной полиции в поисках вашего сына. Я не сильно вас отвлекаю?
- Лиана: Добрый день, мистер Хаксли. Нет конечно, не отвлекаете. Что именно вам нужно?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я бы хотел поговорить с вами, миссис Вигс.", 615, 0));
        locationEntity.passageList.Add(new PassageEntity("Я бы хотел поговорить с Биллом Вигсом.", 730, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(612, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Ну что-же, давайте пройдем в дом. Что вы хотите узнать?
- Джимми: Миссис Вигс, я вполне могу понять, что вы испытываете в эти непростые дни. Но я хочу, чтобы вы поняли, что только максимальное содействие с вашей стороны дает нам шансы. Я хочу понять, что случилось с Карлом. Нами рассматривается несколько версий. И основная - Карл по каким-то причинам решил убежать из дома. Как вы к этому относитесь? Может эта версия соответствовать действительности?
- Лиана: Я не могу в это поверить. Я не буду говорить о том, что все у нас всегда было идеально и безупречно, но Карл не из тех детей, что стали бы совершать столь глупые поступки. С ним что-то случилось, а полиция бездействует.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я понимаю вас. Я приехал сюда, чтобы узнать, что случилось с Карлом и вместе мы это сделаем.", 630, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это не правда. Полиция делает все, что можно. Но вы сами должны понимать всю сложность ситуации.", 640, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(615, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Миссис Вигс, у вас найдется немного времени на меня?
- Лиана: Да, разумеется
- Джимми: Миссис Вигс, я вполне могу понять, что вы испытывает в эти дни. Но я хочу, чтобы вы поняли, что только максимальное содействие с вашей стороны дает нам шансы. Я хочу понять, что случилось с Карлом. Нами рассматривается несколько версий. И основная - Карл по каким-то причинам решил убежать из дома. Как вы к этому относитесь? Может эта версия соответствовать действительности?
- Лиана: Я не могу в это поверить. Я не буду говорить о том, что все у нас всегда было идеально и безупречно, но Карл не из тех детей, что стали бы совершать столь глупые поступки. С ним что-то случилось, а полиция бездействует.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я понимаю вас. Я приехал сюда, чтобы узнать, что случилось с Карлом и вместе мы это сделаем.", 630, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это не правда. Полиция делает все, что можно. Но вы сами должны понимать всю сложность ситуации.", 640, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(620, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Я понимаю, мистер Хаксли. Просто мне тяжело говорить об этом. Тем не менее, я постараюсь ответить на ваши вопросы.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 650, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(630, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Если бы это было так, мы бы уже знали о том, что случилось с Карлом. Но за весь месяц поисков не достигнуто никаких результатов, чем занимается полиция не понятно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 650, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(640, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: И все-таки, возможно были какие-то причины для побега из дома? Случались ли в вашей семье какие-либо ссоры или конфликты? Может быть вы многое запрещали Карлу?
- Лиана: Разве бывают семьи, в которых никогда не ссорятся? Конечно, у нас иногда случались небольшие конфликты.
- Джимми: С чем они были связаны?
- Лиана: Иногда случались конфликты из-за учебы. Дело в том, что он любил заниматься спортивным ориентированием и отдавал предпочтение спорту, а не школе. Часто не делал уроки из-за тренировок. Я всегда ругала его в таких случаях. Я хочу что-бы он успешно закончил школу и затем поступил в университет в столице.
- Джимми: Вы говорите, что вы ругали Карла. А Билл? Как он реагировал?
- Лиана: Более спокойно. Видимо, ему это было не так важно. К сожалению, я не могу сказать, что Билл был очень близок с сыном.
- Джимми: Это правда, что Билл более тепло относился к Нейту, чем к Карлу?
- Лиана: Я не понимаю, с чего вы это взяли... Да, Нейт был частым гостем в нашем доме. Билл к нему относится хорошо, они общаются на разные темы. Но вопрос, который вы задали является очень странным для меня.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Лиана, мне кажется, что у нас имеется небольшое противоречие. Вы уверено заявляете, что Карл сам не мог сбежать из дома. Но, как мне видится - имеются очевидные проблемы в отношениях с отцом. Откуда у вас такая уверенность?", 660, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(41, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(42, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Да, вопрос и правда странный, я извиняюсь. Тем не менее, я вынужден задавать непростые вопросы, так-как хочу найти вашего сына.", 670, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(41, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(42, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(650, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Потому что из-за этого не сбегают из дома. Неужели вы сами этого не понимаете?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(660, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Конечно, я понимаю. Сделайте все, что в ваших силах, я прошу вас.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(670, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Я так понимаю, в день исчезновения Карла вы были дома вдвоем? Было ли что-то странное или необычное в поведении Карла?
- Лиана: Да, это так. Нет, ничего необычного не было. Он делал уроки, затем ушел погулять. И не вернулся.
- Джимми: Этот рисунок... Мне сказали, что вы уверяете, что он нарисован именно Карлом.
- Лиана: Да, я уверена в этом. Я знаю, как рисует мой сын. Я понятия не имею, что все это значит. Я боюсь, что Карла похитили.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Получается, что последним человеком, который видел Карла были вы. Вы уверены, что он ушел просто на прогулку? Возможно, он что-то говорил вам?", 690, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Спасибо, Лиана. Пока у нас мало зацепок. Но я продолжу работу и уверен, что скоро мы приблизимся к ответу.", 700, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(680, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Я уже ответила. Нет, он мне ничего не говорил. Мистер Хаксли, я правда не знаю, что еще сказать. Я все уже это рассказывала полиции.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 710, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(690, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Мистер Хаксли, прошу вас - найдите моего сына!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 710, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(700, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо за разговор, Лиана. Я надеюсь, что мы найдем Карла. ";
        locationEntity.passageList.Add(new PassageEntity("Далее", 720, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(43, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(45, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(710, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дом семьи Вигсов.";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Лианой.", 620, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(43, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Биллом.", 740, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(44, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Осмотреть комнату Карла.", 820, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(46, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отправиться на разговор с семьей Нейта.", 900, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(45, 3, 3, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(47, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поехать к Ральфу Вигсу.", 1100, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(45, 3, 3, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(720, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Хорошо. Он сейчас в гостиной.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 740, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(730, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми прошел в гостиницу. В кресле сидел и читал газету мужчина крупного телосложения с небольшой бородой.
- Джимми: Добрый день, мистер Вигс. Меня зовут Джимм Хаксли, я детектив полиции Йорк-Сити. Я занимаюсь поисками вашего сына. Можем мы поговорить?
- Билл: Здравствуйте, мистер Вигс. Да, конечно, давайте поговорим.
- Джимми: Мистер Вигс, в первую очередь меня интересует - был ли у Карла повод, для того чтобы убежать из дома. У него были конфликты с вами или Лианой?
- Билл: Нет, у нас никогда не было конфликтов. Карл не мог сам уйти из дома.
- Джимми: Но все-таки, возможно вы замечали в его поведении в последнее время что-то необычное?
- Билл: Нет, не замечал.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Для того, чтобы у нас появились хотя бы какие-то зацепки мне нужна информация. У меня создается впечатление, что вы не хотите помочь следствию.", 750, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У вас пропал сын, и я могу понять ваши чувства. Но для того, чтобы у нас появились какие-то шансы, мне нужна ваша помощь.", 750, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(740, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Хорошо. Но что именно вы хотите от меня услышать?
- Джимми: Билл, вы знаете своего сына гораздо лучше меня. Что вы сами думаете о его исчезновении? Что с ним могло случиться?
- Билл: Я правда не знаю. Возможно, он заблудился в лесу. Я не понимаю почему полиция его не нашла. Может быть, что сейчас уже поздно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 760, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(41, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 780, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(41, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(42, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(750, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Однако Карл занимался спортивным ориентированием и его тренировки проходили именно в этом лесу. Вы думаете он мог заблудиться?
- Билл: Я не знаю... Все таки Карл еще совсем ребенок, ему только двенадцать лет.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 770, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(42, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 780, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(42, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(760, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вы много времени проводили с Карлом? 
- Билл: Я много работаю. Но вечером и в выходные стараюсь уделять время Карлу.
- Джимми: Мистер Вигс, Лиана утверждает обратное. Она сказала, что вы не были близки с Карлом. 
- Билл: Понимаете, эта работа... Занимает очень много времени. Но я не могу с этим согласиться. Это ее мнение. 
- Джимми: Как у вас складываются отношения с Лианой? Вы ссорились в присутствии Карла?
- Билл: У нас всегда были нормальные отношения. Бывало, что и ссорились, но не чаще чем другие. Правда после исчезновения Карла мы стали редко разговаривать.";
        locationEntity.passageList.Add(new PassageEntity("Джимми: Мне кажется, что если бы вы больше время уделяли семье, Карл бы сейчас находился здесь.", 790, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Джимми: Постарайтесь успокоиться мистер Вигс. Мы делаем все, чтобы найти Карла.", 800, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(770, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вы много времени проводили с Карлом? 
- Билл: Я много работаю. Но вечером и в выходные стараюсь уделять время Карлу.
- Джимми: Как у вас складываются отношения с Лианой? Вы ссорились в присутствии Карла?
- Билл: У нас всегда были нормальные отношения. Бывало, что и ссорились, но не чаще чем другие. Правда после исчезновения Карла мы стали редко разговаривать.";
        locationEntity.passageList.Add(new PassageEntity("Джимми: Мне кажется, что если бы вы больше время уделяли семье, Карл бы сейчас находился здесь.", 790, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Джимми: Постарайтесь успокоиться мистер Вигс. Мы делаем все, чтобы найти Карла.", 800, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(780, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Я понимаю, что вы хотите упрекнуть меня в том, что Карл исчез. Но дело в том, что я тут не причем. Полиция должна разобраться, что случилось к Карлом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 810, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(790, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Спасибо, мистер Хаксли. Я очень надеюсь, что у вас получиться узнать, что случилось с Карлом. Мы на это очень надеемся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 810, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(800, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Что вы можете рассказать о друзьях Карла?
- Билл: Его лучшим и единственным другом был Нейт Уисли. Семья Уисли живет через два дома от нас. Они часто проводили время вместе.
- Джимми: У меня есть информация о том, что Нейт очень хорошо относится именно к вам. Возможно даже лучше, чем к своему собственному отцу. Что вы можете сказать об этом?
- Билл: Интересно, кто вам такое мог сказать? Я не знаю, как Нейт относится ко мне. Да, мы иногда играли втроем - я, Карл и Нейт. Ездили летом отдыхать вместе. Нейт отличный парень. Возможно у него проблемы в отношениях со своим отцом. Я не вникал слишком сильно в это.
- Джимми: Как вы полагаете, в связи с этим могла ли существовать некоторая ревность со стороны Карла по отношению к Нейту?
- Билл: Нет, это глупые предположения. Совершенно исключено.
- Джимми: С кем из родственников еще общался Карл?
- Билл: Разве что с моим отцом - Ральфом Вигсом. Он раньше жил вместе с нами, но в последнее время он решил, что ему легче жить в доме престарелых. Стало подводить здоровье. Ему уже семьдесят пять лет. Но иногда мы забираем его и он живет у нас. А иногда он приезжает сам, ходит он пока достаточно уверенно.
- Джимми: Спасибо за уделенное время. Пока у меня нет больше вопросов. Но не исключено, что они скоро появятся. Всего хорошего.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 720, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(44, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(45, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(54, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(810, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Комната Карла выглядела достаточно обычно для подростка двенадцати лет. В комнате был идеальный порядок, все лежало на своих местах. На письменном столе стоял небольшой позолоченный кубок. На нем было написано ""За 2-ое место в районных соревнованиях по спортивному ориентированию"".
Видимо, Карл увлекался ориентированием достаточно серьезно. На стене висела карта леса со схемой маршрутов для соревнований.
Все это наводило на мысль, что Карл весьма неплохо знал местный лес. Как он мог потеряться?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 720, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(45, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(46, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.CarlRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Lost;
        locationDictionary.Add(820, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дом семьи Уисли располагался практически по соседству - через три минуты Джимми уже стучался в дверь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 905, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(900, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дверь открыл высокий мужчина с густыми черными волосами. Вид у него был несколько потрепанный, как-будто он только проснулся.
- Дон: Чем могу быть полезен?
- Джимми: Добрый день. Меня зовут Джимми Хаксли, я детектив полиции. Я занимаюсь поиском Карла Вигса. Вы отец Нейта Уисли?
- Дон: Да, а что такое?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я хотел бы поговорить с вами.", 910, 0));
        locationEntity.passageList.Add(new PassageEntity("Я бы хотел поговорить с Нейтом.", 980, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(905, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Хорошо, проходите. Меня зовут Дон.
- Джимми: Спасибо, Дон. Вы знали лично Карла Вигса, пропавшего подростка?
- Дон: Ну, видел несколько раз. В основном Карл и Нейт либо гуляли, либо были дома у Вигсов.
- Джимми: А почему они чаще проводили время у Вигсов, чем у вас?
- Дон: Понятия не имею. Им так хотелось.
- Джимми: А что вы думаете по поводу пропажи Карла? Нет никаких соображений куда он мог деться?
- Дон: Откуда мне знать? Бывает, что дети убегают из дома.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Карл - лучший друг вашего сына, они дружат несколько лет. Похоже, что вас не сильно волнует его исчезновение.", 920, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Раз вы видели Карла довольно редко, то вопросов у меня пока что к вам больше нет.", 930, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(910, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Я не думаю, что с ним случилось что-то плохое. Скоро ему самому все это надоест и он вернется домой. А у меня и своих забот хватает.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 940, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(920, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Вот и хорошо. У меня много дел, особенно некогда тут с вами разговаривать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 940, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(930, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: А чем вы занимаетесь? И где миссис Уисли?
- Дон: Я не уверен, что у меня есть время на эти вопросы. Все таки у нас не дружеская беседа.
- Джимми: Мы расследуем исчезновение двенадцатилетнего подростка. Ваш сын был его ближайшим другом. Вам придется отвечать на мои вопросы.
- Дон: Только быстро. Я занимаюсь ремонтом сантехники. А что касается моей жены - мы уже несколько лет разведены.
- Джимми: Получается, что вы воспитываете Нейта?
- Дон: Да, именно так.
- Джимми: Вы ладите с Нейтом?
- Дон: Конечно.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("У меня информация немного другая. Вы как-то говорили, что считаете, что Нейт больше любит Билла, отца Карла, чем вас.", 950, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это хорошо. Не легко одному воспитывать ребенка.", 960, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(940, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Ха, глупости какие. Без понятия откуда вы взяли эту чушь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 970, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(950, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Да, это так. Весь день вкалываешь на чертовой работе, да и с Нейтом постоянно какие-то проблемы. То с кем-то подерется, то прогуляет школу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 970, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(49, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(53, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Далее", 975, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(49, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(53, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(960, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Я бы хотел немного переговорить с Нейтом. Он дома?
- Дон: Да, он в своей комнате. Я вас провожу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 990, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(48, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(970, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ладно, Дон. Возможно я еще зайду к вам, если в этом появится необходимость.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1060, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(49, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(50, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 1065, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(49, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(50, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(975, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Только недолго. Ему нужно делать уроки. Он в своей комнате на втором этаже, я вас провожу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 990, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(980, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми постучался в комнату Нейта.
Нейт сидел за компьютером. У него были темные короткие волосы и бледное лицо. Взгляд его не отрывался от монитора.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 995, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(990, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Привет, Нейт. Я расследую пропажу Карла. Я задам тебе пару вопросов?
- Нейт: Ну, задавайте.
- Джимми: Вы виделись с Карлом в день его исчезновения?
- Нейт: Нет.
- Джимми: Карл ничего тебе не сообщал о своих планах на этот день?
- Нейт: Нет. Мы не общались несколько дней.
- Джимми: По какой причине?
- Нейт: Какая разница? Это наше дело.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Нейт, пропал твой лучший друг. Тебя вобще это не волнует?", 1000, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Ты можешь помочь нам в расследовании. Я так понимаю, Карл кроме тебя ни с кем близко не общался?", 1010, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(995, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Волнует конечно. Я не понимаю, что вам от меня надо. ";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1020, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1000, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Да, мы были лучшие друзья. Но я не знаю, чем я вам могу помочь. Он мне ничего не говорил, куда он собирался идти.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1020, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1010, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Нейт, у Карла были проблемы в школе? Конфликты с одноклассниками?
- Нейт: Ну, иногда бывали. Ничего особенного. Как у всех.
- Джимми: В последнее время он ссорился с кем-нибудь из одноклассников?
- Нейт: Вроде бы нет.
- Джимми: Вы же учились в одном классе? Как зовут вашу классную руководительницу?
- Нейт: Да. Классную руководительницу зовут Милана Раймонд.
- Джимми: Как Карл учился, были у него проблемы с учебой?
- Нейт: Учился вроде бы средне, как я. Потому что мы много тренируемся.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Нейт, для лучшего друга ты знаешь о Карле как-то маловато. Ты что-то скрываешь?", 1030, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Ясно. Вы отдаете предпочтение спорту. Не такой уж плохой выбор.", 1040, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1020, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Ничего я не скрываю. Это глупо. Я все это рассказывал полицейским.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1050, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1030, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Да, мы с Карлом занимали призовые места на соревнованиях по ориентированию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1050, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1040, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Нейт, ты часто бывал в гостях у Карла?
- Нейт: Ну да. Частенько.
- Джимми: Как к тебе относились его родители?
- Нейт: Да, хорошо. У него веселый папа. Часто втроем играли в видеоигры.
- Джимми: А что ты сможешь сказать о своем отце? Как он к тебе относится?
- Нейт: Да не знаю, что сказать. Папа в основном работает.
- Джимми: Чем твой папа занимается после работы?
- Нейт: Смотрит телевизор. Пьет пиво.
- Джимми: А ты не знаешь почему твои родители развелись?
- Нейт: Нет. Я был тогда маленький. Папа мне об этом не рассказывает.
- Джимми: Спасибо Нейт. Пока вопросов нет. Но я еще зайду.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1060, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(48, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(50, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(47, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(49, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(55, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(56, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Далее", 1065, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(48, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(50, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(47, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(49, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(55, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(56, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Доном.", 1070, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(48, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(49, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1050, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми вышел из дома Уисли. На улице немного потеплело. Джимми глубоко вздохнул. Знакомство со второй семьей за сегодня, в обоих явно что-то пошло не так. Когда и почему это произошло? Неужели Джимми придется разбираться с этим? Предчувствие Джимми его как обычно не подвело - похоже он в Лонлифарме надолго. 
Возможно, пожилой Ральф Вигс сможет что-то рассказать Джимми о том, о чем умолчали родители Карла.";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Ральфом.", 1100, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(52, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1060, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми вышел из дома Уисли. На улице немного потеплело. Джимми глубоко вздохнул. Знакомство со второй семьей за сегодня, в обоих явно что-то пошло не так. Когда и почему это произошло? Неужели Джимми придется разбираться с этим? Предчувствие Джимми его как обычно не подвело - похоже он в Лонлифарме надолго.";
        locationEntity.passageList.Add(new PassageEntity("Поехать на заправку.", 1200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(51, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(52, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Вернуться в отель.", 1300, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(52, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1065, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Нейт ушел в свою комнату. На диване в гостиной сидел Дон и смотрел в окно.
- Джимми: Дон, уделите мне 10 минут?
- Дон: Ладно, но не больше.
- Джимми: Спасибо Дон. Вы знали лично Карла Вигса, пропавшего подростка?
- Дон: Ну, видел несколько раз. В основном Карл и Нейт либо гуляли, либо были дома у Вигсов.
- Джимми: А почему они чаще проводили время у Вигсов, чем у вас?
- Дон: Понятия не имею. Им так хотелось.
- Джимми: А что вы думаете по поводу пропажи Карла? Нет никаких соображений куда он мог деться?
- Дон: Откуда мне знать? Бывает, что дети убегают из дома.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Карл - лучший друг вашего сына, они дружат несколько лет. Похоже, что вас не сильно волнует его исчезновение.", 920, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Раз вы видели Карла довольно редко, то вопросов у меня пока что к вам больше нет.", 930, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1070, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дом престарелых Лонлифарма находился на окраине города, на некотором отдалении от жилого района. Небольшое двухэтажное здание из дерева, окрашенное в зеленый цвет, было со всех сторон окружено лесным массивом. Весьма живописное место. Джимми ненароком подумал о том, что сам был бы не против провести старость в подобном месте.
На пропускном пункте Джимми показал удостоверение детектива и сказал, что хочет поговорить с Ральфом Вигсом. Без лишних вопросов его пропустили.
Несколько пожилых людей прогуливались на свежем воздухе, что-то бурно обсуждая. Джимми вошел в здание и после непродолжительных поисков постучал в комнату Ральфа.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1105, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Ральф стоял у шкафа и, кажется, куда-то собирался. Для своих лет он выглядел неплохо. Волосы были полностью седыми, лицо покрыто глубокими морщинами, но тело Ральфа было достаточно подтянутым и подвижным.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1107, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1105, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Войдите!
- Джимми: Добрый день, Ральф. Мое имя - Джимми Хаксли. Я детектив полиции и занимаюсь поисками Карла, вашего внука.
- Ральф: Вот как.
- Джимми: Я сегодня общался с Биллом и Лианой. Мне показалось, что в их семье есть некие проблемы. Я хочу понять, возможна ли версия, что Карл сам убежал из дома. Ральф, я бы хотел услышать от вас пояснения по этому вопросу, что вы думаете?
- Ральф: Я думаю, что и Лиана и Билл очень любят Карла. Да, мой сын Билл во многих ситуациях бывает слабохарактерным. Возможно, он так и не сумел найти общий язык с Карлом.
- Джимми: Я вам не помешал? Вы собираетесь куда-то уходить?
- Ральф: Вообще-то... По правде говоря я собираюсь в полицию.
- Джимми: А что случилось?
- Ральф: Очень тревожные новости. Сегодня ко мне заходил мой старый приятель Альфред. Он уверяет, что видел в Лонлифарме... Стефана Кнайта. Причем это было около месяца назад... Как-раз тогда исчез Карл.
- Джимми: Что? Кто это?
- Ральф: Видно, что вы недавно в нашем городе. Стефан - убийца. Он несколько лет в бегах, о судьбе его ничего не было известно. Неужели он вновь вернулся в Лонлифарм? 
- Джимми: Но что именно он сделал?
- Ральф: Стефан был местным хулиганом. Несколько раз отсиживал небольшие сроки за воровство и драки. Говорят, что однажды он подсел на наркотики. Капитан полиции Стэнли Купер со своим напарником приехали к нему домой для разговора. Его не собирались задерживать, просто провести беседу. Видимо, Стефан находился в неадекватном состоянии. У него оказался пистолет, он убил Стэнли и молодого сержанта. Затем он сбежал из города. Несмотря на все поиски, о нем так ничего не известно, он как будто испарился. И теперь такие вести...
- Джимми: Вот это история. Мне об этом никто ничего не рассказывал.
- Ральф: В Лонлифарме стараются как можно меньше говорить о Стефане. Тот случай потряс весь город. У Стэнли есть сын - Джонсон. Он решил продолжить дело отца и сейчас работает в полиции Лонлифарма.
- Джимми: С ним я успел познакомиться. Не знал, что у него такая непростая судьба. А что с этим вашим другом, Альфредом? Если он видел Стефана месяц назад, то почему он сказал об этом вам только сегодня?
- Ральф: Вы знаете - старость не радость. Он сам не смог это объяснить. Говорит, что сразу просто не узнал Стефана. Он ехал в машине на пассажирском сиденье. И вот только сегодня утром Альфреда осенило - да это же Стефан Кнайт!
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Ну, такое иногда случается. Иногда озарение настигает в самый неожиданный момент.", 1110, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(10, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(57, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("При всем уважении, это звучит крайне неубедительно. Может, это не Альфред, а вы решили поделиться этой информацией только сейчас?", 1120, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(40, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(10, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(57, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1107, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Да. Еще прошу учитывать наш возраст, я иногда свое имя забываю.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Ни в коем случае. Вы считаете, что я стал это утаивать целый месяц? Нет, я еще не вышел полностью из ума.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1120, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Обязательно сообщите об этом шерифу Стерлингу. Если информация подтвердиться, то дело обретет совсем новый поворот. Также, если вам не сложно, скажите где живет ваш друг Альфред.
- Ральф: Да, я уже иду в полицию. Альфред живет на Гастингс Стрит, дом 3.
- Джимми: Спасибо! Я вас еще навещу, если не возражаете.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1140, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(50, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(52, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Разговор с пожилым Ральфом принес вести совсем неожиданные и тревожные. Если информация подтвердиться, то дело может оказаться куда-более серьезным, чем можно было изначально подумать. Может быть в пропаже Карла замешан Стефан?";
        locationEntity.passageList.Add(new PassageEntity("Поехать к Нейту Уисли.", 900, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(47, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поехать на заправку.", 1200, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(1140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к свободной колонке. К нему резво подскочил парень лет двадцати пяти. Он был худым и довольно нескладно сложенным. У него были растрепанные черные волосы и очень худое лицо.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1205, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Добрый день, мистер! На сколько вас заправить?
- Джимми: Привет, заправь на полный бак. Тебя зовут Даниэль?
- Даниэль: Да! А откуда вам известно?
- Джимми: Разговаривал с Лизой - официанткой из кафе. Она назвала тебя самым привлекательным парнем в городе.
- Даниэль: Правда? Да вы меня разыгрываете, мистер!
- Джимми: Я серьезно. Поэтому у тебя есть все шансы.
- Даниэль: Спасибо! Лиза и правда самая красивая девушка в Лонлифарме! Кстати, как вас зовут?
- Джимми: Джимми Хаксли. Я детектив полиции.
- Даниэль: А вы тот самый детектив из Йорк-Сити! Приятно познакомиться! Наша местная газета писала о вашем богатом послужном списке, все мы возлагаем на вас большие надежды в деле поиска Карла.
- Джимми: Лиза сказала, что ты тот еще пройдоха, в курсе всех новостей города. Что тут у вас вообще интересного происходит?
- Даниэль: Да вот, говорят что наш город скоро изменится. К нам приходит крупный инвестор, масштабы деятельности нашего дереводобывающего завода могут выйти на новый уровень. Все это не может не сказаться на жизни нашего спокойного городка. После того, как директором завода стал Генри Мартон он стал активно привлекать новых инвесторов и увеличивать масштабы деятельности.
- Джимми: Возможно это пойдет на пользу Лонлифарму. Появятся новые рабочие места.
- Даниэль: Да, и вместе с этим новые проблемы.
- Джимми: Я так понимаю дереводобывающий завод находится в лесу. Возможно, кто-то из работников завода что-то видел в день пропажи Карла. Как мне поговорить с этим Генри Мартоном?
- Даниэль: Их офис расположен на Рэд Стрит, дом 7. Думаю, если он узнает, что вы детектив, то он обязательно примет вас.
- Джимми: А что ты слышал о Стефане Кнайте?
- Даниэль: Мы учились в одном классе. Но после школы не общались. Неприятный, задиристый тип. То что он сделал, это просто не укладывается в голове.
- Джимми: Мне сказали, что он совершил преступление под влиянием наркотиков. Но где он мог их взять в вашем маленьком городе?
- Даниэль: Кто его знает. Ходили слухи, что с этим как-то связано руководство завода. Ведь до прихода нового директора и его людей у нас ничего подобного не было. А после Стефана еще нескольких людей привлекали к ответственности за употребление наркотиков. Но это лишь слухи.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Мне кажется, что на тему распространения наркотиков ты мог бы мне рассказать больше.", 1210, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Тебе повезло, что ты перестал общаться со Стефаном.", 1220, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1205, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Нет, я ничего не знаю про это. Это дело полиции.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1230, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Это уж точно. Но у меня есть своя голова на плечах.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1230, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1220, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ладно, Даниэль, увидимся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1240, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(51, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(52, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1230, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поехать к Нейту.", 900, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(47, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Вернуться в отель.", 1300, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(52, 3, 3, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(1240, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"День пролетел незаметно. Наступил вечер и Джимми решает, что пора возвращаться в отель.
Заказав ужин в номер, Джимми удобно устроился на диване и начал обдумывать прошедший день. За день накопилось много информации, над которой следует поразмыслить.
Джимми всегда носит с собой записную книжку, в которую записывает все важные детали. Возможно, что-то из этого поможет выяснить, что случилось с Карлом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1310, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1300, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Изучить записную книжку.", 1320, 0));
        locationEntity.passageList.Add(new PassageEntity("Почитать газету.", 1380, 0));
        locationEntity.passageList.Add(new PassageEntity("Лечь спать.", 1500, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1310, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми в течение дня усердно выписывал все моменты, которые ему казались странными и подозрительными. Так выглядело содержание того, что он записал за сегодня:";
        locationEntity.passageList.Add(new PassageEntity("Отношения Дона и Нейта.", 1330, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(53, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отношения Билла и Карла.", 1340, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(54, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закрытость Нейта.", 1350, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(55, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Жена Дона.", 1360, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(56, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Информация о Стефане.", 1370, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(57, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение записной книжки.", 1310, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1320, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон в разговоре с Руфусом как-то сказал, что Нейт больше любит Билла, чем его. В целом создается впечатление, что в их отношениях далеко не все гладко.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1330, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Во время общения с Биллом тот был закрыт и скрытен. Лиана рассказала о том, что Билл мало уделял время Карлу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1340, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт не сильно горел желанием что-либо рассказывать о Карле. Также он упомянул о том, что в последнее время они не общались.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1350, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Родители Нейта в разводе. По каким-то причинами Нейт не знает, почему развелись его родители.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1360, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф рассказал о том, что его друг Альфред видел Стефана. Стефан - сбежавший преступник. Возможно исчезновение Карла может быть связано со Стефаном?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1320, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1370, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Основная тема газеты была посвящена переговорам Генри Мартона с приехавшими бизнесменами из Бриз-Сити. Как утверждает журналист, за инвестиции в размере пятидесяти миллионов долларов в течение года, партнеры хотят сорок процентов от акций завода.
Небольшая статья была и о деле Карла. В ней говорилось о том, что наконец-таки в этом деле возможны подвижки. И связывают это с приездом Джимми Хаксли - опытного детектива, за плечом которого раскрытие нескольких громких дел. Также приводится краткая биографическая справка о Джимми.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1310, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1380, locationEntity);
        #endregion
        #region Day 3
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Среда, 29 сентября.
Большой бизнес в маленьком городе.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1500, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми спал на редкость хорошо, без каких-либо сновидений. Проснувшись с утра он почувствовал себя бодрым и полным сил.
Его мысли в первую очередь были сосредоточены на неожиданном джокере в расследовании - Стефане Кнайте. Пожалуй, нужно наведаться в полицейский участок и узнать о нем побольше. Также нужно поговорить с Альфредом, другом Ральфа.
Неплохо было бы посетить и Генри Мартона, директора дереводобывающего завода. Возможно, он бы мог рассказать что-то полезное.
Сделав небольшую разминку, Джимми стал собираться в путь. Перед выходом из отеля Джимми решил перекинуться парой слов с Руфусом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1530, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1510, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поехать в полицейский участок.", 1600, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(73, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поехать к Альфреду.", 1900, 0));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Эдвардом Рэдли.", 1920, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(74, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(75, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Навестить офис Генри Мартона.", 2000, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(77, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Вернуться в отель.", 2140, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(79, 4, 4, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1520, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Руфус как обычно стоял у администраторской стойки и что-то живо объяснял молодой девушке, по всей видимости - горничной.
- Джимми: Добрый день, Руфус! Не отвлекаю?
- Руфус: Добрый день, мистер Хаксли! Да, сейчас только закончу инструктаж новой сотрудницы и я к вашим услугам.
- Джимми: Да, конечно. Я хотел бы поговорить на счет Стефана Кнайта.
- Руфус: А что именно о нем вы хотите узнать?
- Джимми: Как я понял, он совершил достаточно громкое преступление, тем более по меркам вашего города. Тем не менее, мне никто о нем не рассказывал, и я узнал о нем случайно.
- Руфус: Всех жителей Лонлифарма шокировало совершенное им деяние. Не удивительно, что никто не хочет вспоминать о Стефане. А что, какое отношение он имеет к пропаже Карла?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Не знаю, скорее всего никакого. Тем не менее, хотелось бы кое-что о нем знать.", 1540, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Тут такое дело, поговаривают что Стефана видели в городе как раз примерно в то время, когда исчез Карл.", 1550, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(68, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1530, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Что конкретно вас интересует?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1560, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1540, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Это невероятно. Вот это новости. На сколько точна эта информация?
- Джимми: К сожалению, не точна. Но все же я бы хотел уточнить о нем кое-какую информацию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1560, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1550, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вы были знакомы со Стефаном?
- Руфус: Видел его иногда, но лично не общался. Я был немного знаком с его отцом - Грегом. Он много пил и нигде не работал. Несколько лет назад он умер. О матери Стефана я ничего не знаю, вроде бы они развелись уже как лет десять. В Лонлифарме она никогда не появлялась.
- Джимми: Я слышал, что Стефан принимал наркотики. Это правда?
- Руфус: Если он и принимал наркотики, то только в последнее время. Я слышал, что в момент совершения преступления он находился по действием каких-то веществ. Но раньше ничего такого у него на замечалось.
- Джимми: Но откуда он мог взять наркотики в вашем городке?
- Руфус: Этого никто не знает. Но после Стефана у нас случаи употребления этой дряни участились. Некоторые связывают это с приходом нового руководства дереводобывающего завода. Но доказательств этому нет.
- Джимми: Руфус, спасибо за информацию. Если что-то будет известно новое - обязательно сообщайте.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1570, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(69, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(80, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1560, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Из еще одного источника Джимми услышал о гипотетической связи наркоторговли в городе и нового руководства завода. Это просто пустые слухи или что-то в этом есть?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(1570, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Плюс таких городов, как Лонлифарм - в любую точку можно добраться на автомобиле за пять минут максимум.
Через несколько минут Джимми уже заходил в дверь полицейского участка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1610, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1600, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить со Стерлингом.", 1500, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(70, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Джонсоном.", 1500, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(71, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Анной.", 1500, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(72, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из участка.", 1500, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(73, 3, 3, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(79, 0, 4, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1610, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми прошел в кабинет Стерлинга, он был на месте.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1625, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1620, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, мистер Хансон.
- Стерлинг: Добрый день, Джимми. Как продвигается расследование, есть что нового?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Есть любопытные новости. К вам случайно не заходил еще Альфред Стоун?", 1630, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я тут узнал о Стефане Кнайте и его убийстве двух полицейских. Почему вы мне сразу не рассказали об этом случае? Это может играть важную роль в расследовании.", 1640, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1625, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да, он заходил еще вчера. Новости действительно очень тревожные. Но нельзя быть на сто процентов уверенным в словах Альфреда. Ему уже за семьдесят, вполне возможно ему просто показалось.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1650, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1630, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: В нашем городе происходило много всего. Не обязательно все должно быть связано с исчезновением Карла. Хотя в свете последних событий... Вам должно быть уже известно, что к нам приходил Альфред Стоун. Новости очень тревожные. Но нельзя быть на сто процентов уверенными в словах Альфреда. Ему уже за семьдесят, вполне возможно ему просто показалось.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1650, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1640, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Информацию о достоверности сведений Альфреда нужно проверить. Тем не менее, просто откинуть мы это не можем. Мне нужно знать больше о Стефане Кнайте.
- Стерлинг: Да, я могу ответить на любые ваши вопросы, которые касаются Стефана.
- Джимми: Как известно, Стефан совершил преступление под действием наркотиков. Откуда они могли появиться в Лонлифарме?
- Стерлинг: Пока нам это не известно. После случая со Стефаном, в Лонлифарме было зафиксировано еще двенадцать случаев употребления наркотиков молодыми людьми. Все они были допрошены, но внятных показаний дать не смогли.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("То есть у вас имеется больше десятка случаев и до сих пор никакой информации о распространителе? Вы уверены, что допросы были осуществлены профессионалами?", 1660, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я не сомневаюсь, что допросы были проведены со всей компетентностью. Но неужели показания двенадцати человек не дают никакой наводки на распространителя?", 1670, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1650, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Допросы проводили сотрудники нашего отдела. Они делали свою работу как следует, но зацепиться нам пока не за что. Все случаи отличаются местом, временем и способом продажи. Очевидно, что тут работает целая группа посредников.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1660, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, нет. Все случаи отличаются местом, временем и способом продажи. Очевидно, что тут работает целая группа посредников.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1670, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Я слышал, что существовали подозрения причастия нового руководства завода к распространению запрещенных веществ. Это правда?
- Стерлинг: У нас не было и нет никаких прямых доказательств этого. В связи с тем, что имеется прямая временная взаимосвязь между приходом нового руководства и появлением наркотиков в городе, была осуществлена проверка. Но, как и ожидалось, никаких доказательств существования этой связи мы не нашли.
- Джимми: Как получилось, что Стефану удалось так просто сбежать?
- Стерлинг: Убийства произошли дома у Стефана, после того как капитан Купер с напарником приехали к нему для беседы. Никто не ожидал такого исхода, у Стефана была фора по времени. Он успел добраться до вокзала Харпсвиля, там его видели последний раз. Стефан объявлен в федеральный розыск, но до сих пор о нем нет никакой информации.
- Джимми: Хорошо, мистер Хансон. Удачного вам дня.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1610, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(70, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(73, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1680, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми прошел в кабинет к Джонсону. Джонсон сидел на стуле и сосредоточенно смотрел в окно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1695, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1690, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Привет Джонсон! О чем задумался?
- Джонсон: Добрый день, мистер Хаксли. Вы уже наверно слышали об этих слухах? О том, что Стефан Кнайт снова в Лонлифарме.
- Джимми: Да. Джонсон, агент Стэнли Купер был твоим отцом?
- Джонсон: Именно.
- Джимми: Очень жаль, что так вышло. Как ты думаешь, это и правда был Стефан? Если это так, то у нас могла бы появиться зацепка по поиску Карла.
- Джонсон: Я не знаю. Этот старик Альфред запросто мог что-то напутать.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Разве тебе не хотелось, чтобы это и правда был Стефан? Тогда у тебя будет отличная возможность расквитаться с негодяем.", 1700, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("А если это действительно был Стефан? Тебя не тревожит, что это может оказаться правдой?", 1710, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1695, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Конечно, я хочу всей душой, чтобы Стефан ответил по закону за свое злодеяние. Но я полицейский и не имею права на самосуд.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1720, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1700, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Конечно тревожит. Я все утро об этом думаю. Если это так, то мы обязаны поймать мерзавца.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1720, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1710, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Но какой мотив может быть у Стефана? Зачем ему возвращаться и подвергать себя опасности?
- Джонсон: В том-то и вопрос. Возможно он просто соскучился по дому. Хотя лично я думаю, что старик просто выдает свои фантазии за реальность.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Может быть ты просто боишься возвращения Стефана?", 1730, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(81, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Да, не думаю что словам Альфреда нужно сейчас относиться слишком серьезно. Если бы Стефан объявился, то за месяц его точно кто-нибудь бы заметил.", 1740, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1720, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: С чего бы мне его бояться? Я мечтаю надеть на него наручники, и однажды я это сделаю.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1750, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1730, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Честно говоря, я тоже так считаю. Хотя я искренне мечтаю надеть наручники на Стефана, и однажды я это сделаю.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1750, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1740, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ладно Джонсон, удачного дня. И еще раз - мои соболезнования по поводу твоего отца.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1610, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(71, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(73, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1750, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Анна со скучающим выражением лица сидела за своим рабочим местом и читала какую-то книжку.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1765, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1760, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Привет Анна. Вижу ты слишком занята, я тебя не сильно отвлеку?", 1770, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("День добрый, Анна. Что нового тут у вас?", 1780, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1765, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Добрый день. Да вроде бы нет. Вы что-то хотели?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1790, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1770, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Добрый день, мистер Хаксли! Главная новость - вчера в участок приходил пенсионер Альфред Стоун. Он утверждает, что видел собственными глазами самого Стефана Кнайта!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1790, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1780, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Что ты сама думаешь о всей этой ситуации со Стефаном Кнайтом? Он и правда мог вернуться в Лонлифарм?
- Анна: Да, вполне! Я предчувствовала, что однажды настанет тот день, когда Стефан решит вернуться. И вот похоже этот день пришел.
- Джимми: Ты так уверена, что Альфред не мог просто перепутать его с кем-то?
- Анна: Да. Альфред до сих пор сохраняет крепкое здоровье и, кажется, неплохое зрение. Я думаю, что он не их тех людей, которые будут что-то фантазировать. Если он решил сказать об этом полиции, то он уверен в том, что это Стефан.
- Джимми: А ты лично знала этого Стефана?
- Анна: Ага. Мы учились в одном классе.
- Джимми: И каким он был?
- Анна: Сложный вопрос. Он был всегда таким закрытым. Честно говоря, я никак не могла ожидать, что он способен на такой страшный поступок. В школе мы неплохо с ним ладили.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Он совершил преступление под воздействием наркотических веществ. Не удивительно, что ты не видела в нем ничего плохого.", 1800, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Все, с кем я разговаривал до этого, утверждают, что Стефан был человеком с преступными наклонностями. Но у тебя мнение о нем немного отличается от общего. Тебе не хочется говорить о Стефане что-то плохое?", 1810, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(82, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1790, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Стефан рос в плохой семье, без внимания родителей. Я уверена, что именно это причина того, что он стал употреблять эту дрянь. Он был способен и на хорошие поступки.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1820, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1800, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Вовсе нет. Да, мы с ним дружили в школе, это правда. Но после школы практически не общались. Он совершил чудовищное злодеяние, тут не может быть оправданий.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1820, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1810, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Если Стефан и правда вернулся, то возможно он захочет с кем-то связаться из бывших знакомых. У него были еще друзья?
- Анна: Со мной то он вряд ли захочет связаться, учитывая где я работаю. На сколько я знаю, у него не было близких друзей. Он был всегда молчаливым и неразговорчивым.
- Джимми: Как отреагировал Джонсон на новость о возможном возвращении Стефана?
- Анна: Внешне он старается всегда быть спокойным. Но мне показалось, что эта новость его сильно взволновала.
- Джимми: Понятно. До встречи, Анна. Приятно было поболтать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1500, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(72, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(73, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(1820, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Гастингс Стрит была совершенно типичной Лонлифарма улицей. Она располагалась на окраине города, состояла из двухэтажных и одноэтажных жилых домов и тянулась вдоль густого лесного массива.
Дом Альфреда Стоуна был маленьким и непримечательным. Джимми позвонил в звонок.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1905, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.AlfredHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1900, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Альфред был худым человеком невысокого роста. Его лицо было покрыто глубокими морщинами. Он довольно сильно сутулился и смотрел на Джимми рассеянным взглядом.
- Джимми: Добрый день, мистер Стоун. Я детектив полиции Йорк-Сити. Меня зовут Джимми Хаксли. Я занят расследованием исчезновения Карла Вигса. У вас не найдется минут десять свободного времени?
- Альфред: Хоть десять часов, молодой человек. Чем могу быть полезен?
- Джимми: Я думаю вы догадыветесь - меня интересует Стефан Кнайт. Вы уверены, что это был он?
- Альфред: Ясно. Мистер Хаксли, давайте пройдем в дом. Я сделаю вам отличный кофе. Думаю, разговор у нас будет длинный.
- Джимми: С радостью, мистер Стоун. Спасибо, кофе мне сейчас точно не помешает.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1910, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.AlfredRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Alfred;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1905, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми и Альфред прошли в дом. Внутри все было достаточно аккуратно, дом содержался в полном порядке. На стенах висело много старых фотографий.
- Альфред: Так вы хотите знать про Стефана? Да, сейчас я действительно уверен, что это был именно он. Этот взгляд. Холодный и жестокий. Он ехал в машине на месте пассажира. Более того, я мельком видел водителя. Где-то я видел это лицо. Но пока не могу вспомнить где именно. Черт бы побрал этот склероз. Старость не радость.
- Джимми: Это очень интересно. Альфред, а где ваша семья? Я вижу, что у вас много фотографий, это с вашей работы?
- Альфред: Дети давно уже живут в Йорк-Сити. Иногда меня навещают. А так я живу один. Эти фотографии напоминают мне о былых временах и не дают сильно скучать. Я тридцать лет проработал на местном лесодобывающем заводе. На стене много фотографий из моих былых трудовых будней.
- Джимми: А вы давно ушли на пенсию? Вы застали приход нового руководства?
- Альфред: Да как вам сказать. Я не хотел уходить на пенсию, здоровье позволяло мне работать еще долго. Но когда директором стал этот Генри Мартон, меня быстро убедили уйти. Пожилые люди с огромным опытом стали никому не нужны на заводе. Все было не так при Эдварде Рэдли, предыдущем директоре. Этот Генри мерзкий тип. Я уверен, что он причастен к распространению этой дряни, которая свела с ума Стефана. А теперь еще и Стефан вернулся и пропал мальчик... Столько всего случилось за последнее время. Если говорить честно, то я провожу свое собственное небольшое расследование.
- Джимми: Вот как? Альфред, это конечно очень похвально с вашей стороны, но для этого есть полиция.
- Альфред: Если бы полиция могла и хотела работать, то наркоторговцы бы уже отбывали пожизненное, а Карл был бы дома. Приходиться рассчитывать на свои силы.
- Джимми: И как вы ведете расследование? Что-то удалось узнать?
- Альфред: Пока не очень много. Я как-то под видом того, что мне нужно оформить пенсионные документы проник на территорию завода. Пытался найти что-то, что возможно бы указывало на связь нынешнего руководства с распространением наркотиков. Но теперь во многих местах появилась охрана. Для чего она там? Раньше ее не было.
- Джимми: Да, это довольно странно. Вас кто-нибудь видел?
- Альфред: Да, к сожалению. Этот заместитель Генри - Янг Шерри, тоже на удивление скользкий и неприятный тип. Я сказал, что у меня вопросы к секретарю по поводу пенсионных отчислений, вроде бы он поверил.
- Джимми: Альфред, вы большой молодец и смелый человек. Но больше так не делайте. Если вы правы и они действительно замешаны в этой истории с наркотиками, то кто знает, что у них может быть на уме.
- Альфред: Мою уверенность в том, что в этом деле замешан Генри Мартон подтверждает и Эдвард Рэдли. Он руководил заводом много лет, сейчас он на пенсии. Мы с ним дружим до сих пор. Он как-то говорил, что его заставили уйти со своего поста достаточно бесчестным способом. Честные и законопослушные люди так не поступают.
- Джимми: А как мне поговорить с этим Эдвардом?
- Альфред: Он живет тут рядом. На Гастингс Стрит 9. Обычно он всегда дома.
- Джимми: Альфред, а как вы считаете, Стефан мог быть замешан в исчезновении Карла?
- Альфред: Стефан совершил чудовищное убийство двух полицейских. Если допустить, что он вернулся в Лонлифарм и случайно встретил где-нибудь в безлюдном месте Карла... Кто знает, что у него в голове?
- Джимми: Альфред, я надеюсь, что вы рассказали о своем небольшом расследовании в полицию?
- Альфред: Да, мне пришлось. На кону жизнь ребенка.
- Джимми: Альфред, было очень приятно познакомиться. Я думаю, что вы мне здорово помогли. Будьте осторожны.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1520, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(74, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(77, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(79, 0, 4, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(83, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.AlfredRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Alfred;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1910, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дом Эдварда находился рядом с домом Альфреда. Он был окрашен в приятный голубой цвет и выглядел очень ухоженно и богато. Эдвард явно мог гордиться своим садом - он находился в идеальном порядке и в нем росло много превосходных цветов и другой растительности.
Джимми постучался в дверь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1925, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1920, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Через какое-то время ему открыл смуглый и немного полноватый человек с мягким взглядом и небольшой бородой. Выглядел он лет на шестьдесят.
- Джимми: Добрый день, вы мистер Рэдли?
- Эдвард: В точку. Чем могу быть полезен?
- Джимми: Меня зовут Джимми Хаксли. Я детектив полиции из Йорк-Сити. Я бы хотел бы задать вам пару вопросов.
- Эдвард: Вот-как. Что же, проходите.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1927, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1925, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо. Эдвард, в первую очередь меня интересует Генри Мартон. Что вы можете сказать об этом человеке?
- Эдвард: Я так и знал, что вы спросите о нем. Честно говоря, ничего хорошего сказать не могу. Он хитрый, расчетливый и жадный человек, который к тому же, как мне кажется, замешан в каких-то темных делишках.
- Джимми: Вы имеете в виду эту историю с наркотиками?
- Эдвард: Да. Я не хочу быть голословным, но вся эта ерунда началась именно после приезда Мартона в наш город. Это очень подозрительно.
- Джимми: Ваш друг Альфред сказал, что Генри сместил вас с должности директора каким-то незаконным способом. Это правда?
- Эдвард: Вот старый болтун. Но раз уж зашла это тема, то можно выразиться и так. Если говорить совсем просто, то мне вынудили уйти обычными угрозами. Я был уже в возрасте и не хотел ввязываться во все это. Я просто продал свою часть акций и все.
- Джимми: Полиции вы конечно же не сообщали?
- Эдвард: Нет.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Генри может быть причастен к очень серьезным делам. Возможно ваше молчание сыграло очень злую шутку.", 1930, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я думаю, вас вполне можно понять в этой ситуации. Лучше спокойная пенсия, чем проблемы с такими людьми.", 1940, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1927, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Тогда я не мог подумать, что Генри может быть замешан в таких делах. Но, по всей видимости, я допустил ошибку.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1950, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1930, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Я тогда подумал также. Но этот Генри оказался похоже еще опаснее, чем я мог себе предположить.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1950, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1940, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Есть свидетель, который утверждает, что видел в Лонлифарме Стефана Кнайта. Причем это было примерно месяц назад, то есть в то время, когда пропал Карл.
- Эдвард: Невероятно. Неужели этот мерзавец решил вернуться? Просто не верится. А как продвигаются поиски этого мальчишки, Карла? Есть какие зацепки?
- Джимми: Есть одна зацепка. Недавно в почтовом ящике семьи Вигсов обнаружен некий рисунок. Нарисован явно ребенком. На нем изображен лес и написано слово ""Бен"". Лиана Вигс утверждает, что это нарисовал Карл.
- Эдвард: Погодите-ка...Вы говорите Бен... Не знаю, совпадение или нет, но я припоминаю странный случай. Я часто ходил с завода домой пешком. До моего дома идти через лес минут двадцать. Однажды я вышел через центральный вход и заметил, что у забора завода стоит человек. Он просто стоял неподвижно и смотрел. Я решил подойти к нему. Я спросил -""Что вы тут делаете?"" Он молчал. Затем я спросил - ""Как ваше имя?"". После некоторой паузы он тихо сказал - ""Мое имя - Бен"". Затем он просто ушел.
- Джимми: А как выглядел этот человек? Вы его раньше не видели в городе?
- Эдвард: Не видел, совершенно точно. Был уже вечер, я его разглядел не слишком хорошо. Он был не брит, наверное ему лет пятьдесят. Он выглядел как бродяга. Он был невысокого роста и худощавый. Волосы были седые.
- Джимми: А когда это было?
- Эдвард: Давно. Года три назад.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Про это вы естественно тоже никому не говорили. А вы не думали, что эта информация может помочь найти Карла?", 1960, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Понятно. Скорее всего это просто какой-то бродяга.", 1970, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1950, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Конечно нет. Я понятия не имел об этом рисунке.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1980, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1960, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Скорее всего. Но совпадение имени меня немного тревожит.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1980, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1970, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Все это весьма странно. Пожалуй, мне нужно хорошенько все обдумать. Огромное спасибо за информацию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1520, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(75, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(76, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(79, 0, 4, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(84, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(1980, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Офис руководства лесодобывающего завода находился недалеко от центральной площади Лонлифарма в отдельном трехэтажном здании из красного кирпича. Джимми вошел внутрь. На посту охраны пришлось объяснить цель визита и показать удостоверение детектива. Ему сказали пройти на второй этаж и подождать пока Генри освободиться. Интерьер офисного центра завода был весьма современным, видно что совсем недавно был проведен ремонт. Джимми уселся на кожаный диван и стал ждать. 
Вскоре к нему подошел невысокий черноволосый человек с желтоватой кожей и недружелюбным выражением лица.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2005, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2000, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Янг: Добрый день. Я так понимаю вы хотите поговорить с Генри Мартоном. Какая цель вашего визита?
- Джимми: Я детектив полиции, мое имя Джимми Хаксли. Я веду расследование исчезновения подростка Карла Вигса и хотел бы задать Генри пару вопросов.
- Янг: Мое имя - Шерри Янг и я заместитель Генри. Боюсь, что Генри встречается лично только по деловым вопросам. Да и при чем тут пропажа этого мальчика и Генри?
- Джимми: Думаю принять меня в интересах Генри. Или вам нужен орден и тотальная проверка всей вашей деятельности? Для меня это не проблема. Меня не интересуют многие аспекты вашей деятельности, у меня вопросы к Генри иного характера. Но если вы не пойдете на встречу - ситуация может поменяться.
- Янг: Хм. Вижу вы настроены решительно. Хорошо, пройдите в офис. Генри вас ждет.
- Джимми: Янг, вижу ты понятливый парень. Далеко пойдешь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2007, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2005, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми прошел в кабинет к Генри. Генри был высоким и хорошо сложенным, на вид ему было лет сорок. У него были светлые волосы и спокойный взгляд.
- Генри: Добрый день мистер Хаксли! Чем обязан вашему визиту?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Добрый день, мистер Мартон. У меня пара вопросов, много времени я не займу.", 2010, 0));
        locationEntity.passageList.Add(new PassageEntity("Добрый день. Я вижу, что вы уже навели справки обо мне. Ожидали визит полиции?", 2020, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2007, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Хорошо, мистер Хаксли. Честно вам сказать, у меня скоро важная встреча.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2030, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2010, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: О вашем приезде наслышаны уже все в нашем городе. Справок наводить не потребовалось.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2030, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2020, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вы вероятно слышали о Стефане Кнайте и о том, что он совершил?
- Генри: Я примерно в то время переехал в Лонлифарм, тогда только об этом и говорили. Конечно, я слышал о нем.
- Джимми: Стефан в момент преступления находился под действием наркотических веществ. Ранее случаев распространения наркотиков в Лонлифарме не было. После Стефана было еще несколько случаев. То есть у нас имеется факт того, что кто-то занимался сбытом наркотиков. Это совпало по времени со сменой руководства на дереводобывающем заводе. Вы можете что-то сказать по этому поводу?
- Генри: Разумеется это только совпадение. Но слух разошелся очень быстро. Была проверка нашей деятельности со стороны полиции. Мы полностью чисты перед законом. Мы занимаемся бизнесом.
-Джимми:";
        locationEntity.passageList.Add(new PassageEntity("В таком случае зачем вам столько охраны на территории завода?", 2040, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У меня нет причин не доверять итогам проверки. Есть ли у вас какие-либо предположения по факту распространения наркотиков в городе?", 2050, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2030, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Мы в данный момент ведем переговоры с крупным инвестором. Мы повысили в последнее время расходы на охрану с целью повышения репутации нашего предприятия как исключительно безопасного места.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2060, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2040, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Нет. Я все свое время провожу на работе. У меня нет знакомых в городе и я практически никого тут не знаю. Тем более я не в курсе подобных дел.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2060, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2050, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Есть информация о том, что Стефан Кнайт вернулся в Лонлифарм.
- Генри: Что? Этого просто не может быть!
- Джимми: Вас взволновала эта новость? Почему Стефан не мог вернуться в свой родной город?
- Генри: Нет, конечно нет. Я не знаю ничего о нем. Просто подумал о том, что в его ситуации было бы безумием возвращаться сюда. А откуда такая информация?
- Джимми: Его видел Альфред Стоун - пенсионер, бывший работник завода. Стефан ехал в машине на пассажирском сиденье.
- Генри: А кто был за рулем?
- Джимми: Альфред пока не может вспомнить этого. Но лицо ему показалось знакомым.
- Генри: Да, это очень интересно, если конечно это окажется правдой. У стариков зрение не очень, они часто выдумывают что-то не соответсвующее действительности.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Мистер Мартон, мне показалось или вас действительно взволновала новость о возможном возвращении Стефана?", 2080, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(67, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(85, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Пока слова Альфреда действительно ничем не подтверждены. В конце-концов больше никаких свидетелей нет. Хотя этот случай случился месяц назад, за это время наверняка кто-нибудь бы еще заметил Стефана.", 2090, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2060, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Меня она не взволновала, но удивила. Я слышал, что где-то месяц назад пропал какой-то мальчик. Возможно это связано с возвращением Стефана?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2090, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2080, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Мартон, у меня еще один вопрос. Бывший директор завода Эдвард Рэдли мне сказал о том, что как-то видел рядом с территорией завода странного вида человека лет пятидесяти. У него был вид бродяги и он сказал, что его имя - Бен.
- Генри: Хм. Я не знаю на счет имени, но до меня как-то доходили слухи о том, что некоторые работники видели какого-то человека весьма странного вида в лесу. Правда слышал я это уже довольно давно - пару лет назад.
- Джимми: Кстати на счет Эдварда. Каким образом он покинул пост руководителя завода?
- Генри: Эдвард уже достиг пенсионного возраста и устал. Он решил продать свою часть акций и отойти от дел.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Хорошо, думаю, что это уже не мое дело.", 2100, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У меня немного другая информация. Возможно, что Эдвард продал свою часть акций под влиянием угроз с вашей стороны?", 2110, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2090, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: В любом случае во время проверки полицейские интересовались и этим моментом. Все было в рамках закона.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Такую версию рассказал вам Эдвард? Я не удивлен. Просто он не хотел продавать акции по рыночной стоимости и хотел получить за них цену в несколько раз выше их реальной цены. У нас просто состоялся серьезный разговор, где мы сошлись на взаимовыгодных условиях.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Хорошо мистер Мартон. Больше у меня вопросов нет. Хорошего вам дня.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 1520, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(79, 0, 4, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(2130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Это был совершенно определенно непростой день. Джимми узнал много новых, весьма интересных фактов. Немного расслабившись и посмотрев телевизор, Джимми открыл свою записную книжку. То, что он записал за сегодняшний день выглядело следующим образом:";
        locationEntity.passageList.Add(new PassageEntity("Гипотетическая связь нового руководства завода с распространением наркотиков.", 2150, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(80, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Близкая к страху реакция Джонсона на новость о возвращении Стефана.", 2160, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(81, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Некое оправдание со стороны Анны поступка Стефана, их дружба в школьные годы.", 2170, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(82, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Угрозы Эдварду Стоуну со стороны Генри Мартона при совершении сделки по продаже акций.", 2180, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(83, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Странный человек, которого видели в лесу, назвавшийся Беном.", 2190, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(84, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Резкая перемена настроения Генри, после того, как он узнал новость о возвращении Стефана.", 2200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(85, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение записной книжки.", 2210, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Случаи употребления наркотиков совпали с приходом к руководству заводом Генри Мартона. Несколько людей высказали подозрения по этому поводу. Альфред даже устроил свое небольшое расследование и проник на территорию завода. Альфред заметил, что количество охраны на территории завода резко возросло.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2150, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Волнительная реакция Джонсона но возможное возвращение убийцы его отца вполне объяснима. Однако Джимми увидел в реакции Джонсона нечто другое. Он увидел там неподдельный страх.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2160, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"То, что Анна и Стефан дружили в школьные годы стало для Джимми сюрпризом. Похоже, что Анна пытается даже оправдать Стефана. Или это Джимми только показалось?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2170, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Эдвард поделился информацией о том, что Генри Мартон угражал ему при совершении сделки по продаже акций. Генри это отрицает, оправдываясь жадностью Эдварда. На чьей стороне правда?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2180, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Пару лет назад в лесу видели странного человека, который сказал, что его зовут Бен. На рисунке Карла тоже было написано это имя. Это просто совпадение или что-то большее?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2190, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Поведение Генри Мартона было весьма странным. Вначале он держался очень спокойно и хладнокровно. Но все изменила новость о том, что Альфред видел Стефана Кнайта. На несколько мгновений на лице Генри отобразилось искреннее изумление и даже страх. Что еще мог знать Генри о Стефане?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2140, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дело обретало весьма неожиданный оборот. Между участниками этой истории начинали вырисовываться определенные связи. На несколько мгновений Джимми даже показалось, что у него в голове начинают складываться кусочки этого пазла в цельную картину. Однако, тело после тяжелого дня противилось серьезным раздумиям и вскоре Джимми погрузился в сон.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2220, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми снится странный и мрачный сон.
Он идет через темный лес. За ним совершенно точно кто-то наблюдает. Джимми начинает волноваться. Волнение все нарастает. Вдруг во тьме он видит очертания некого человека.
- Ты ищешь меня? - Спрашивает этот человек.
- Да. - Коротко отвечает Джимми.
Фигура этого человека начинает медленно растворяться в воздухе.
Вдруг Джимми начинает резко проваливаться, в ушах стоит страшный шум.
Где-то в подсознании Джимми пролетает мысль о том, что этот же сон Джимми уже видел. Это было накануне загадочного убийства управляющего Государственного Музея Искусств Йорк-Сити.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2250, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.DarkForest;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.DarkWalk;
        locationDictionary.Add(2220, locationEntity);
        #endregion
        #region Day 4
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Четверг, 30 сентября.
Дела семейные.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2260, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2250, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"С утра Джимми почувствовал необычную для себя разбитость. Он встал с кровати и, решив пропустить утреннюю разминку, сразу заказал завтрак в номер.
Странный сон не выходил из головы. Что он мог значить? До этого Джимми никогда не снился один и тот же сон дважды.
Тем не менее, нужно было приступать к работе. Джимми быстро прикинул план на день. Он еще ни разу не был в школе, где учился Карл и не общался с его классным руководителем. Хотя учителя нередко знают о детях даже больше, чем их родители. Джимми решает восполнить этот пробел и отправиться в среднюю школу Лонлифарма.";
        locationEntity.passageList.Add(new PassageEntity("Поехать в школу.", 2270, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2260, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Школа Лонлифарма находилась недалеко от центральной площади города. Школа находилась в небольшом двухэтажном здании бледно-розового цвета. Было видно, что школа построена недавно. Джимми прошел в фойе.
- Джимми: Добрый день. Я детектив полиции Джимми Хаксли. Я занимаюсь пропажей Карла Вигса. Я бы хотел поговорить с его классным руководителем.
- Миссис Йохансон: Добрый день! Да, пройдите,  пожалуйста на второй этаж в кабинет 204. Классного руководителя Карла зовут Милана Раймонд. Наверное, у нее сейчас урок.
- Джимми: Спасибо!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2280, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.School;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2270, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми прошел к нужному кабинету. В классе действительно в настоящий момент шел урок. Джимми решил не отвлекать учителя от работы и подождал до окончания урока.
Раздался звонок. Джимми подождал пока все дети выйдут и вошел в кабинет.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2285, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2280, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Милана Раймонд была женщиной лет тридцати. У нее были короткие русые волосы и внимательный, немного строгий взгляд.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2287, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2285, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Здравствуйте, мисс Раймонд. Мое имя - Джимми Хаксли. Я детектив полиции и занимаюсь поисками Карла Вигса. Можно я отниму у вас минут десять времени?
- Милана: Добрый день. Да, разумеется, мистер Хаксли.
- Джимми: Расскажите немного о Карле. Какой у него характер?
- Милана: Карл был очень старательным и усердным мальчиком. Он довольно неплохо учился, хотя много времени уделял спорту. К нему никогда не было никаких вопросов по поводу поведения. Хотя почему я говорю о нем в прошедшем времени? Еще ведь ничего не известно.
- Джимми: Да, есть некоторые данные, которые дают надежду на то, что Карл жив.
- Милана: Какие?
- Джимми: Родители Карла получили по почте странный рисунок. На нем изображен лес, нарисованный детской рукой. Также на нем написано имя ""Бен"". Лиана Вигс считает, что рисунок нарисован Карлом.
- Милана: Да, я слышала об этом.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2290, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(15, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Далее", 2300, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(15, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2287, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Милана: Да? По правде говоря, мне об этом сказал Даниэль Рэдклиф - парень с местной заправки. Когда он заправляет мою машину мы часто болтаем о том, о сем. Он очень общительный парень. И всегда знает что и где происходит.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2310, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2290, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Милана: Честно, даже не знаю что тут и думать. Я не знаю никакого Бена. Я уже думала над всем этим, но пока не могу понять, что бы это могло обозначать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2310, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2300, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Были ли у Карла какие-либо проблемы с одноклассниками?
- Милана: Я ничего такого не замечала.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Возможно, вы не сильно обращаете внимание на то, что происходит в классе?", 2320, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(15, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Близкие Карла подтверждают, что у него не было проблем в школе и со сверстниками.", 2330, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(15, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2310, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Милана: Это не так. Просто у нас действительно очень хороший и дружный класс. Карл никогда ни с кем не ссорился.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2340, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2320, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Милана: У нас действительно очень хороший и дружный класс. Карл никогда ни с кем не ссорился.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2340, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2330, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Милана, на сколько близко вы знаете родителей Карла? Возможно ли, что у них дома были какие-то проблемы?
- Милана: На родительские собрания приходила всегда Лиана Вигс. Она всегда очень внимательно и серьезно относилась ко всем делам Карла и к его учебе. Билла Вигса лично я не знаю. Но мне казалось, что Карл привязан именно к матери.
- Джимми: Я так понимаю, что лучшим другом Карла был Нейт?
- Милана: Да, все верно. Нейт непростой подросток. Он скрытный и недоверчивый. Иногда проявляет агрессию к сверстникам. Мне кажется, что это все из-за его семьи. Он растет без матери. Причем Дон Уисли - его отец, уделяет сыну очень мало времени. Он никогда не приходит на собрания, не звонит. При встрече не спрашивает, как дела у Карла. Да и насколько я знаю, он любитель выпить. Еще и эта история с миссис Уисли...
- Джимми: А что за история?
- Милана: Дело в том, что лет семь назад она просто пропала. Никто не знает куда она делась. До сих пор о ней ничего не известно. В ее пропаже обвиняли Дона, но никаких доказательств так и не нашли. В итоге обвинения с Дона сняли.
- Джимми: Это интересно. Получается, что миссис Уисли пропала так-же бесследно, как сейчас исчез Карл?
- Милана: Ну, случаи действительно похожи...
- Джимми: А был ли у Дона какой-либо повод для того, чтобы плохо относиться к Карлу?
- Милана: Тут можно только предполагать. Но, если подумать хорошо, то вырисовывается ситуация, что Нейт не сильно привязан к своему отцу, а проводит все свободное время в доме Вигсов. Возможно это злило Дона?
- Джимми: Такое вполне возможно. Нужно проверить этого Дона. Милана, большое вам спасибо за сведения. Надеюсь, еще увидимся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2350, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(95, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(98, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.SchoolRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Milana;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(2340, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Каждый день приносил Джимми все новые неожиданные открытия. Что могло случиться с женой Дона? Могло ли исчезновение Карла быть связано с Доном? Необходимо получить ответы на эти вопросы.";
        locationEntity.passageList.Add(new PassageEntity("Поговорить со Стерлингом.", 2360, 0));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Доном.", 2440, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2350, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми направился в полицейский участок. Анны не было на рабочем месте и Джимми отправился сразу в кабинет Стерлинга.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2365, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2360, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, мистер Хансон. У меня есть несколько вопросов.
- Стерлинг: Добрый день, Джимми. Да, я весь внимания.
- Джимми: Я узнал, что несколько лет назад у Дона Уисли бесследно исчезла жена. Вам что-нибудь об этом известно?
- Стерлинг: Да, разумеется. Этим делом занимался детектив Алекс Морган. Сейчас он на пенсии, на смену ему пришел Джонсон. Миссис Уисли уехала к подруге в Харпсвиль и больше не вернулась. Мы долго копали под Дона, но так не нашли доказательств его причастия к этому делу. Он все отрицал.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Какие еще были версии, кроме Дона?", 2370, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("И вы ему просто так поверили?", 2380, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(95, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(101, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2365, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Была версия того, что миссис Уисли просто сбежала от Дона. Косвенно это подтверждали знакомые Уисли. Многие отзывались о миссис Уисли, как о ветреной, несерьезной женщине. Которая к тому же любила выпить. К тому же, оказалось, что она не хотела ребенка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2390, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2370, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Конечно же нет. Тем не менее, на день пропажи миссис Уисли у Дона было алиби - он был на работе. В первую очередь мы рассматривали версию, что миссис Уисли просто сбежала от Дона. Косвенно это подтверждали знакомые Уисли. Многие отзывались о миссис Уисли, как о ветреной, несерьезной женщине. Которая к тому же любила выпить. К тому же, оказалось, что она не хотела ребенка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2390, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2380, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Что Дон говорил по поводу этой версии? Как у них складывались отношения?
- Стерлинг: У них были сложные отношения, частые скандалы. Однако, Дон не поверил, что от него могла уйти жена и был категорически против этих предложений.
- Джимми: Вы проверяли Дона на возможную причастность к пропаже Карла? У него есть алиби на этот день?
- Стерлинг: С ним беседовал Джонсон. Дон говорит, что был дома с Нейтом в этот день. Нейт также не помнит, чтобы Дон в этот день куда-то отлучался.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("И это все? Официальный допрос вам показался лишним в данном случае?", 2400, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Да, похоже у нас пока нет ничего на Дона. Но я думаю, что имеет смысл поработать в этом направлении.", 2410, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2390, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Дело в том, что нам пока действительно нечего ему предъявить. Его причастие к исчезновению миссис Уисли не доказано. У нас нет никаких веских оснований предполагать, что в данном случае Дон врет. У него нет никакого мотива похищать Карла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2420, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2400, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Основная проблема в мотиве. Какой у него может быть мотив? Пока у нас нет серьезных причин, чтоб не доверять Дону.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2420, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2410, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Может быть мотив Дона - вернуть внимание Нейта к себе? Ведь он все свободное время проводил с Карлом.
- Стерлинг: Думаю, такой мотив может подтолкнуть к преступлению только психически нездоровых людей. Дон конечно не образец для подражания, но кажется вполне адекватный человек. В любом случае, я поручу Джонсону поработать с Доном посерьезней.
- Джимми: Хорошо, мистер Хансон. До встречи.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2430, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(96, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2420, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Доном Уисли.", 2440, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(97, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 2575, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(97, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2430, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к дому семьи Уисли, припарковал свой автомобиль и позвонил в дверь. После достаточно продолжительной паузы дверь открыл Дон.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2445, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2440, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Это опять вы? Что вам нужно на этот раз?
- Джимми: Добрый день, Дон. Можно пройти? Я бы хотел немного поговорить.
- Дон: Хм. Мы же только недавно разговаривали. Что именно вам нужно?
- Джимми: Дон, я хочу задать пару вопросов о вашей жене.
- Дон: Что? При чем здесь Мэри?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Успокойтесь. Я не предъявляю вам никаких обвинений, но мне нужно знать некоторые детали.", 2450, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У меня есть все основания подозревать, что вы причастны к ее пропаже.", 2460, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2445, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Ну ладно. Что именно вы хотите услышать?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2470, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2450, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Да что вы говорите? Вы опоздали, с меня давно уже сняли все обвинения. И это все, что вы хотели мне сказать?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2470, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2460, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Дон, как у вас складывались отношения с Мэри? Вы часто ругались?
- Дон: Я думаю, что это не ваше дело. Но я вижу, вы просто так не уйдете. У нас были хорошие отношения и мы любили друг друга. В каждой семье бывают какие-то проблемы и у нас они были. Ничего особенного.
- Джимми: Вы не замечали в поведении Мэри какие-то изменения в последнее время перед ее исчезновением?
- Дон: Да нет. Все было как обычно.
- Джимми: Дон, я извиняюсь за деликатный вопрос, но вы не были в курсе, возможно у нее были с кем-то отношения, кроме вас?
- Дон: Что за бред? Еще одна такая шуточка и я выбью тебе зубы.
- Джимми: Кстати, а как давно это было?
- Дон: Семь лет назад.
- Джимми: В прошлый раз вы говорили, что видели Карла всего пару раз. Вы общались с ним о чем-нибудь?
- Дон: Нет. О чем можно общаться с двенадцатилетнем пацаном?
- Джимми: Карл был самым близким другом Нейта, а вы с ним даже ни разу не общались?
- Дон: И что с того? К чему все эти странные вопросы. Я не буду на них отвечать.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Отвечать на них в ваших интересах. Я скажу прямо - бесследная пропажа вашей жены, а теперь и лучшего друга вашего сына - дает нам все основания подозревать вас.", 2480, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Ответы на мои вопросы будут считаться содействием следствию, что будет вам большим плюсом. Только вы сами можете снять с себя подозрения. Ведь согласитесь - бесследная пропажа вашей жены, а затем и лучшего друга вашего сына - это весьма странно.", 2480, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2470, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Ого, как интересно. То есть меня уже подозревают? И на каком же основании?
- Джимми: Второй раз в вашем окружении пропадает человек. Вы не идете на контакт со следствием. Вы считаете, что в этой ситуации мы не должны ничего предпринимать?
- Дон: То есть вы всерьез считаете, что я похитил Карла? И зачем мне это, позвольте спросить?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Да, я считаю это вполне возможным. Вы могли не любить Карла, потому что ваш сын проводил все свое время с ним.", 2490, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я так не считаю, потому что пока не вижу в чем может быть ваш мотив. Но нежелание сотрудничать с полицией в любом случае не идет вам на пользу.", 2500, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2480, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Большей чепухи в жизни не слышал. Что мне с того, что они проводили много времени вместе? У меня своих забот по горло.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2490, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Потому что у меня нет и не может быть никакого мотива. Что мне с того, что они проводили много времени вместе? У меня своих забот по горло.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2500, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: А что вы делали в день пропажи Карла?
- Дон: Меня уже спрашивали об этом. Я был дома.
- Джимми: Это может подтвердить только Нейт?
- Дон: Естественно. Кто еще? Мы живем вдвоем.
- Джимми: Возможно мне переговорить с Нейтом?
- Дон: Ладно. Только не задавайте ему этих скользких вопросов. Он у себя в комнате.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2520, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(97, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2510, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Нейт сидел за компьютером и играл в игру. Когда Джимми вошел в комнату, Нейт не обернулся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2525, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2520, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Нейт? Мне нужно с тобой поговорить.
- Нейт: А что такое? Я вообще то занят.
- Джимми: Не переживай, я скоро уйду. Нейт, ты хорошо помнишь свою маму?
- Нейт: Не очень. Мне тогда было лет шесть.
- Джимми: Они часто ссорились с отцом?
- Нейт: Честно говоря - да, очень часто. Это было ужасно.
- Джимми: А твоя мама хорошо к тебе относилась?
- Нейт: Нет, ей не было дела до меня, так-же как и отцу.
- Джимми: А тебе интересно, что случилось с твоей мамой?
- Нейт: Нет, не интересно.
- Джимми: А твой отец что-нибудь тебе рассказывал о ней?
- Нейт: Нет. Он вообще о ней никогда и ничего мне не говорил.
- Джимми: Нейт, а кто из вас лучше учился - ты или Карл?
- Нейт: Карл. Я ненавижу школу.
- Джимми: Почему? У тебя есть еще друзья в классе, кроме Карла?
- Нейт: Нет.
- Джимми: А в спорте Карл тоже больше преуспевал, чем ты?
- Нейт: Откуда вы это знаете? У Карла просто лучше условия, чем у меня. Я иногда пропускаю секцию целыми месяцами, потому что отец не дает на нее денег.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Нейт, скажи честно. Ты немного завидовал Карлу?", 2530, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(95, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(99, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Не падай духом, Нейт. Наверное у твоего отца просто иногда бывают финансовые трудности.", 2540, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2525, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Нет, с чего бы это мне ему завидовать? Мы друзья.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2550, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2530, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Да уж. Что-то слишком часто у него бывают эти трудности.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2550, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2540, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: А почему в тот день Карл пошел в лес один? Он не звал тебя с собой?
- Нейт: Звал. Но я решил остаться дома, поиграть в компьютер.
- Джимми: Карл ходил в лес тренироваться?
- Нейт: Да, он ходил на трассу, где у нас обычно проходят соревнования по ориентированию.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Хорошо Нейт. Удачи тебе.", 2570, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Нейт, почему я не вижу у тебя желания, чтобы Карл быстрее нашелся?", 2560, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2550, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Мало ли, что вы видите. Лучше делайте свою работу и найдите Карла.";
        locationEntity.passageList.Add(new PassageEntity("Джимми: Ладно Нейт, мне пора идти.", 2570, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.NeitRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2560, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми вышел из дома Уисли. Голова была заполнена мыслями. С семьей Уисли все куда сложнее и проблематичнее, чем можно было подумать. Виновен ли Дон в исчезновении Мэри Уисли? Если да, то возможно и пропажа Карла на его совести? Знает ли что-то Нейт? Необходимо найти ответы на все эти вопросы.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2575, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(96, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 2578, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(96, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2570, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"В процессе напряженного мышления Джимми не заметил, как страшно проголодался. Поехать в кафе и перекусить было совсем неплохой идеей.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2580, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2575, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми решил, что все эти тайны, связанные с Доном Уисли нужно обсудить со Стерлингом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2360, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Front;
        locationDictionary.Add(2578, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Людей в кафе практически не было. Джимми сел за столик у окна и постарался расслабиться и ни о чем не думать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2585, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2580, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Здравствуйте, мистер Хаксли! Как продвигается расследование? Есть какие-нибудь новости?
- Джимми: Добрый день, Лиза. На самом деле, все продвигается не так хорошо, как хотелось бы. Я узнал за эти дни много необычных и интересных деталей, но связано ли это все с пропажей Карла или нет я пока точно понять не в силах.
- Лиза: Ничего, не отчаивайтесь. Я уверена, что рано или поздно вы найдете что-то, что даст вам ответ на ваши вопросы.
- Джимми: Очень надеюсь на это. Лиза, а ты знаешь семью Уисли? Дона и Нейта?
- Лиза: Немного. Я была раньше знакомы с Мэри - женой Дона. Мы раньше жили по соседству, до того, как она переехала жить к Дону. Но и после этого мы иногда общались. Хотя она была значительно старше меня, она доверяла мне и считала своей подругой. А потом она пропала.
- Джимми: Что Мэри рассказывала об их отношениях с Доном? У них были какие-то серьезные проблемы?
- Лиза: В начале у них было все хорошо. Но идиллия быстро разрушилась. Они родили ребенка и были не готовы к этому. Дон стал часто выпивать, а Мэри любила гулять со своими старыми друзьями, в том числе и мужчинами. Дон ее очень сильно ревновал. На этой почве у них случались постоянные скандалы.
- Джимми: А что ты можешь сказать о Мэри? Какой она была?
- Лиза: Она была хорошей девушкой. Но немного несерьезной. Она не была готова к семье и ребенку, но тем не менее вышла замуж за Дона. Она иногда рассказывала о том, что ей интересны другие мужчины. Насколько я помню, за пару месяцев до своего исчезновения, она рассказывала о том, что ходила на свидание с каким-то парнем. Естественно в тайне от Дона.
- Джимми: А Дон знал об этом?
- Лиза: Этого я точно не знаю.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Возможно, Мэри просто не успела поделиться с тобой своими мыслями на этот счет.", 2590, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Лиза, спасибо за информацию, но мне кажется ты что-то не договариваешь.", 2600, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2585, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Боюсь, что возможно так оно и было. По правде говоря, Дон это очень неприятный и даже страшный человек. Я не понимаю, как он смог выйти сухим из воды.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2610, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2590, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: От вас ничего не утаишь. Да, Мэри незадолго до своего исчезновения поделилась со мной, что Дон подозревает ее в измене. Честно говоря, я мало кому об этом рассказывала. Даже не знаю почему. Возможно потому, что боюсь Дона. Дон это очень неприятный и даже страшный человек. Я не понимаю, как он смог выйти сухим из воды.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2610, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(95, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(100, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2600, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Как ты считаешь, Дон смог бы пойти на такое преступление, как похищение ребенка?
- Лиза: Вы про Карла? Честно - не знаю. Возможно я слишком преувеличиваю злодеяния Дона. В любом случае, я очень мало о нем знаю. Все таки не хочется верить, что он способен на такое.
- Джимми: Ладно Лиза, мне пора. Спасибо за информацию. Отличный кофе!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2620, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(95, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(102, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2610, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Незаметно наступил вечер. На улице резко похолодало. К тому же, задул холодный  пронизывающий ветер. Джимми подумал о том, что на сегодня разъездов хватит и решил поехать в отель.";
        locationEntity.passageList.Add(new PassageEntity("Вернуться в отель.", 2630, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2620, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Вечером Джимми смотрел телевизор и смеялся над юмористическим шоу. Он постарался на время выкинуть из головы все, что касается расследования. В его практике не раз случалось, что какие-то важные озарения приходили сами, без лишних усилий с его стороны. Нужно было просто расслабиться и очистить разум от шума мыслей.
Перед сном Джимми открыл свою записную книжку. Перед его взором предстали следующие записи, сделанные за день.";
        locationEntity.passageList.Add(new PassageEntity("Смотреть записи.", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2630, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Таинственное исчезновение Мэри Уисли.", 2650, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(98, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Некоторая зависть в поведении Нейта по отношению к Карлу.", 2660, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(99, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Подозрение Дона к Мэри.", 2670, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(100, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Странное доверие Стерлинга к Дону.", 2680, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(101, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отношения Мэри Уисли, о которых не знал Дон.", 2690, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(102, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение записей и лечь спать.", 2700, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2640, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Выяснилось, что Дон не развелся со своей женой, а она таинственным образом исчезла. Ее судьба до сих пор не известна. Полиция не нашла доказательств причастия Дона к пропаже Мэри.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2650, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"В разговоре с Нейтом Джимми не увидел сильного расстройства и переживаний Нейта из-за пропажи Карла. Джимми показалось, что Нейт завидует, что у Карла более хорошие условия для учебы и занятий спорта, чем у Нейта.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2660, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Лиза сказала о том, что Дон возможно знал об отношениях Мэри на стороне. Могло ли это явиться причиной исчезновения Мэри?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2670, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"После исчезновения Мэри Дон должен был являться главным подозреваемым. Ведь у него был серьезный мотив для преступления. Но Стерлинг достаточно быстро снял подозрения с Дона, в виду его не слишком сильного алиби. Это недоработка или есть какой-то умысел?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2680, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"По всей видимости, у Дона были серьезные причины для ревности к Мэри. Мэри была общительной, у нее было много друзей мужчин и она была довольно легкомысленной. Мэри призналась Лизе, что ходила на свидание с мужчиной в тайне от Дона. Осталось ли это тайной для него?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2640, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(2690, locationEntity);
        #endregion
        #region Day 5
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Пятница, 1 октября.
Старый друг.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2710, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2700, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми проснулся от звонка на мобильный телефон. Неохотно встав с кровати, Джимми взял трубку.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2715, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2710, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Алло?
- Стерлинг: Доброе утро, Джимми. Я вас разбудил?
Джимми кинул взгляд на часы и увидел, что уже шел десятый час.
- Джимми: Да нет, мистер Хансон. Что-то случилось?
- Стерлинг: Да. Неприятные новости. У нас труп.
- Джимми: Кого-то убили?
- Стерлинг: Утром был найден труп Альфреда Стоуна. Он лежал на дне оврага, рядом с крутым склоном. Соседи Альфреда говорят, что он всегда совершал ранним утром прогулку, маршрут всегда проходил мимо этого оврага.
- Джимми: Это убийство или несчастный случай?
- Стерлинг: Пока не ясно. На месте сейчас работает Джонсон. Он склоняется к версии, что Альфреду стало плохо и он потерял сознание. К несчастью, Альфред в это время проходил мимо этого оврага. На теле находятся повреждения, которые могли образоваться только от удара при падении. Лечащий врач Альфреда сказал, что у него уже давно серьезные проблемы с сердцем.
- Джимми: Как-то все это слишком просто, не находите что слишком много обстоятельств совпало? Я не верю в такие случайности.
- Стерлинг: К сожалению, неприятности с сердцем часто происходят в самый неподходящий момент. Да и кому нужно было убивать этого старика?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Конечно это маловероятно, но возможно есть человек, которому очень даже выгодна смерть Альфреда.", 2720, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это очень удобная версия, ведь в таком случае нам не придется особенно напрягаться, верно мистер Хансон?", 2730, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2715, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да? И что же это за человек?
- Джимми: Когда Альфред упомянул о том, что видел Стефана, он также сказал, что в машине сидел второй человек.
- Стерлинг: Да. Но каким образом этот человек мог узнать об Альфреде? Если конечно Альфред не стал болтать об этом на каждом углу. В полицейском участке он говорил, что больше никому об этом рассказывал, кроме вас и своего друга Ральфа Вигса.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2740, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2720, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Жаль, что вы так думаете. Мы полагаем, что это был несчастный случай по причине проблем со здоровьем Альфреда. И пока у нас нет реального мотива - нет человека, кому нужна была смерть безобидного пенсионера.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2740, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(115, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2730, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Джонсон еще работает на месте происшествия?
- Стерлинг: Да, он будет там до обеда.
- Джимми: Хорошо, я туда сейчас отправлюсь. До связи, мистер Хансон.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2750, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2740, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми присел на кровать и крепко задумался. Ему тут же вспомнился недавний сон. Второй раз в его жизни этот сон стал вестником печального происшествия.
Может быть это и правда был несчастный случай? У Джимми были весьма серьезные сомнения по этому поводу. Кто был тот второй человек, которого Альфред видел со Стефаном?
Джимми решил действовать.";
        locationEntity.passageList.Add(new PassageEntity("Отправиться на место происшествия.", 2760, 0));
        locationEntity.passageList.Add(new PassageEntity("Поехать к Ральфу Вигсу.", 2810, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(2750, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми проехал мимо дома Альфреда. Он припарковал машину и пошел по направлению к лесу, как это ежедневно делал Альфред. Вскоре Джимми увидел полицейскую машину и нескольких человек в полицейской форме.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2765, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2760, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Привет, Джонсон. Что удалось узнать?
- Джонсон: Добрый день. Хотя конечно, не такой уж он и добрый. Мы разговаривали с соседями Альфреда. Все единогласно заявили о том, что Альфред ежедневно с утра совершал прогулки мимо этого оврага. Сегодня с утра его видел сосед - мистер Стивенсон.
Мы созванивались с лечащим врачом Альфреда мистером Брауном. Он рассказал о том, что у Альфреда уже несколько лет проблемы с сердцем. Следов борьбы на его теле не обнаружено. Никаких посторонних следов рядом, кроме следов Альфреда. По всей видимости бедолаге стало плохо, он упал и скатился в овраг. Мы посовещались со Стерлингом и решили выдвинуть официальную версию, что произошел несчастный случай.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Джонсон, тебя не смущает, что возможно существует человек, которому смерть Альфреда просто необходима?", 2770, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(116, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Похоже действительно ничего не указывает на то, что тут есть место для криминальной версии.", 2780, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2765, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Но кто же это может быть?
- Джимми: Человек, который ехал в машине со Стефаном Кнайтом.
- Джонсон: Я не думаю, что у нас есть серьезные основания полагать, что Стефан и правда в городе. Его никто не видел кроме Альфреда, а ему могло просто показаться. Ему было не мало лет и могло подвести зрение. Скорее всего, Стефан навсегда притаился где-то в далеком уголке земного шара.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Джонсон, почему ты так категорически отвергаешь возможность возвращения Стефана? Только недавно его видел Альфред и вот он уже лежит в овраге. Тебе не кажется это странным?", 2780, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(117, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Звучит разумно. На месте Стефана я бы поступил именно так.", 2790, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2770, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Да, это безусловно странно. Но я полицейский и привык полагаться на факты, а не на эмоции. Пока у нас нет фактов, которые подтверждают возвращение Стефана. Если бы этот ублюдок и правда был здесь, я бы так спокойно тут не стоял.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2790, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2780, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Кто обнаружил труп Альфреда?
- Джонсон: Его сосед мистер Браун. Обычно Альфред возвращался с прогулки в 7:30 утра, но до 8:30 утра он так и не пришел. Мистер Браун пошел проверить - не случилось ли чего. И нашел Альфреда в овраге.
- Джимми: Ладно Джонсон, я поеду.
- Джонсон: Да, мы тоже выезжаем. Пожалуй, больше мы тут ничего не добьемся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2800, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(114, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2790, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поехать к Ральфу Вигсу.", 2810, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(113, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Эдвардом Мартоном.", 2880, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(113, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(114, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.KillerPlace;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2800, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Еще чего не хватало. Я не болтун. Да и рассказывать мне особо некому. В основном я весь день сижу в этой комнате и смотрю телевизор.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2815, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2810, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Здравствуйте, мистер Вигс.
- Ральф: О, здравствуйте, мистер Хаксли. У вас не очень хорошие новости? Что-то случилось с Альфредом?
- Джимми: Но... Откуда вы знаете?
- Ральф: Я давно живу на этом свете. Некоторые вещи я научился чувствовать заранее. Бедняга Альфред... Что произошло?
- Джимми: Его нашли сегодня утром в овраге неподалеку от дома. Он был мертв.
- Ральф: Какой ужас... Его убили. Я так и знал, что ему не нужно было соваться во все это. Но... Уже ничего не изменить.
- Джимми: Простите, во что ему не нужно было соваться?
- Ральф: Он подозревал, что Генри Мартон ответственен за распространение наркотиков в Лонлифарме. Он ответственен за преступление, совершенное Стефаном Кнайтом. Альфред рассказывал, что он что-то вынюхивал на территории завода. И его заметил этот помощник Генри - Майк кажется. Наверняка, Майк что-то заподозрил и рассказал об этом Генри.
- Джимми: Вы считаете, что Альфред представлял для них такую серьезную угрозу, что они решились на убийство?
- Ральф: Мы не знаем, что действительно узнал Альфред. Возможно он что-то выяснил, но побоялся об этом говорить раньше времени. А теперь уже поздно...
- Джимми: Он вам звонил в последнее время?
- Ральф: Да, он набирал мне пару дней назад. Все пытался вспомнить, кого он видел в машине рядом со Стефаном. Теперь похоже он унесет этот секрет с собой. Что слышно о Стефане, его не нашли?
- Джимми: Нет. Есть ли какая-либо связь между Альфредом и Стефаном?  Мог ли он убить Альфреда?
- Ральф: Черт, понятия не имею. Я думаю едва ли. Если только Стефан каким-то образом узнал, что Альфред узнал о его возвращении... Но Альфред уверял, что никому больше об этом не говорил кроме меня, полиции и вас, мистер Хаксли.";
        locationEntity.passageList.Add(new PassageEntity("Возможно вы взболтнули лишнего и кому-то еще об этом рассказали?", 2820, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(10, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("В таком случае, вероятность, что Стефан мог об этом узнать минимальна.", 2830, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(10, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2815, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Еще чего не хватало. Я не болтун. Да и рассказывать мне особо некому. В основном я весь день сижу в этой комнате и смотрю телевизор.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2840, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2820, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Да, но все же я бы не сбрасывал со счетов эту возможность. Если Стефан уже месяц в Лонлифарме и он так и никому не попался на глаза, то от него можно ожидать все что угодно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2840, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2830, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: А что с этим Эдвардом Рэдли? Они были друзья с Альфредом?
- Ральф: Да. Эдвард много лет работал директором дереводобывающего завода и он очень ценил Альфреда. Со временем у них завязались дружеские отношения. Для Эдварда это будет большая потеря, как и для меня.
- Джимми: Мне пора идти. Ральф, примите от меня самые глубокие соболезнования. Я сделаю все, что в моих силах, чтобы узнать, что стало причиной гибели Альфреда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2850, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(113, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2840, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"На выходе из дома престарелых Джимми решил задать вопрос дежурному.
- Джимми: Постояльцы вашего заведения могут свободно покидать территорию?
- Грег: Не совсем. Нужно согласовать день и время с заведующим.
- Джимми: А можно ли посмотреть, выходил ли Ральф Вигс сегодня куда-нибудь?
- Грег: Да, пожалуй что можно. У меня есть график. Так, сейчас посмотрим. Да, Ральф Вигс покидал территорию с семи утра до одиннадцати дня.
- Джимми: Спасибо большое.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2860, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(118, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2850, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Интересно, куда это отправился Ральф в то время, когда погиб Альфред? Довольно странное совпадение, учитывая что Ральф покидает территорию заведения довольно редко.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2870, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2860, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Отправиться на место происшествия.", 2760, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(113, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Эдвардом Рэдли.", 2880, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(113, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(114, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(2870, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми постучался в дверь Эдварда Рэдли.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2885, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2880, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, мистер Мартон. У меня новости.
- Эдвард: Здравствуйте, мистер Хаксли. Что-то стряслось?
- Джимми: Да. Погиб Альфред Стоун.
- Эдвард: Что? Не может быть. Что с ним случилось?
- Джимми: Его нашли сегодня утром в овраге, недалеко от его дома. С ним что-то случилось во время утренней прогулки.
- Эдвард: Что-то с сердцем? Я знаю, что у него было слабое сердце...
- Джимми: Пока не известно. Возможно, что его убили.
- Эдвард: Что? Но кому мог помешать Альфред? Он был совершенно безобидным пожилым человеком.
- Джимми: У вас нет мыслей, что Альфред мог что-то узнать про Генри Мартона?
- Эдвард: Да, Альфред очень сильно подозревал этого Генри. И не зря. Мне он рассказывал, что он недавно был на территории завода. Неужели он увидел там что-то, что не должен был видеть?
- Джимми: Как вы считаете, Генри мог пойти на убийство?
- Эдвард: Возможно. Когда-то он и мне угрожал, как вы знаете.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Да. Вам повезло значительно больше, чем Альфреду.", 2890, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Мне кажется вы знаете об этом Генри что-то еще, но по каким-то причинам не хотите рассказывать.", 2900, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2885, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Бедный Альфред. Конечно, тогда я действительно испугался Генри Мартона. Но я все же всерьез не мог поверить, что он может воплотить свои угрозы в жизнь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2910, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2890, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Я хотел бы знать о нем больше, но к сожалению я знаю о нем крайне мало. Он человек с темным прошлым, которое скрывает. В любом случае, я уже отошел от дел и мне незачем лезть во все это.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2910, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2900, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: По всей видимости, вы не единственный кто видел того странного человека - Бена. Несколько людей с завода встречали в лесу какого-то человека, похожего на бродягу.
- Эдвард: Да, он действительно похож на бродягу. Он был не брит, на нем была старая и потертая одежда. А что, если он живет в лесу?
- Джимми: Это вполне возможно.
- Эдвард: Вы говорили, что на том рисунке было написано слово ""Бен""? А вдруг этот человек похитил Карла? Я пожалуй поступлю следующим образом. Я сегодня отправлюсь на завод, многие там меня хорошо помнят и уважают. Я порасспрашиваю об этом загадочном господине. Может быть, мы натолкнемся на что-нибудь интересное.
- Джимми: Спасибо, было бы отлично.Только будьте осторожны.Опасайтесь Генри, от него можно ждать всего, что угодно.
- Эдвард: Да.Я буду осторожен.Удачи вам, мистер Хаксли.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2920, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2910, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми не оставляло ощущение, что произошедшее с Альфредом - это не просто несчастный случай. Он мог кому-то мешать. Но кому именно?
Альфред недавно пытался что-то найти на территории завода. Может он действительно узнал то, что не предназначено для посторонних? Пожалуй, пришло время вновь навестить Генри Мартона.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2930, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2920, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"В этот раз Джимми пришлось подождать. Около часа Джимми сидел в приемной в ожидании, когда Генри освободиться. Наконец, к нему подошел Майк.
- Майк: Мистер Хаксли, Генри вас ожидает, пройдемте.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2940, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2930, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Добрый день, мистер Хаксли. Чем могу быть полезен в этот раз?
- Джимми: Добрый день, мистер Мартон. Скажите, вы знали Альфреда Стоуна? Он раньше работал на заводе, но потом ушел на пенсию.
- Генри: Да, я припоминаю... Он не хотел уходить на пенсию и все грозился подать на нас в суд. Но у нас кадровая политика сильно изменилась, мы отдаем приоритет молодым работникам.
- Джимми: Альфред на днях приходил на завод, вы знали об этом?
- Генри: Да, мне говорил об этом Майк. Кажется, он что-то хотел уточнить по поводу пенсии. А к чему все эти вопросы по поводу Альфреда?
- Джимми: Дело в том, что сегодня утром его обнаружили в овраге рядом с домом. Он погиб.
- Генри: Это печально. Но чем я могу помочь?";
        locationEntity.passageList.Add(new PassageEntity("Возможно вы знаете, были ли у Альфреда недоброжелатели среди работников завода?", 2950, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я скажу прямо. Альфред приходил на завод с целью поиска доказательств причастия вас к распространению наркотиков в городе. После этого через несколько дней он найден мертвым.", 2960, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2940, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Альфред проработал при мне не так долго. Я обычно не интересуюсь взаимоотношениями подчиненных, это их личное дело. Я ни о чем таком не слышал.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2970, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2950, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Так вот в чем дело. Зря терял время. Мы уже устали от этого нелепого слуха. Сказать по правде - у меня довольно много дел, помимо того, чтобы охотиться за этим несчастным стариком.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 2970, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2960, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: А где вы были сегодня утром - между семью и девятью часами утра?
- Генри: До восьми я был дома. Затем я приехал в офис. Это может подтвердить множество людей.
- Джимми: А ваш помощник Майк?
- Генри: Аналогично. Он был дома со своей семьей. К девяти часам он приехал в офис. Вы всерьез полагаете, что старика убил я или Майк?
- Джимми: Это моя работа. Я должен учитывать все возможные варианты.
- Генри: Я вам искренне советую искать виновного где-нибудь в другом месте. Здесь вы просто теряете времени. Кстати, что там слышно про Стефана?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Почему вас так волнует Стефан? Он имеет какое-то к вам отношение?", 2980, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(119, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Пока ничего. Альфред был единственным свидетелем, который видел Стефана.", 2990, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2970, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Ко мне? Что за глупости, конечно же нет. Просто интересно, вся эта история про него весьма любопытна.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3000, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2980, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Получается, что теперь не удастся установить, что за человек ехал со Стефаном?
- Джимми: Мы будем искать другие способы, чтобы установить это.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3000, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(2990, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо за уделенное время, мне пора.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3010, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3000, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми вышел из офисного центра в немного подавленном настроении. Он чувствовал, что Генри Мартон тем или иным образом, но связан с этим делом. Только как именно? Пока у Джимми не было зацепок и подходов к Генри.
Генри подумал о том, что недалеко от дома Альфреда располагалась заправка, где работал Даниэль. Возможно он что-то видел? Да и заправиться сейчас точно не помешает.";
        locationEntity.passageList.Add(new PassageEntity("Поехать на заправку.", 3020, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3010, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к свободной колонке. Вскоре к нему подскочил Даниэль.";
        locationEntity.passageList.Add(new PassageEntity("Поехать на заправку.", 3025, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3020, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: О, это снова вы, мистер Хаксли! Наверное, вы уже ищите убийцу Альфреда Стоуна?
- Джимми: Откуда ты об этом знаешь? И с чего ты решил, что это убийство?
- Даниэль: Недавно приезжал заправляться Джонсон Купер из полицейского участка. Он сказал, что произошел несчастный случай - Альфреду Стоуну стало плохо и он упал в овраг. Но я сразу смекнул, что здесь дело не чисто. Этим полицейским лишь бы ничего не расследовать.
- Джимми: И кто по твоему мог его убить?
- Даниэль: Конечно же это был Стефан Кнайт. Альфред же его видел и узнал. Альфред видел и другого человека, который был за рулем. Пока Альфред не вспомнил, Стефан его и решил пришить.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("По моим сведениям, ты никак не мог это знать. Поэтому вопрос - как к тебе попала эта информация?", 3030, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я не удивлен, что ты владеешь информацией, которой владеть не должен. Но откуда Стефан мог узнать о том, что Альфред его опознал?", 3040, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3025, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Эээ... Мне рассказала об этом Анна из полицейского участка. Она заправляет здесь машину и мы частенько болтаем. А что, она рассказала что-то лишнее?
- Джимми: Так вот оказывается, кто у нас информатор. Эти девушки никогда не умею держать язык за зубами.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3050, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3030, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Хороший вопрос. По всей видимости до него просто дошли слухи об этом. В нашем маленьком скучном городке трудно что-то сохранить в секрете.
- Джимми: А ты еще об этом кому-нибудь рассказывал?
- Даниэль: Нет, мистер! Больше никому.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3050, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3040, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Даниэль, тебе от сюда отлично виден поворот на Гастингс Стрит. Ты сегодня работаешь с утра? Случайно не видел никого подозрительного, кто бы перемещался по направлению к дому Альфреда между половиной седьмого и половиной восьмого утра?
- Даниэль: Да, я сегодня работаю с шести утра. Так, надо подумать... Кажется, сегодня с самого утра туда поехала скорая помощь. Затем прошел человек, вроде бы это был мистер Вельман, он живет там неподалеку. Затем проехала полицейская машина. Видимо утренний патруль. А затем прошел... Да, кажется это был Ральф Вигс.
- Джимми: Ральф Вигс? Ты уверен, что это был точно он?
- Даниэль: Да... Эта сутулая спина, небольшой рост - это точно был Ральф.
- Джимми: Даниэль, спасибо. Это весьма интересно. Уже вечереет, пора по домам.
- Даниэль: Да, моя смена заканчивается через пол часа! До свидания!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3060, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(112, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(120, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3050, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Это был довольно странный день. Кому помешал этот безобидный старый человек?
Джимми решил, что на сегодня мучительных раздумий достаточно и принял решение отправиться в свой номер.";
        locationEntity.passageList.Add(new PassageEntity("Поехать в отель.", 3065, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3060, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"После дождливого и прохладного дня очутиться в теплом номере на широкой мягкой кровати с бокалом крепкого черного чая было одно удовольствие.
На какое-то время все мысли, связанные с расследованием, улетучились из головы Джимми и он погрузился в приятную полудремоту. Но через какое-то время он пришел в себя и решил, что спать еще рановато.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3070, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3065, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Почитать газету.", 3071, 0));
        locationEntity.passageList.Add(new PassageEntity("Изучить записную книжку.", 3072, 0));
        locationEntity.passageList.Add(new PassageEntity("Лечь спать.", 3100, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3070, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"В газете уже успели написать статью о гибели Альфреда Стоуна. В качестве причины гибели приводится официальная версия полиции. Никакого намека на возможный криминал.
Также в этой статье напечатали довольно объемную биографию Альфреда. Альфред был достойным и трудолюбивым человеком. Он считался одним из лучших работников завода - он работал в нем с первого дня его существования. Автор статьи искренне соболезнует об утрате.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3070, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3071, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Вот, что записал Джимми за сегодняшний день:";
        locationEntity.passageList.Add(new PassageEntity("Отказ Стерлинга начать расследование.", 3074, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(115, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отрицание Джонсоном возможной криминальной составляющей гибели Альфреда.", 3076, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(116, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отрицание Джонсоном возможности возвращения Стефана.", 3078, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(117, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отсутствие Ральфа в доме престарелых в момент гибели Альфреда.", 3080, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(118, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Непонятный интерес Генри к личности Стефана.", 3082, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(119, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Даниэль утверждает, что видел утром Ральфа на Гастингс Стрит.", 3084, 0));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(120, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение.", 3070, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3072, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Несмотря на то, что существуют серьезные основания для того, чтобы начать расследование, Стерлинг не принимает доводов и классифицирует случившееся как несчастный случай.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3074, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джонсон осмотрел место происшествия и принял однозначное решение о том, что это несчастный случай. Он упустил из вида то, что есть лица, которые заинтересованы в смерти Альфреда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3076, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Несмотря на то, что Альфред убедительно утверждал, что видел Стефана, Джонсон по прежнему не верит в эту возможность и списывает все на слабость зрения Альфреда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3078, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Ральф крайне редко покидает территорию дома престарелых. Но в момент гибели Альфреда, его там не было. Где же он был?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3080, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Как утверждает Генри, он не знал Стефана. Но откуда этот непонятный интерес Генри к Стефану? Это чистое любопытство или что-то другое?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3082, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Даниэль утверждает, что видел как утром Ральф шел по Гастингс Стрит по направлению к дому Альфреда. Что ему там понадобилось в столь ранний час?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3072, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(3084, locationEntity);
        #endregion
        #region Day 6
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Суббота, 2 октября.
Новые ответы на старые вопросы.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3110, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.RiverMeditation;
        locationDictionary.Add(3100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми проснулся рано.
За ночь с погодой произошла удивительная трансформация. Бесконечный дождь наконец прекратился, серые тучи разбежались, выглянуло солнце.
Изменение погоды положительно сказалось на настроении Джимми, он подумал о том, что многое в этом непростом деле ему становится более ясным. Но осталось выяснить некоторые важные детали. И найти ответ на главный вопрос, ради которого он здесь находится - где сейчас находится Карл Вигс.
Джимми немного почитал книгу, выпил стакан крепкого черного кофе, оделся и вышел из своего номера. За сегодняшний день предстоит совершить большую работу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.RiverMeditation;
        locationDictionary.Add(3110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Руфусом.", 3130, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(131, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отправиться в полицейский участок.", 3200, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(141, 0, 2, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поехать в дом семьи Вигсов.", 3520, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(142, 0, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Посетить дом семьи Уисли.", 3720, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(145, 0, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поехать в кафе Розали.", 4000, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(147, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Отправиться на заправку.", 4100, 0));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(148, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Ральфом.", 4200, 0));
        locationEntity.passageList[6].parameterEditList.Add(new ParameterEditEntity(150, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Генри Мартоном.", 4300, 0));
        locationEntity.passageList[7].parameterEditList.Add(new ParameterEditEntity(151, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Эдвардом.", 4400, 0));
        locationEntity.passageList[8].parameterEditList.Add(new ParameterEditEntity(153, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Вернуться в отель.", 4500, 0));
        locationEntity.passageList[9].parameterEditList.Add(new ParameterEditEntity(154, 8, 13, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3120, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Руфус, как и всегда, находился в отеле у администраторской стойки.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3135, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, Руфус. Что слышно за последнее время?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3140, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3150, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3135, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Добрый день, мистер Хаксли. Да в общем-то ничего интересного за последние дни не происходило. Постояльцев сейчас мало, работы практически нет.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Добрый день, мистер Хаксли! Я как раз хотел с вами поговорить. Я слышал о том, что Лиана Вигс и Билл получили по почте детский рисунок с надписью ""Бен"". Также работники завода иногда видели в лесу какого-то странного человека, похожего на бродягу. У меня вдруг возникла одна необычная идея...
У нас когда-то давно в городе - лет десять назад, жил один человек по имени Бенджамин Хартон. У него была весьма непростая судьба. Он был обычным военным, затем его отправили участвовать в военных действиях по освобождению Мидлстоуна.
Там он получил серьезное ранение и был контужен. Его вернули домой другим человеком. Он мог часами сидеть в комнате на одном месте и не проронить ни слова. В итоге от него ушла жена. Ему предлагали отправиться жить в специальный интернат. И вроде бы он был не против... Но в последний момент он просто пропал. Он ушел из дома и больше его никто никогда не видел. Полиция сделала вывод, что Бенджамин покончил жизнь самоубийством где-то в лесу, подальше от чьих-либо глаз. На этом все и закончилось. О Бенджамине никто больше не вспоминал.
И я подумал... А что если этот человек, которого видели в лесу и есть Бенджамин Хартон ?!
- Джимми: Это очень занимательная история, Руфус... Если это и правда этот человек, то выходит, что он мог похитить Карла. Необходимо найти его.
- Руфус: Да, но только одному Богу известно, где он может прятаться. Как мне известно, лес хорошо обыскивали, но ничего не нашли.
- Джимми: Вполне возможно, полицейские что-то пропустили. Я поставлю вопрос по привлечению большого поискового отряда к этой задаче, необходимо исследовать весь лес в радиусе нескольких километров.
- Руфус: Да, это отличная мысль.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3160, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(132, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3150, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Руфус, вы говорили, что периодически общаетесь с Доном Уисли. Он когда-нибудь рассказывал о своей жене?
- Руфус: Да, я знаю, что жена Дона бесследно исчезла несколько лет назад. Дон никогда о ней ничего не рассказывает. Я сам не могу спрашивать у него такие вещи, все-таки мы не такие уж и близкие друзья.
- Джимми: Как вы думаете, Дон мог что-то сделать со своей женой?
- Руфус: Я в это не верю. Да, периодически Дон производит впечатление неуравновешенного человека, но я считаю, что он не способен на такое серьезное преступление.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Может быть вы просто не хотите выставлять своего знакомого в невыгодном свете?", 3170, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У меня сложилось аналогичное впечатление о Доне.", 3180, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(0, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3160, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Как я уже говорил, мы не друзья с Доном. Просто мы вместе иногда пересекаемся вечером в баре. Для меня нет смысла умалчивать какую-то информацию о нем.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3190, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Rufus;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3170, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Руфус: Мне кажется, что Дон реально переживает из-за пропажи Мэри до сих пор. Что-то у него изменилось внутри после этого случая. Может быть по этой причине у него возникли проблемы с алкоголем.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3190, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3180, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Раньше у Дона таких проблем не было?
- Руфус: На сколько я знаю - нет.
- Джимми: Ладно Руфус, всего хорошего.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(131, 0, 1, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Hotel;
        locationEntity.PersonTopMenuPanel = SpritesKey.Rufus;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(3190, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми припарковал машину на служебной парковке и вошел внутрь участка.";
        locationEntity.passageList.Add(new PassageEntity("Поговорить со Стерлингом.", 3210, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(135, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Джонсоном.", 3300, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(136, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Анной.", 3440, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(137, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из участка.", 3120, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, мистер Хансон. Есть какие-нибудь новости, связанные с гибелью Альфреда?
- Стерлинг: Добрый день, мистер Хаксли. Гибель Альфреда признана несчастным случаем, мы не стали возбуждать уголовное дело. Джонсон достаточно поработал на месте происшествия и поговорил со знакомыми Альфреда и его врачом - нет повода считать, что тут может быть задействовано какое-то третье лицо.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я так понимаю, на заключении о том, что это несчастный случай настоял именно Джонсон? У вас есть основания полностью доверять ему?", 3220, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Я так понимаю, на заключении о том, что это несчастный случай настоял именно Джонсон? У вас есть основания полностью доверять ему?", 3230, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Я думаю, что в данном случае у вас не было другого выхода.", 3240, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(1, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да, разумеется. В данном случае я полностью согласен с выводом Джонсона.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3240, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3220, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Джонсон зарекомендовал себя как неплохой и ответственный сотрудник. Но сказать честно, данный случай меня немного беспокоит. Джонсон фактически отказался рассматривать какие-либо иные версии. Как мы знаем, возможно у нас имеется некий загадочный человек, который был бы не прочь устранить Альфреда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3240, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3230, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Хансон, а кто занимался расследованием дела Генри Мартона?
- Стерлинг: В основном этим занимался Джонсон. Мы проверили всю документацию завода, навели справки об этом Генри и его предыдущей деятельности. В общем-то ничего подозрительного.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3250, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3240, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("В чем именно заключалась роль Джонсона в расследовании?", 3260, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(1, 0, 14, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("В чем именно заключалась роль Джонсона в расследовании?", 3270, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 15, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3250, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Он общался с Генри Мартоном и его подчиненными, наводил справки о них. Расследование велось под моим контролем, я не думаю, что мы упустили что-то серьезное.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3280, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3260, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Он общался с Генри Мартоном и его подчиненными, наводил справки о них. В расследовании так-же участвовал лейтенант Кэрри. По его данным, в определенное время и в определенном месте должны была состояться сделка по продаже наркотиков. Мы решили проверить эту информацию. Я послал Джонсона на это задание. Джонсон утверждал, что информация оказалась ошибочной. В последнее время, я начал задумываться о том, а не скрыл ли тогда что-то Джонсон? Кэрри утверждает, что информация не может быть ложной. Поэтому тут только два варианта - либо они узнали о нашей операции, либо Джонсон сам как-то замешан в этом деле.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3280, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(133, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3270, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Спасибо, мистер Хансон. У меня больше вопросов нет.", 3200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(132, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(135, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(141, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Мистер Хансон, а вы ничего не помните о Бенджамине Хансоне? Это бывший военный, который исчез несколько лет назад.", 3290, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(132, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3280, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да, я припоминаю это дело... Кажется, это было лет десять назад. Его хотели поселить в интернат, в связи с его психологическими проблемами. Он был практически недееспособен. Но бедолага взял и в последний момент сбежал. Несмотря на все поиски, мы его тогда так и не нашли. Возможно, он утонул в местной реке. А в связи с чем вы это спрашиваете?
- Джимми: Возможно, Бенджамин жив до сих пор. В лесу несколько раз видели странного человека, которого, судя по всему, зовут именно Бенджамин.
- Стерлинг: Это очень интересно и странно. Неужели это тот самый Бенджамин? Если что-то еще узнаете, обязательно дайте мне знать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(135, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(141, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3290, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джонсон сидел в своем кабинете и о чем-то напряженно думал. При виде Джимми он слегка улыбнулся.
- Джонсон: Добрый день, мистер Хаксли! Как поживаете?
- Джимми: Привет, Джонсон. Все было бы ничего, если ни одна маленькая деталь - мы так и не знаем, что случилось с Карлом.
- Джонсон: Да, это печалит. Но мы работаем в полную силу, я уверен, что рано или поздно мы на что-то наткнемся.
- Джимми: Может у тебя появились какие-нибудь предположения в какую сторону нам нужно копать?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3310, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3320, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3300, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Я сначала не воспринял всерьез возможность того, что Стефан Кнайт мог вернуться в Лонлифарм. Возможно эта вероятность слишком шокировала меня. Но теперь я стал думать - а что, если это правда? Возможно исчезновение Карла и гибель Альфреда - это дело рук Стефана. В нашем городе больше никто не способен на такие преступления. Я думаю, мы должны найти Стефана, чего бы нам это не стоило.
- Джимми: Просто отлично. И как ты предлагаешь его искать?
- Джонсон: Возможно, нужно серьезно проверить Анну, нашего секретаря. Я знаю, что они раньше дружили со Стефаном. Я не уверен, но возможно у них были отношения. Я заметил, что в последнее время Анна изменилась. Стала задумчивой и какой-то нервной. Также она стала часто брать отгулы. Возможно, Стефан связался с ней и она знает, где он находится?
- Джимми: А почему ты сам с ней об этом не поговоришь?
- Джонсон: Я думаю, она не скажет мне правды. Почему-то она в последнее время ко мне относится не очень дружелюбно. Никак не пойму, с чем это связано.
- Джимми: Хорошо, я поговорю с ней.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3330, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(134, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3310, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Боюсь, что пока нет. Меня немного выбил этот случай с Альфредом. Хорошо, что мы разобрались в этой ситуации. Теперь вновь сосредоточим все силы на поиске Карла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3330, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3320, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Джонсон, когда по наводке лейтенанта Кэрри ты был на месте предполагаемой сделки, что действительно там было?", 3340, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(133, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Джонсон, как ты участвовал в расследовании дел Генри Мартона?", 3350, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(133, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3330, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: К сожалению, наводка оказалась ошибочной. Никакой сделки в это время и в этом месте не было. Лейтенанту Кэрри не в первые совершать подобные ошибки.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3360, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3340, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Я беседовал с Генри Мартоном и его подчиненными, наводил справки о них. В расследовании так-же участвовал лейтенант Кэрри. По его данным, в определенное время и в определенном месте должны была состояться сделка по продаже наркотиков. Мы решили проверить эту информацию. Меня послали на это задание. Но информация оказалась ошибочной.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3360, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3350, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3370, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3380, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3360, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Я пока не руководитель отдела, я выполняю указания Стерлинга. Мне было поручено проверить только Мартона, больше версий на данный момент нет.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3390, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3370, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Я ломаю над этим голову, но реальных версий пока нет. Мы продолжаем расследование.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3390, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3380, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Джимми: А что если я скажу, что подозреваю, что сделка в тот раз все таки состоялась? И возможно ты всем пудришь голову и решил скрыть это?", 3400, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(2, 0, 5, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Джимми: Нужно проработать разные версии, попробовать зайти с какой-либо другой стороны. У меня ощущение, что тот кто стоит за всей этой историей с наркотикам также замешан и в пропаже Карла.", 3410, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(2, 6, 20, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3390, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Что-что? Я не ослышался? Откуда вы взяли этот бред? Зачем мне это, черт побери? Мистер Хаксли, мне кажется, что мы и так уже достаточно поговорили, у меня много дел.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3420, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3400, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Мне тоже так кажется. Но первое что нам нужно сделать - попробовать отыскать Стефана.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3430, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3410, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ладно Джонсон, но я бы на твоем месте особо не расслаблялся. Подумай получше над ответом на мой вопрос перед нашим следующим разговором.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(136, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(141, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3420, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Хорошо, Джонсон. За работу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(136, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(141, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3430, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Анна с кем-то оживленно болтала по мобильнику и улыбалась.
- Джимми: Привет, Анна. Я вижу у тебя сегодня хорошее настроение?
- Анна: Добрый день, мистер Хаксли! Да, ко мне скоро приезжает родная сестра. Мы не виделись уже три года.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Ты случайно общалась сейчас не со Стефаном?", 3450, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(134, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Это хорошо. Не хочешь мне рассказать что-нибудь новое о Стефане?", 3460, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Отлично, Анна, рад за тебя. Хотя бы у кого-то хорошие новости.", 3470, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(3, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3440, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Конечно нет, что за странный вопрос? Вы подозреваете, что я знаю где сейчас находиться Стефан? Я вас расстрою, но я понятия не имею где он сейчас и жив ли он вобще.
- Джимми: Джонсон сказал, что ты в последнее время стала часто брать отгулы?
- Анна: Какое ему дело до этого? Не так уж и часто. Если вам интересно - у меня были назначены приемы у врача. Можете проверить это в больнице. Лучше узнайте у Джонсона, чем занимается он целыми днями, вместо того, чтобы искать Карла.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3480, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 14, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3455, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 15, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3450, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Анна, у тебя сложные отношения с Джонсоном?
- Анна: Да, это так. Мне кажется, что Джонсон вместо того, чтобы реально заниматься расследованием последних происшествий все время ищет какие-то отмазки. Я конечно не детектив, но я бы всерьез занялась им. Возможно у него есть какие-то свои корыстные интересы.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3480, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3455, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Мистер Хаксли, я не понимаю ваших намеков. Про Стефана я вам уже все рассказала, мы были не такие уж и близкие друзья.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3480, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3460, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Да, спасибо. Лайза - моя сестра - с отличием закончила Юридический факультет Академии Йорк-Сити. Теперь наконец-то она возвращается домой.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3480, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3470, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Анна, меня интересует вопрос - были ли у вас со Стефаном какие-либо близкие отношения?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3490, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(3, 0, 14, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3500, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(3, 15, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3480, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Я сожалею, но это к нашему делу никак не относится. Я уже говорила, что мы были просто друзьями.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3490, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Анна: Если говорить прямо - то нет, мы были просто друзьями. У меня не было в школе друзей, кроме него. Также было и со Стефаном. Думаю, я должна вам сказать нечто важное...
- Джимми: Я весь внимания, Анна.
- Анна: Дело в том... Стефан действительно хотел вернуться в Лонлифарм. Он звонил мне один раз. Сказал, что скучает по родным местам и скоро приедет. Также он спросил, может ли он рассчитывать на меня. Но после этого на связь он больше не выходил.
- Джимми: Когда это было?
- Анна: Где-то полтора месяца назад.
- Джимми: Ты говорила ему, что он был замечен Альфредом?
- Анна: Конечно нет! Я же говорю - он больше не звонил, я не знаю где он. Вы скажете об этом Стерлингу? О том, что я ничего не рассказала?
- Джимми: Пока нет, Анна. Но при условии - если Стефан попытается вновь с тобой связаться, то ты сразу говоришь об этом мне. Не забывай, что он преступник и возможно, что он похитил Карла.
- Анна: Да, я это понимаю. Спасибо, мистер Хаксли.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3510, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(155, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3500, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: До встречи, Анна.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3200, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(137, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(141, 0, 3, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Anna;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(3510, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к дому семьи Вигсов. Внешний вид сада немного изменился не в лучшую сторону - видно, что уже достаточно продолжительное время хозяевам дома не до него.
После небольшой паузы Джимми позвонил в дверь.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3525, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3520, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Добрый день, мистер Хаксли. У вас какие-то новости?
- Джимми: У нас есть определенные подвижки в деле. Но о том, где сейчас находится Карл мы пока точно сказать не можем.
- Лиана: Вы пришли что-то узнать?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3530, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3525, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Лианой.", 3540, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(139, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Биллом.", 3630, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(140, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из дома семьи Вигсов.", 3120, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3530, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: У вас найдется немного свободного времени на меня, миссис Вигс?
- Лиана: Да, сколько угодно.
- Джимми: Ваша семья была знакома со Стефаном Кнайтом?
- Лиана: Что? С этим убийцей? Конечно нет.
- Джимми: Вы исключаете, что Карл мог каким-то образом знаком со Стефаном?
- Лиана: Стефан исчез несколько лет назад! Карл был тогда совсем ребенком. Как они могли знать друг друга? К чему вы клоните?
- Джимми: Мы рассматриваем версию похищения Карла Стефаном. Возможно он вернулся в Лонлифарм.
- Лиана: Просто невероятно. Но зачем ему похищать Карла?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я хотел спросить об этом вас. Если вы интересовались делами сына, то должны нам помочь в этом вопросе.", 3550, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Пока это просто одна из версий. Мы ищем возможный мотив Стефана.", 3560, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3540, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Я все свое время посвящала Карлу. Я надеюсь, что знаю его интересы и круг общения. У него не могло быть никакой связи со Стефаном. Стефан наркоман, возможно ему не нужен какой-то мотив что-бы похитить ребенка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3570, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3550, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Стефан наркоман, возможно ему не нужен какой-то мотив что-бы похитить ребенка.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3570, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3560, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: В сферу моих подозрений так-же попадает Дон Уисли. Вы ничего не знаете про его жену?
- Лиана: Про Мэри? Мы раньше немного общались, все-таки живем по соседству. Но близко я ее не знала. Мне всегда казалось, что у них проблемы с Доном. Вы считаете, что это Дон мог что-то с ней сделать?
- Джимми: Это не исключено. Вы близко знали Дона? Как вы считаете он способен на такой поступок, как похищение ребенка?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3580, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(6, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3590, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(6, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3570, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: В последний год мы довольно часто общались с Доном. Я не хотела об этом говорить, но раз вы подозреваете, что он возможно причастен к пропаже Карла...
Дон иногда заходил к нам, когда Билл был на работе. Он влюблен в меня. Мы просто общались и пили чай. Недавно я ему дала понять, что у меня семья и между нами ничего не может быть. Мне кажется, он был весьма разозлен после этого.
- Джимми: Вы не находите, что это весьма серьезный мотив для мести?
- Лиана: О Боже... Мне никогда не могла придти в голову, что Дон способен на такое... Что теперь делать?
- Джимми: Если это действительно Дон, то он получит по заслугам, будьте уверены.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3600, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(138, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3580, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиана: Нет, мы практически не общались с Доном. Я не могу себе представить, зачем ему похищать нашего Карла. Вроде бы он трудолюбивый и довольно порядочный человек.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3600, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3590, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: У вас нет никаких идей о том, что может обозначать надпись ""Бен"" на рисунке, который вы нашли?
- Лиана: Я давно об этом думаю.У нас нет знакомых с таким именем.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3610, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(132, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3620, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(132, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3600, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вам ничего не говорит имя Бенджамин Хартон?
- Лиана: Боюсь, что нет.
- Джимми: Он бывший военный. После ранения у него возникли психические проблемы. Он исчез в неизвестном направлении лет десять назад.
- Лиана: Когда мы переехали в Лонлифарм я слышала эту историю. Вы считаете он может быть причастен к похищению? Он же давно пропал?
- Джимми: Пока ничего точно сказать не могу. Но мы рассматриваем и этот вариант.
- Лиана: Мистер Хаксли, держите меня в курсе всех событий.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3620, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3610, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо за разговор. Всего хорошего, миссис Вигс.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3530, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(139, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(142, 0, 2, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Liana;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3620, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Билл Вигс смотрел футбол по телевизору и держал в руке бутылку пива.
- Джимми: Мистер Вигс, можно вас на пару вопросов?
- Билл: Конечно, мистер Хаксли! Рад вас видеть.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Я вижу, что вы не слишком обеспокоены пропажей Карла? Вы уже смирились?", 3640, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Футбол? Кто сегодня играет?", 3650, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(5, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3630, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Как вы можете такое говорить? Я просто уже не знаю куда деваться. И выпиваю от бессилия.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3660, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3640, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Да, сегодня полуфинал. «Вествиль» против «Уотфорда».";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3660, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3650, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мы изучаем возможную связь Карла и Стефана Кнайта. Вам есть, что сказать по этому поводу?
- Билл: Кнайт? Это тот ублюдок, который завалил двух копов? Причем здесь Карл?
- Джимми: Есть свидетель, который видел Стефана примерно в то время, когда исчез Карл. Сейчас он мертв.
- Билл: О Господи... Речь идет об Альфреде Стоуне?
- Джимми: Да, совершенно верно.
- Билл: Неужели этому негодяю мало жертв... Поймайте его, я прошу вас, мистер Хаксли.
- Джимми: Как вы относитесь к Дону Уисли?
- Билл: К Дону? Честно говоря, я всегда его недолюбливал. Угрюмый, неразговорчивый тип. К тому же, скорее всего ему наплевать на сына. А при чем тут он?
- Джимми: Мы рассматриваем его причастность к пропаже Карла.
- Билл: Как? Зачем ему это?
- Джимми: Пока еще рано что-то говорить наверняка.
- Билл: Вы думаете, он мог сделать это из-за Нейта? Ему не нравилось, что Нейт дружит с Карлом?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3665, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(138, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3670, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(138, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3660, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мы рассматриваем эту возможность. Учитывая, что жена Дона также пропала при невыясненных обстоятельствах.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3665, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Не только по этой причине. Но пока рано выдвигать предположения, нужно уточнить информацию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3680, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3670, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Вигс, что вам известно о дружбе вашего отца и Альфреда Стоуна?
- Билл: О, они дружат уже лет тридцать. Точнее, дружили. Бедняга Альфред.
- Джимми: Вам не известно о каких-либо разногласиях между ними?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3690, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(5, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3700, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(5, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3680, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Да, пожалуй между ними было серьезное разногласие. Но это было уже давно. Раньше мой отец любил одну девушку - вроде бы ее звали Анастасия. Но жизнь порой не справедлива - в итоге Анастасия стала женой Альфреда. Через пару лет они развелись. Но отец тогда здорово обиделся на Альфреда. Но все это дела давно минувших дней.
- Джимми: Руфус часто вспоминал об этом, как вам кажется?
- Билл: Нет. Я думаю, он уже давно позабыл об этом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3710, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(149, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3690, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Билл: Разногласиях? Нет, насколько я знаю у них всегда было доброе и дружеское общение. Вы что, намекаете на то, что мой отец мог что-то сделать Альфреду? Это же полная глупость.
- Джимми: Я не намекаю ни на что, я пытаюсь получить нужную мне информацию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3710, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3700, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо за уделенное время, мистер Вигс. Увидимся. Надеюсь, что в следующий раз - с хорошими новостями.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3530, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(140, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(142, 0, 2, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.VigsRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Bill;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3710, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми позвонил в дверь дома Дона Уисли и внутренне приготовился к непростому разговору.
Дверь открыл Нейт.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3725, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3720, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Вам что-то нужно?
- Джимми: Привет, Нейт.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3727, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3725, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Нейтом.", 3730, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(144, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Поговорить с Доном.", 3830, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(143, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Выйти из дома Уисли.", 3120, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3727, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Нейт, я хочу тебе задать несколько вопросов. Надеюсь, ты не слишком занят?
- Нейт: Да нет, не особо.
- Джимми: Нейт, может ты помнишь какие-нибудь моменты из-за которых твой отец мог быть сердит на Карла?
- Нейт: Не припоминаю...
- Джимми: Ты точно уверен? Нейт, это очень важно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3740, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3750, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3730, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Ну... Как-то был случай, когда я засиделся у Карла до самой ночи. После того как я пришел домой, отец очень сильно разозлился. И крикнул, что если еще раз я приду домой ночью - он убьет Карла.
- Джимми: Давно это было?
- Нейт: Где-то пару месяцев назад.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3760, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(156, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3740, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Да, уверен. Отец вообще не общался с Карлом.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3760, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3750, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: За все время мама ни разу не пыталась с тобой связаться?
- Нейт: Нет, ни разу.
- Джимми: Отец когда-нибудь выдвигал какие-нибудь предположения по поводу того, куда могла исчезнуть твоя мама?
- Нейт: Однажды, он сказал, что скорее всего мама смоталась в столицу в поисках лучшей жизни.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Нейт, скажи честно, Дон запугивает тебя? Он говорит тебе, что отвечать на подобные вопросы?", 3770, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("У тебя никогда не возникало сомнений по поводу того, что может быть отец говорит тебе не правду?", 3780, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3760, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Нет, он мне никогда ничего такого не говорил. Он вообще со мной редко о чем-либо разговаривает.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3790, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3770, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Да, иногда я и правда не верю ему. Многие мои знакомые говорят, что это отец что-то сделал с мамой.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3790, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3780, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Нейт, как ты считаешь, какой твой отец на самом деле? Он способен на преступление?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3800, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(8, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3810, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(8, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3790, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Я не знаю. Он часто пьет и бывает злым. Но не всегда. Когда он не пьет, он бывает добрым и мы вместе проводим время и разговариваем. Я не верю, что он в чем-то виноват.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3200, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3800, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Нейт: Я не знаю. Он со мной редко общается и что-то рассказывает. Мне кажется, это он виноват в пропаже мамы.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3820, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(157, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3810, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Держись, Нейт. Удачи тебе.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3725, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(144, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(145, 0, 2, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3820, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мне нужно поговорить с Доном. Где он сейчас?
- Нейт: Он в гостиной, смотрит телевизор.
Джимми прошел в гостиную. Дон смотрел какое-то юмористическое шоу. На полу лежало несколько пустых бутылок пива.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3835, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Neit;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3830, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, Дон. Нам нужно поговорить.
- Дон: Это опять вы? Что вам нужно на этот раз?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("У меня есть основания, чтобы подозревать вас в пропаже Карла Вигса.", 3840, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я просто хочу задать несколько вопросов, не кипятитесь так.", 3850, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3835, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Я даже не удивлен. Я уже привык слышать от вас всякий бред. Что еще я сделал?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3850, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 5, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3860, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 6, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3840, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Возможно, вы сделали со своей женой тоже самое, что сделали с Карлом?
- Дон: Ну это уже через чур! Проваливайте из моего дома, чтобы больше я вас тут не видел никогда!
Дон вскочил с дивана и быстро покинул комнату.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3725, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(143, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(145, 0, 2, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3850, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мы пока не знаем, что именно вы сделали. Но мы это выясним. В ваших интересах спокойно поговорить со мной и ответить на все вопросы.
- Дон: Да я же уже на все ответил, что еще вы хотите узнать?
- Джимми: Вы знали, что ваша жена Мэри встречается с другим мужчиной?
- Дон: Что? Это полное вранье! Откуда вам может быть это известно.
- Джимми: Сейчас дело не в этом. То есть, вы утверждаете, что вы никогда не подозревали Мэри в измене?
- Дон: Нет, никогда.
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Есть свидетель, который это опровергает. Вы начали что-то подозревать незадолго до исчезновения Мэри.", 3870, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(100, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Ладно, Дон. Я надеюсь, что в данный момент вы говорите правду.", 3880, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(100, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Если вы сейчас меня обманываете, то дела ваши окажутся совсем плохи. Я бы не хотел оказаться на вашем месте.", 3880, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(100, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3860, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Что же это за таинственный свидетель такой?
- Джимми: Имен мы не называем. Я бы на вашем месте сказал бы правду, что случилось с Мэри на самом деле.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3880, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3870, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Мэри, Мэри... Вы действительно думаете, что это я мог с ней что-то сделать?
- Джимми: У нас нет доказательств на этот счет, но не рассматривать вообще этот вариант мы не можем.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3890, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 14, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 3900, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 15, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3880, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Мой окончательный ответ прост. Я не знаю и никогда не знал, что случилось с Мэри. Узнать, что с ней произошло - это ваше дело. Иначе за что мы платим налоги? 
- Джимми: Ладно, Дон. Я понял вашу позицию.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3910, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3890, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Раз мои дела так плохи... Ну что же, я вынужден сказать это. Я никогда и никому этого не говорил, но дело в том, что... Мэри сбежала от меня. Она работала какое-то время продавцом в магазине. В итоге она уехала с владельцем магазина в другую страну навсегда. Я узнал об этом, когда получил от нее письмо через пару недель.
- Джимми: Но почему вы не рассказали об этом полиции?
- Дон: Это все чертовски ранит мое самолюбие, даже до сих пор. Я думал, что лучше уж сяду, чем все узнают об этом. Но сейчас я вижу, что нужен Нейту.
- Джимми: Дон, вы поступили правильно, что поделились со мной. Это очень поможет нам.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3910, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(146, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3900, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Пожалуй, у меня больше нет вопросов. Надеюсь, что вы сказали мне правду и мне больше не придется вас беспокоить.", 3920, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Дон, я думаю, что это наша не последняя встреча. У вас есть немного времени подумать над своими ответами, чтобы в следующий раз они звучали более убедительно.", 3930, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(7, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Дон, какого рода отношения у вас с Лианой Вигс?", 3940, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3910, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Да, я тоже надеюсь, что это наша последняя встреча.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3950, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3920, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Вы еще не устали? Я уже сказал все, что мог. Можете приходить ко мне домой сколько угодно, но ничего нового вы больше не услышите.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3950, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3930, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Дон: Ну и вопросики у вас. У нас нет никаких отношений. Мы просто приятели, я захожу к ним иногда в гости.
- Джимми: Когда Билла нет дома?
- Дон: Да. С Биллом мы особо не общаемся, он почему-то меня недолюбливает. Нам просто не о чем разговаривать.
- Джимми: Тем не менее, Лиана сомневается, что у вас к ней чисто дружеский интерес. Вы сильно разозлились, когда Лиана сказала, что между вами ничего не может быть.
- Дон: Я тогда выпил лишнего. С кем не бывает? Я уже и забыл про это. Хотя неловко получилось.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3950, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3940, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ладно Дон, мне пора уезжать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3725, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(143, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(145, 0, 2, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.WisliRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Don;
        locationEntity.MusicLocation = AudioKey.Decisions;
        locationDictionary.Add(3950, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подумал о том, что перекусить было бы сейчас очень своевременно. И поехал по направлению к кафе ""Розали"".
В кафе было достаточно многолюдно.Несколько столиков занимали школьники, что-то громко обсуждая и смеясь.
Наконец, к Джимми подошла Лиза.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4005, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4000, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: О, это снова вы, мистер Хаксли? Как продвигается наше расследование?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Привет, Лиза. Может быть сначала предложишь мне меню?", 4010, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Привет! Проясняется много интересных деталей. Возможно, скоро последует какой-то конкретный вывод.", 4020, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(4, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4005, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: О да, конечно, мистер Хаксли. Я извиняюсь, держите меню.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4030, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4010, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Есть надежда, что Карл жив?
- Джимми: К сожалению, это сказать я пока не могу. Я думаю, что надежда есть.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4030, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4020, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Что будете брать?
- Джимми: Хм, непростой выбор. Пожалуй мне стейк из свинины, картофель-фри и черный кофе.
- Лиза: Хорошо, через десять минут будет готово.
- Джимми: А ты лично когда-нибудь общалась с Доном Уисли?
- Лиза: Было пару раз... Но уже давно. Еще до того, как Мэри пропала.
- Джимми: Что можешь сказать о нем?
- Лиза: Трудно составить мнение за такое короткое время, к тому же он был довольно неразговорчив. О Доне я в основном знаю по рассказам Мэри. Я так понимаю, что он резкий, немного нервный и импульсивный человек. Иногда он был агрессивен по отношению к Мэри. 
По словам Мэри, все это пошло у Дона после того, как его уволили с флота. После окончания морского училища он служил в порту Нью-Сеалэнд, но потом у него что-то случилось со здоровьем и ему пришлось уйти со службы. С тех пор он начал злоупотреблять спиртным. 
- Джимми: Мэри не говорила о том, как относится Дон к своему сыну?
- Лиза: Мне казалось, что, к сожалению, и Мэри не была слишком привязана к Нейту. Они не планировали ребенка. Тем не менее, Мэри говорила, что Дон старается заботиться о сыне.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4040, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(4, 0, 12, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4050, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(4, 13, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4030, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: Кстати, я в последнее время много думала о нашем с Мэри общении... И вспомнила, что после одной из ссор с Доном, Мэри мне сказала, что хочет сбежать от него... Возможно, она сказала это просто на эмоциях. Я тогда спросила - а что же будет с Нейтом? Она ничего мне не ответила.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4060, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(146, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4070, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(146, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(158, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4040, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Лиза: У вас больше нет вопросов? А то у меня клиенты.
- Джимми: Нет Лиза, спасибо. До скорого.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4050, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Да, мне Дон решился рассказать о том, что Мэри на самом деле сбежала в другую страну с директором магазина, в котором она работала. Мне показалось, что Дон говорил это достаточно убедительно.
- Лиза: Невероятно... Честно говоря, это очень в духе Мэри. Она была безответственной, что уж тут говорить. Но с другой стороны, хорошо, что с ней все в порядке, а Дон тут не при чем. 
- Джимми: Да, если конечно он не придумал эту историю на ходу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4080, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4060, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ты считаешь, что она была способна на такое? Бросить ребенка?
- Лиза: Нет, но... Честно говоря, это очень в духе Мэри. Она была безответственной, что уж тут говорить. Если она влюбилась в кого-то, то запросто могла забыть обо всем на свете.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4080, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4070, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Спасибо, Лиза, удачного дня. До скорого.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(147, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Cafe;
        locationEntity.PersonTopMenuPanel = SpritesKey.Lisa;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4080, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подъехал к заправке и начал высматривать Даниэля. Даниэль активно бегал от одной машине к другой. Наконец, он подошел к Джимми.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4105, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Добрый день, мистер Хаксли! Как продвигается расследование?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Даниэль, ты как обычно любопытен, но сначала было бы неплохо заправиться.", 4110, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Установлено много важных подробностей, осталось собрать из них общую картину. Возможно скоро мы узнаем, какая судьба постигла Карла.", 4120, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(9, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4105, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Да, мистер Хаксли, само-собой. Извиняюсь за свое излишнее любопытство.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Отлично! Я верю в вас, мистер Хаксли!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4130, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4120, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Наверняка ты и так уже в курсе всех подробностей?
- Даниэль: Ну... Кое-что я слышал.
- Джимми: Что именно?
- Даниэль: Про человека, которого видели в лесу. Который назвал себя Беном. На рисунке, который получили Вигсы, тоже было написано это имя.
- Джимми: И что - есть идеи, кто бы это мог быть?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4140, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(9, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4150, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(9, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: По правде говоря, у меня есть одно предположение. Лет десять назад в нашем городе жил человек по имени Бенджамин Хартон. Он был военным. Во время боевых действий в Мидлстоуне он попал под взрывную волну от снаряда. Он долго пролежал в госпитале, но восстановится так и не смог.
Он вернулся домой другим человеком. Часами мог сидеть неподвижно и смотреть в одну точку. От него ушла жена. Ему благоразумно предложили переехать в интернат для того, чтобы о нем могли заботиться. Но в последний момент он просто взял и исчез. Вышел из дома и больше не вернулся. Судьба его до сих пор остается тайной.
Я подумал, что может быть этот человек в лесу и есть Бенджамин Хартон?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4150, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(132, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4160, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(132, 0, 0, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Да, я уже слышал эту историю. В любом случае мы можем это узнать наверняка только если найдем этого человека. Я займусь вопросом привлечения дополнительного поискового отряда. Возможно, Карл у этого человека.
- Даниэль: Кто знает, что может быть в голове у этого человека.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4170, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4150, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Это очень занимательная история, Даниэль... Если это и правда этот человек, то выходит, что он мог похитить Карла. Необходимо найти его.
- Даниэль: Да, но только одному Богу известно, где он может прятаться. Как мне известно, лес хорошо обыскивали, но ничего не нашли.
- Джимми: Вполне возможно, полицейские что-то пропустили. Я поставлю вопрос по привлечению большого поискового отряда к этой задаче, необходимо исследовать весь лес в радиусе несколько километров.
- Даниэль: Да, это отличная мысль.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4170, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4160, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Ты не знаешь, были ли у Стефана друзья или хорошие знакомые? Если он в городе, то скорее всего он у кого то прячется.
- Даниэль: Я точно не знаю. Стефан был агрессивный и нелюдимый человек, мне кажется у него не было близких друзей.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4180, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(9, 15, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4190, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(9, 0, 14, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4170, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Даниэль: Мистер Хаксли, у меня есть важная информация по поводу Стефана. Я думаю, она вас заинтересует.
- Джимми: Я весь внимания.
- Даниэль: На заправку недавно заезжал мой старый приятель Ричард. Мы учились в одном классе. Мы разговорились и я рассказал ему про то, что в Лонлифарм возможно вернулся Стефан. И тут он мне сказал, что возможно видел Стефана, около месяца назад. Он ехал в машине на пассажирском сиденье по Лесной улице, по направлению к лесодобывающему заводу.
- Джимми: Но почему он не сообщил об этом полиции?
- Даниэль: Он подумал, что это какой-то другой человек, который просто похож на Стефана. Он не придал этому серьезное значение, а потом и вовсе забыл.
- Джимми: Ричард не видел, кто был за рулем автомобиля?
- Даниэль: Нет, к сожалению он не помнит этого.
- Джимми: В любом случае спасибо.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4190, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(159, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4180, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Хорошего дня Даниэль, увидимся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(148, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.GasStation;
        locationEntity.PersonTopMenuPanel = SpritesKey.Daniel;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4190, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"По уже ставшему привычным маршруту Джимми поехал по направлению к дому престарелых Лонлифарма. Погода продолжала приятно удивлять - ясное небо без единой тучи давало надежду, что солнечная погода сохранится и к завтрашнему дню.
Проделав знакомую процедуру, Джимми постучался в комнату Ральфа.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4205, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Добрый день, мистер Вигс. Как дела? Здоровье не подводит?
- Ральф: Здравствуйте, мистер Хаксли. К сожалению, здоровье оставляет желать лучшего. Я привык подолгу гулять по городу, но в последнее время я в основном просто сижу в этой комнате и смотрю телевизор. Суставы не позволяют подолгу ходить пешком.
- Джимми: Да? Мистер Вигс, вас видели утром в день гибели Альфреда. Вы шли по Гастингс Стрит по направлению к дому Альфреда. А это, как минимум, в паре километров от сюда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4210, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(10, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4220, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(10, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4205, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Хм.. Да, я действительно там был. Я хотел проведать Альфреда. Я волновался за него. Когда он говорил о том, что ходил на завод... Я видел, что он что-то пронюхал, но не хотел говорить раньше времени. Это вполне в духе Альфреда. Но, к сожалению, я не успел. Его убили.
- Джимми: Официальное заключение полиции - произошел несчастный случай.
- Ральф: Знаете... Я не удивлюсь, если наша полиция за одно с этим Мартоном. Наверняка, также думал и Альфред. И поэтому решил сам искать правду.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4230, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Да, я был там в то утро. Я просто решил прогуляться и навестить Альфреда. Но его не оказалось дома. Я дошел до остановки и сел на автобус.
- Джимми: Для чего вы хотели зайти к Альфреду?
- Ральф: Я довольно редко общаюсь с кем-либо. В последнее время происходит столько событий, мне очень захотелось обсудить все это с Альфредом. Разговоры с ним всегда действовали успокоительно для меня.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4230, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4220, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Вы не знали, что Альфред в это время всегда совершает утреннюю прогулку по лесу?
- Ральф: Я просто забыл. Конечно, я знал об этом. Но возраст, сами понимаете. Иногда я забываю самые простейшие вещи.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4240, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(149, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4250, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(149, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4230, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Я знаю, что у вас в жизни было некоторое недопонимание с Альфредом.
- Ральф: Про что вы?
- Джимми: Вы любили женщину, но она вышла замуж за Альфреда.
- Ральф: Эх... Да, в нашей биографии был такой инцидент. Но я был обижен на него не долго. К тому же, Анастасия оказалась далеко не такой порядочной женщиной, как казалось. Они с Альфредом быстро развелись. Сейчас я даже счастлив, что не связал свою жизнь с ней.
- Джимми: И после этого вы общались с Альфредом как прежде?
- Ральф: Да. Мы забыли об этом случае. Все это дела давно минувших дней.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4250, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4240, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Ральф: Есть хотя бы какие-нибудь шансы, что мой внук Карл жив?
- Джимми: Я извиняюсь, но пока мне это не известно. Я думаю, что все решится в ближайшие дни. До встречи, мистер Вигс.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(150, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.RalfRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Ralf;
        locationEntity.MusicLocation = AudioKey.Crypto;
        locationDictionary.Add(4250, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Подъезжая к офисному зданию завода, Джимми увидел как Генри Мартон в сопровождении своего помощника направляется по направлению к своему автомобилю. Джимми прибавил газу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4305, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4300, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: Мистер Мартон! Можно вас на пару слов?
- Генри: Добрый день, мистер Хаксли. Хорошо, но только быстро, я очень тороплюсь.
- Джимми: На следующей неделе я возвращаюсь в Лонлифарм. От меня требуют промежуточных результатов расследования. 
Если говорить прямо, то меня направили в Лонлифарм не только для того, чтобы расследовать пропажу Карла. Полиция Йорк-Сити сильно сомневается в объективности расследования, проведенного в отношении вас. Я буду настаивать на повторной проверке вашей деятельности. Мы подозреваем, что вы и ваши помощники занимаетесь сбытом наркотических веществ в Лонлифарме. 
- Генри: Вот значит как... Мы готовы, как и прежде отстаивать свою невиновность. Я уверен, что вы и в этот раз ничего не добьетесь. 
Но послушайте, я уверен, что вы - более чем адекватный человек. К чему вам и нам все эти сложности? Просто доложите вашему начальству, что у нас все чисто. Я уверен, что вы об этом не пожалеете, мы договоримся.
- Джимми: Вы предлагаете мне взятку?
- Генри: Нет. Я просто предлагаю вам восемьдесят тысяч долларов наличными за оказание небольшой услуги. Вы же и так знаете, что ничего не найдете. Только зря потратите время. А нам все эти сложности просто ни к чему. Что скажите?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Звучит интересно.", 4310, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Я никогда в жизни не брал взяток. Сейчас вы сильно усугубили свое положение.", 4320, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(161, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4305, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Вот и отлично. Я правильно понимаю, что мы уладили все недоразумения?
- Джимми: Вы правильно поняли.
- Генри: Вы приняли мудрое решение. Мои люди свяжутся с вами. Всего хорошего.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(151, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(164, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4310, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Вы приняли неразумное решение. Мне очень жаль.
- Джимми: Неразумное решение приняли вы. Нанимайте хороших адвокатов.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4330, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(12, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4340, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(12, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4320, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: Эй, не кипятитесь так. На самом деле я не боюсь никаких проверок, так-как мы полностью чисты перед законом. Мне жаль ваше время. Лучше бы занялись Эдвардом Рэдли - бывшим владельцем завода. Вы не проверяли его биографию? Ему уже предъявляли обвинения в торговле наркотиками, но тогда он сумел отвертеться. После продажи своей доли завода он выхватил кучу денег. Куда интересно он их пустил, может быть он решил взяться за старое?
- Джимми: Спасибо, мистер Мартон. Я проверю эту информацию. До свидания.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(151, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(152, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(153, 0, 1, 0, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4330, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Генри: За меня можете не переживать. Переживайте за себя. Всего хорошего.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(151, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.MartonOffice;
        locationEntity.PersonTopMenuPanel = SpritesKey.Genry;
        locationEntity.MusicLocation = AudioKey.FatCaps;
        locationDictionary.Add(4340, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Через небольшой промежуток времени Джимми уже находился у двери Эдварда Рэдли.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4405, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardHouse;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4400, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Добрый день, мистер Хаксли! Отличная сегодня погода! Вы по делу?
- Джимми: Здравствуйте, мистер Рэдли? Ну как, вы были на заводе?
- Эдвард: Да. Многое узнать не удалось, но мой старый приятель Честер действительно как-то видел в лесу человека по описанию - один в один наш таинственный Бен.
- Джимми: Где и когда это было?
- Эдвард : Несколько месяцев назад. В лесу, примерно метрах в пятистах от территории завода.
- Джимми: Спасибо. С этим таинственным незнакомцем мы разберемся, но сейчас я хотел спросить кое-что другое. Генри Мартон сказал мне, что вы обвинялись в распространении наркотиков. Это правда?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4410, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(16, 12, 20, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 4420, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(16, 0, 11, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4405, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Это сложная история, мистер Хаксли. Но если у вас есть время, я расскажу.
У меня был заместитель, с которым мы были в приятельских отношения много лет. Его звали Дастин Брейд. Он был надежным человеком, как мне казалось. Я никогда не замечал в нем ничего подозрительного. Но однажды к нам в офис вломилась полиция. Они арестовали Дастина.
Позднее ему предъявили обвинения в хранении и сбытии наркотических веществ. Дастин не нашел ничего лучше, чем свалить вину на меня. Он дал показания о том, что он лишь исполнитель, а вся эта идея с распространением - моя. К моему ужасу, пара человек из руководства завода подтвердили показания Дастина. Видимо, они были в сговоре. Мне грозило пятнадцать лет.
Но однажды мне позвонил некий человек. Это был Генри Мартон. Он сказал, что хочет купить завод по заниженной цене. За это он поможет мне в моей проблеме. У Генри, по его словам, были хорошие знакомые в полиции. Что мне оставалось делать?
- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Неужели вы решились пойти на такое, вместо того, чтобы честно отстоять свои права в суде?", 4430, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Minus, VisibleEdit.Show));
        locationEntity.passageList.Add(new PassageEntity("Звучит сомнительно, но, пожалуй, у вас в этой ситуации выбора не было.", 4440, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(16, 0, 20, 1, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4410, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Это что еще за чушь? Неужели вы поверили этому проходимцу?
- Джимми: Нет, но я рассчитывал услышать от вас объяснения.
- Эдвард: Мне нечего вам объяснять. Это полная ерунда. Мистер Хаксли, я немного занят, прошу заехать в другой раз.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4460, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(162, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4420, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: Да. Я был уверен, что если я не соглашусь, то окажусь за решеткой.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4450, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4430, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Эдвард: А я про что? Я был уверен, что если я не соглашусь, то окажусь за решеткой.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4450, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4440, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: У вас не возникало ощущение, что это все - инсценировка, для того, чтобы забрать у вас ваш пакет акций?
- Эдвард: Вы думаете? Нет, раньше я об этом не думал...
- Джимми: Мартон появился в самый подходящий момент... Очень странное совпадении.
- Эдвард: Я тогда сильно испугался. Не видел, что происходит на самом деле.
- Джимми: Сейчас важно прижать этого Мартона.
- Эдвард: Да. Можете рассчитывать на мою помощь.
- Джимми: Спасибо.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4460, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(130, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Show));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(163, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Show));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4450, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми: До свидания, мистер Рэдли.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 3120, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(153, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(154, 0, 13, 1, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.EdvardRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.Edvard;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(4460, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Для Джимми это был очень насыщенный и важный день. Удалось выяснить некоторые важные детали. В голове Джимми уже созрели некоторые предварительные итоги расследования. 
Джимми решил, что завтра надо будет связаться с начальством. На улице уже был глубокий вечер и наступило время возвращаться в отель.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4500, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми попытался расслабиться и немного отдохнуть. Он уже твердо решил, что настало время назвать имя подозреваемого в исчезновении Карла. Тем не менее, в голову лезли определенные сомнения. Может быть он что-то упустил?";
        locationEntity.passageList.Add(new PassageEntity("Изучить записную книжку.", 4520, 0));
        locationEntity.passageList.Add(new PassageEntity("Лечь спать.", 4670, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4510, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Бенжамин Хартон.", 4530, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(132, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Сомнение Стерлинга в надежности Джонсона.", 4540, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(133, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Подозрение Анны со стороны Джонсона.", 4550, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(134, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Подтверждение намерения Стефана вернутся в Лонлифарм.", 4560, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(155, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Неравнодушное отношение Дона к Лиане Вигс.", 4570, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(138, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Конфликт Альфреда и Руфуса.", 4580, 0));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(149, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Угроза Карлу со стороны Дона.", 4590, 0));
        locationEntity.passageList[6].parameterEditList.Add(new ParameterEditEntity(156, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Нейт считает, что Дон виновен в исчезновении его мамы.", 4600, 0));
        locationEntity.passageList[7].parameterEditList.Add(new ParameterEditEntity(157, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Рассказ Дона о побеге Мэри.", 4610, 0));
        locationEntity.passageList[8].parameterEditList.Add(new ParameterEditEntity(146, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Намерение Мэри сбежать от Дона.", 4620, 0));
        locationEntity.passageList[9].parameterEditList.Add(new ParameterEditEntity(158, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Еще один свидетель, видевший Стефана.", 4630, 0));
        locationEntity.passageList[10].parameterEditList.Add(new ParameterEditEntity(159, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Попытка Генри дать взятку.", 4640, 0));
        locationEntity.passageList[11].parameterEditList.Add(new ParameterEditEntity(161, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Растерянность и раздражение Эдварда Рэдли.", 4650, 0));
        locationEntity.passageList[12].parameterEditList.Add(new ParameterEditEntity(162, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Махинация Генри Мартона.", 4660, 0));
        locationEntity.passageList[13].parameterEditList.Add(new ParameterEditEntity(163, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Закончить изучение записной книжки.", 4510, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4520, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Таинственный незнакомец, которого иногда видят в лесу может оказаться Бенджамином Хартоном - бывшим военным, тяжело раненным во время боевых действий. Хартон десять лет назад покинул свой дом и не вернулся.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4530, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Стерлинг сомневается в достоверности сведений Джонсона о том, что на месте предполагаемой сделки ничего не было. Стерлинг подозревает некоторую заинтересованность Джонсона в скрытии информации.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4540, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джонсон подозревает Анну в том, что она знает, где скрывается Стефан, но скрывает это. Анна и Стефан были раньше в дружеских отношениях.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4550, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Анна призналась в том, что Стефан один раз связывался по телефону с ней и сообщил о своем намерении вернуться в Лонлифарм.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4560, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Лиана Вигс призналась в том, что Дон испытывал к ней определенные чувства и был сильно разочарован в отказе с ее стороны.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4570, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Между Альфредом и Руфусом когда-то произошел конфликт, связанный с тем, что они любили одну женщину. В итоге, на этой женщине женился Альфред.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4580, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Нейт рассказал о том, что однажды в спышке гнева Дон угрожал убить Карла. Был ли это просто эмоциональный срыв или что-то более серьезное?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4590, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Нейт считает, что в исчезновении его мамы виновен Дон.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4600, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дон признался в том, что его жена Мэри сбежала со своим начальником в другую страну.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4610, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Лиза вспомнила подробность о том, что однажды Мэри на эмоциях сказала Лизе о том, что хочет убежать от Дона. Были ли это просто слова или Мэри реализовала свое намерение?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4620, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Приятель Даниэля видел в машине человека, похожего на Стефана. Машина двигалась по направлению к заводу.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4630, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Генри не на шутку испугался возможной проверки их деятельности и предложил серьезную взятку.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4640, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Эдвард Рэдли резко поменял свое поведение после просьбы рассказать об уголовном деле, которое завели на него в связи с подозрением в распространении наркотиков. О том, что такое дело действительно существовало, рассказал Генри Мартон.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4650, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Эдвард Рэдли продал свою часть акций завода под влиянием странного уголовного процесса. Есть основания полагать, что данный процесс инициирован Генри Мартоном, с целью создать давление на Эдварда.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4520, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.HotelMusic;
        locationDictionary.Add(4660, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми в темном глухом лесу. Вокруг никого нет. Он идет вперед и не понимает, что он здесь делает. Джимми выходит на круглую поляну.
Вдруг перед ним начинает материализовываться некий человек. У этого человека холодный проницательный взгляд. Он внимательно смотрит на Джимми. От этого взгляда бегут мурашки по коже.
Джимми замечает во взгляде человека некоторую странность, как-будто он сейчас не здесь, а где-то совсем в другом месте.
- Тебя зовут Бенджамин? - Спрашивает Джимми.
Взгляд человека становится вдруг более ясным. Он напряженно смотрит на Джимми.
- Все дело в мести... Месть - причина зла... - Медленно говорит этот человек. Затем он начинает растворяться в воздухе.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4700, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.DarkForest;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.PoliceMusic;
        locationDictionary.Add(4670, locationEntity);
        #endregion
        #region Day 7
        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми проснулся от оглушительного телефонного звонка. В полусонном состоянии Джимми взял трубку:
- Джимми: Алло? Что случилось?
- Стерлинг: Извините, что так рано, мистер Хаксли. Но у нас невероятные новости. Карл Вигс вернулся домой.
- Джимми: Вы это серьезно?! Где он сейчас?
- Стерлинг: Он у нас в участке. Мы ждем вас, чтобы провести допрос. Карл рассказывает нечто странное, вам нужно быть здесь как можно быстрее.
- Джимми: Выезжаю.";
        locationEntity.passageList.Add(new PassageEntity("Отправиться в полицейский участок.", 4710, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4700, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Так толком и не проснувшись, Джимми на скорую руку нацепил на себя костюм и спешно покинул номер. Через несколько минут он уже был в участке.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4711, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4710, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Вот и вы, мистер Хаксли! Сегодня удивительный день!";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4712, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4711, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Доброе утро, мистер Хаксли.
- Джимми: Я вас приветствую, господа. Привет, Карл.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4713, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4712, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"За столом сидел смуглый черноволосый мальчик. У него был неряшливый вид, растрепанная прическа и потерянный взгляд, в котором читался испуг и удивление.
- Карл: Здравствуйте, мистер.
- Джимми: Привет. Как ты себя чувствуешь, Карл?
- Карл: Нормально.
- Джимми: Можешь сейчас разговаривать? Или тебе нужно время?
- Карл: Могу.
- Джимми: Вот и отлично. Тогда начнем с самого начала. Что случилось третьего сентября, после того как ты вышел из дома?
- Карл: Я пошел в лес. Хотел немного побегать и подготовиться к соревнованиям.
Карлу тяжело давалось каждое слово. Он очень волновался.
- Джимми: Хорошо. Что случилось дальше?
- Карл: Я бежал. Так-как скоро соревнования, я решил убежать подальше, чем обычно. Но внезапно наступил вечер. Я повернул назад, но видимо перепутал поворот и вышел в незнакомое место. Я немного испугался, что заблудился. Потом я увидел, как навстречу мне идет другой человек.
- Джимми: Ты знаешь кто это был? Как он выглядел?
- Карл: Он был высокий. У него были черные длинные волосы, нос с горбинкой. Мне он показался очень неприятным.
- Джимми: Что было дальше?
- Карл: Он спросил меня, что я тут делаю. Я сказал, что иду в Лонлифарм и заблудился. Он сказал мне, чтобы я шел за ним - он покажет мне дорогу. Мы пошли. Он шел очень быстро, почти бежал. Он сильно хромал. Уже было очень темно.
- Джимми: И куда он тебя завел?
- Карл: Никуда. Через несколько минут я услышал сильный шум сзади нас. Шум мотора. Кажется это была машина. И все. Я не знаю, что случилось потом. Я почувствовал сильный удар и отключился.
- Джимми: Удар? На тебя наехала машина?
- Карл: Наверное. И на этого мужчину тоже.
- Джимми: Но что произошло потом?
- Карл: Я очнулся в какой-то хижине. У меня страшно болело тело, я практически не мог шевелиться. Я не мог понять, где я нахожусь. Затем в хижину вошел человек. Он выглядел как-то странно. Он был одет в какие-то лохмотья, он него очень неприятно пахло.
- Джимми: Сколько ему примерно лет?
- Карл: Не знаю. Мне он показался очень старым. У него седые волосы и кожа вся в морщинах.
- Джимми: Что сказал этот человек?
- Карл: Ничего. Он вообще очень редко что-то говорил. Он дал мне выпить какой-то отвар. Он был ужасный на вкус. Затем он дал мне поесть жаренное мясо.
- Джимми: Что было дальше?
- Карл: Все тоже самое. Я жил в этой хижине много дней. Этот человек давал мне отвар и еду. Постепенно у меня переставало болеть тело и я стал потихоньку ходить.
- Джимми: Он говорил, как его зовут?
- Карл: Он сказал, чтобы я называл его Беном.
- Джимми: Что тебе говорил этот человек?
- Карл: Он очень редко что-то говорил. Рассказывал, что живет тут уже много лет. Что он не хочет никого видеть. Что я у него - единственный гость за все время. Однажды он сказал, что я попал в очень неприятную историю, которая связана с таким людским пороком, как месть.
Как-то раз он предложил мне нарисовать что-нибудь. Я нарисовал лес, который находился вокруг нас. И написал имя этого человека. Бен сказал, что отнесет рисунок моим родителям, что-бы они не волновались.
- Джимми: Но ты же мог написать записку родителям!
- Карл: Я хотел. Но Бен не разрешил, сказав, что тогда его хижину будут искать и найдут. А он не хочет этого.
- Джимми: Все это время ты пробыл у него?
- Карл: Да.
- Джимми: Он отпустил тебя?
- Карл: Да. Сегодня ранним утром. Он сказал, что я уже здоров и смогу дойти до города. К тому же, скоро зима и в хижине становится холодно. Он проводил меня до знакомых мест и я пошел домой.
- Джонсон: Вот это история. Просто невероятно.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4714, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Karl;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4713, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да уж. Что бы было, если бы Карла не нашел этот человек? Думаю, что ничего хорошего.
- Джимми: Вы показывали Карла врачу?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4715, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4714, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джонсон: Да, естественно. Врач только что ушел. Он сказал, что у Карла все отлично, никаких серьезных повреждений.
- Джимми: Спасибо тебе большое, Карл. Мы все очень рады, что ты жив и находишься здесь. Я думаю, что мы можем тебя отпустить домой.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4716, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Johnson;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4715, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Стерлинг: Да. Все показания зафиксированы. Мистер Хаксли, что вы думаете обо всей этой фантастической истории?
- Джимми: Нужно немного времени, чтобы сделать какой-то вывод. Пожалуй, я поеду в отель. Я позвоню вам.
- Стерлинг: Да, конечно. Тут есть над чем помозговать.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4720, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Police;
        locationEntity.PersonTopMenuPanel = SpritesKey.Sterling;
        locationEntity.MusicLocation = AudioKey.Namaste;
        locationDictionary.Add(4716, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми сидел в своем номере и смотрел в окно. Затем он взял свою записную книжку и начал внимательно ее изучать. Так он просидел около двух часов. Затем он взял свой телефон и набрал номер:
- Джимми: Добрый день, мистер Блэк.
- Гарольд Блэк: О, привет, Джимми! Давно тебя не слышно. Ну что, как успехи расследования? Когда ждать тебя в отделе?
- Джимми: Думаю, завтра я буду в Йорк-Сити.
- Гарольд Блэк: Так быстро? Уже есть какие-то результаты?
- Джимми: Да. У меня сложилась определенная картина того, что произошло. Я передаю вам все итоги расследования. Дальше вы сами решайте, что со всем этим делать. И кстати - мальчик нашелся.
- Гарольд Блэк: Отличные новости! Он сам убежал или попал в какую-то неприятную историю?
- Джимми: Да, он попал в очень неприятную ситуацию, за которую ответственны определенные лица.
- Гарольд Блэк: А что там с гибелью того старика, это как-то связано с нашим делом?
- Джимми: Все будет в моем отчете.
- Гарольд Блэк: Хорошо. У вас есть конкретный подозреваемый в пропаже мальчика?
- Джимми: Да.
- Гарольд Блэк: И кто это?";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4730, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4720, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Джимми:";
        locationEntity.passageList.Add(new PassageEntity("Руфус Бэнтли.", 4740, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(0, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(185, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Стерлинг Хансон.", 4740, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(1, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(175, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Джонсон Купер.", 4740, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(2, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(176, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(189, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Анна Смит.", 4740, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(3, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(177, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Билл Вигс.", 4740, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(5, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(178, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Лиана Вигс.", 4740, 0));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(6, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(179, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Ральф Вигс.", 4740, 0));
        locationEntity.passageList[6].parameterEditList.Add(new ParameterEditEntity(10, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[6].parameterEditList.Add(new ParameterEditEntity(183, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Дон Уисли.", 4740, 0));
        locationEntity.passageList[7].parameterEditList.Add(new ParameterEditEntity(7, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[7].parameterEditList.Add(new ParameterEditEntity(180, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Лиза Сноуфилд.", 4740, 0));
        locationEntity.passageList[8].parameterEditList.Add(new ParameterEditEntity(4, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[8].parameterEditList.Add(new ParameterEditEntity(181, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Даниэль Рэдклиф.", 4740, 0));
        locationEntity.passageList[9].parameterEditList.Add(new ParameterEditEntity(9, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[9].parameterEditList.Add(new ParameterEditEntity(182, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Генри Мартон.", 4740, 0));
        locationEntity.passageList[10].parameterEditList.Add(new ParameterEditEntity(12, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[10].parameterEditList.Add(new ParameterEditEntity(164, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[10].parameterEditList.Add(new ParameterEditEntity(187, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Эдварл Рэдли.", 4740, 0));
        locationEntity.passageList[11].parameterEditList.Add(new ParameterEditEntity(16, 0, 8, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[11].parameterEditList.Add(new ParameterEditEntity(184, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Стефан Кнайт.", 4740, 0));
        locationEntity.passageList[12].parameterEditList.Add(new ParameterEditEntity(186, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Бенджамин Хартон.", 4740, 0));
        locationEntity.passageList[13].parameterEditList.Add(new ParameterEditEntity(132, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList[13].parameterEditList.Add(new ParameterEditEntity(188, 0, 1, 1, ValueEditAction.Equally, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4730, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"- Гарольд Блэк: Ого. Интересное предположение. Ладно, Джимми, заканчивай дела и чтобы завтра дело о пропаже Карла Вигса было у меня на столе. До связи.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4750, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4740, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми подошел к окну. Перед ним открывался вид на Лонлифарм. За эти дни Джимми стал нравится этот город куда больше. Огромные лесные массивы, окружающие город, выглядели очень величественно и загадочно. Туман, который окутывал лес со всех сторон, придавал этому отдаленному от крупных городов месту дополнительную загадочность.
Где-то там, в глубине леса случился случай, который оставит для Джимми воспоминания на всю жизнь.
На пенсии было бы неплохо поселиться где-нибудь здесь - рядом с лесом, и начать писать детективные истории - промчалась мысль в голове Джимми.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 4760, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.HotelRoom;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4750, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Эпилог";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5010, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(185, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5020, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(175, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5030, 0));
        locationEntity.passageList[2].parameterEditList.Add(new ParameterEditEntity(176, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5040, 0));
        locationEntity.passageList[3].parameterEditList.Add(new ParameterEditEntity(177, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5050, 0));
        locationEntity.passageList[4].parameterEditList.Add(new ParameterEditEntity(178, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5060, 0));
        locationEntity.passageList[5].parameterEditList.Add(new ParameterEditEntity(179, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5070, 0));
        locationEntity.passageList[6].parameterEditList.Add(new ParameterEditEntity(180, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5080, 0));
        locationEntity.passageList[7].parameterEditList.Add(new ParameterEditEntity(181, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5090, 0));
        locationEntity.passageList[8].parameterEditList.Add(new ParameterEditEntity(182, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5100, 0));
        locationEntity.passageList[9].parameterEditList.Add(new ParameterEditEntity(183, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5110, 0));
        locationEntity.passageList[10].parameterEditList.Add(new ParameterEditEntity(187, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5120, 0));
        locationEntity.passageList[11].parameterEditList.Add(new ParameterEditEntity(184, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5130, 0));
        locationEntity.passageList[12].parameterEditList.Add(new ParameterEditEntity(186, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5140, 0));
        locationEntity.passageList[13].parameterEditList.Add(new ParameterEditEntity(188, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.Lonlifarm;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Clouds;
        locationDictionary.Add(4760, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла миролюбивого администратора отеля - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Руфуса к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5010, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Обвинение Стерлинга Хансона - главного человека в полиции Лонлифарма - было очень громкой историей. Джимми обвинил Стерлинга в попытке убийства Карла и покрывательстве других преступлений, в том числе и распространения наркотиков в Лонлифарме.
Но серьезных доказательств причастия Стерлинга к этому делу Джимми предоставить так и не смог.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5020, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дело об исчезновении Карла стало одним из самых громких успехов в карьере Джимми.
Джимми сумел полностью разобраться в этой мрачной и таинственной истории.
Итоговый вывод о деле Карла выглядел следующим образом.
Джонсон Купер получил служебное задание проверить наводку о возможной сделке по продаже наркотических веществ.
Наводка оказалась совершенно достоверной - Джонсон увидел как помощник Генри Мартона - Майк, реализует партию запрещенных веществ группе молодых людей. В тот момент Джонсон осознал, кто виновен в смерти его отца. Это - Генри Мартон. Ведь именно под воздействием наркотиков Стефан совершил свое страшное преступление.
Джонсон жаждал мести. Он отправился в офис Генри. Но задуманное реализовать так и не смог. Джонсон и Генри заключили сделку. Используя свои связи по всему миру, Генри находит и доставляет в город Стефана Кнайта. В ответ на услугу Джонсон скрывает тот факт, что в распространении наркотиков замешан Генри.
На поиски Стефана уходит несколько месяцев. И вот Стефана находят на другом континенте. Он живет спокойной жизнью под другим именем и фамилией. Его похищают и доставляют частным самолетом в Лонлифарм.
Самолет встречают Джонсон и Майк. Они едут по направлению к лесодобывающему заводу. За рулем Джонсон. Затем они углубляются в лес.
Стефан и Джонсон выходят из машины. Вот он момент возмездия. Джонсон берет в руки пистолет и направляет его на Стефана. Джонсон долго колеблется и не может принять роковое решение. Воспользовавшись замешательством, Стефан убегает в лес. За ним в погоню едут Джонсон и Майк.
К несчастью, Стефан встречает Карла, который заблудился в лесу. Карл сообщает Стефану об этом. Стефан говорит, чтобы Карл шел за ним. И тут Джонсон нагоняет их. Из-за темноты он не сразу заметил Карла. В итоге под колесами Стефан оказывается вместе с Карлом.
Джонсон теряется и не знает, что делать. Он видит, что ребенок еще дышит. Он решает, оставить Карла на месте, а труп Стефана закопать в лесу.
Позднее Карла в тяжелом состоянии находит Бенджамин Хартон.
Затем Джонсон узнает, что его вместе со Стефаном видел Альфред Стоун. Он решает избавиться от старика. Утром он на служебной машине подъезжает к дому Альфреда. Он следит за ним по маршруту прогулки Альфреда и в удобный момент сталкивает Адьфреда в овраг.
Суд признал доказательства, предоставленные Джимми, убедительными. Джонсона Купера признали полностью виновным.
Так закончилась эта таинственная история. Это был еще один громкий успех Джимми Хаксли.
Джимми получил повышение в должности и впоследствии расследовал еще немало загадочных происшествий.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.passageList[0].parameterEditList.Add(new ParameterEditEntity(164, 0, 0, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.passageList.Add(new PassageEntity("Далее", 5150, 0));
        locationEntity.passageList[1].parameterEditList.Add(new ParameterEditEntity(164, 1, 1, 0, ValueEditAction.Plus, VisibleEdit.Let));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.TrueEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.RiverMeditation;
        locationDictionary.Add(5030, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми объявил виновным в покушении на жизнь Карла Вигса вернувшегося в Лонлифарм убийцу - Стефана Кнайта. Так-как Стефана так и не нашли, Джимми обвинил Анну Смит в помощи Стефану и скрытии данных о его настоящем нахождении.
Но серьезных доказательств причастия Анны к этому делу Джимми предоставить так и не смог.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5040, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла его родного отца - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Билла Вигса к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5050, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла его родную мать - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Лианы Вигс к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5060, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Дон Уисли был главным подозреваемым для Джимми с самого начала дела. Джимми предъявил Дону обвинение в покушении на жизнь Карла Вигса, а также в убийстве своей жены - Мэри.
Шеф Джимми - Гарольд Блэк согласился в том, что Дон является главным подозреваемым. Дело довели до суда.
Судебный процесс был долгим и громким. В итоге был вынесен оправдательный приговор. Суд не счел доказательства, предоставленные Джимми, убедительными.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5070, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла общительную официантку из кафе - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Лизу Сноуфилд к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5080, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла веселого заправщика с бензоколонки - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Даниэля Рэдклифа к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5090, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Джимми обвинил Ральфа Вигса в попытке убийства своего внука Карла, а также в убийстве своего близкого друга Альфреда. Данным решением Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Ральфа Вигса к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5100, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Обвинение Генри Мартона - владельца крупнейшего завода в Лонлифарме - было очень громкой историей. Джимми обвинил Генри и его помощников в попытке убийства Карла и в распространения наркотиков в Лонлифарме.
Связь Генри с распространением наркотиков была подтверждена и доказана. Именно он и его помощник Майк занимались сбытом запрещенных веществ в городе. Обоим уже предъявлены обвинения.
Но серьезных доказательств причастия Генри к покушению на Карла Джимми предоставить так и не смог.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции немного пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5110, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"К сожалению, дело о пропаже Карла Вигса вошло в список немногочисленных профессиональных неудач в карьере Джимми Хаксли. Обвинив в попытке убийства Карла бывшего владельца завода - Джимми поставил под сомнение свою профессиональную компетентность.
Джимми не смог предоставить никаких серьезных доказательств причастия Эдварда Рэдли к этому делу.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции сильно пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5120, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми объявил виновным в покушении на жизнь Карла Вигса вернувшегося в Лонлифарм убийцу - Стефана Кнайта. Была проведена серьезная поисковая операция, но Стефана так и не нашли. Никаких прямых доказательств возвращения Стефана в Лонлифарм предоставлено не было.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции немного пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5130, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Джимми объявил виновным в покушении на жизнь Карла Вигса пропавшего много лет назад военного - Бенджамина Хартона. По мнению Джимми, Бенджамин похитил Карла и удерживал его в своей хижине более месяца.
Была проведена серьезная поисковая операция, но Бенджамина так и не нашли.
В настоящее время дело Карла передано другому детективу, но ответа на вопрос, что произошло тем злополучным вечером в глухом лесу так и нет.
Авторитет Джимми в полиции немного пошатнулся. Его начальник Гарольд Блэк с тех пор не доверяет Джимми серьезных дел.
Джимми все чаще стал проводить свое свободное время в баре за стаканом виски.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BarEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.Rising;
        locationDictionary.Add(5140, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"Как известно, все тайное рано или поздно становится явным.
Через какое-то время, вскрылся факт того, что Джимми Хаксли принял служебную взятку от Генри Мартона.  Поняв, что в этот раз от тюрьмы не отвертеться, Генри решил отомстить и дал показания, которые свидетельствуют об этом факте.
Это стало серьейзнейшим пятном на профессиональной карьере Джимми.
Он был отстранен от должности. В настоящее время против Джимми возбуждено уголовное дело.";
        locationEntity.passageList.Add(new PassageEntity("Далее", 5160, 0));
        locationEntity.BackgroundTopMenuPanel = SpritesKey.BadEnd;
        locationEntity.PersonTopMenuPanel = SpritesKey.None;
        locationEntity.MusicLocation = AudioKey.DarkWalk;
        locationDictionary.Add(5150, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.passageList.Add(new PassageEntity("Загрузить последнее сохранение.", 5200, 0));
        locationEntity.passageList.Add(new PassageEntity("Начать с начала.", 5210, 0));
        locationEntity.passageList.Add(new PassageEntity("Выйти в меню.", 5220, 0));
        locationDictionary.Add(5160, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.ActionLocation = ActionLocation.LoadGame;
        locationDictionary.Add(5200, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.ActionLocation = ActionLocation.NewGame;
        locationDictionary.Add(5210, locationEntity);

        locationEntity = new LocationEntity();
        locationEntity.Text = @"";
        locationEntity.ActionLocation = ActionLocation.MainMenu;
        locationDictionary.Add(5220, locationEntity);
        #endregion
    }
}
