using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Перечисление спрайтов
/// </summary>
public enum SpritesKey
{
    None,
    AlfredHouse,
    AlfredRoom,
    BadEnd,
    BarEnd,
    Cafe,
    CarlRoom,
    DarkForest,
    EdvardHouse,
    EdvardRoom,
    GasStation,
    Hotel,
    HotelRoom,
    KillerPlace,
    Lonlifarm,
    MartonOffice,
    NeitRoom,
    Police,
    RalfHouse,
    RalfRoom,
    RoadInTheMountains,
    School,
    SchoolRoom,
    TrueEnd,
    VigsHouse,
    VigsRoom,
    WisliHouse,
    WisliRoom,
    Alfred,
    Anna,
    Bill,
    Daniel,
    Don,
    Edvard,
    Genry,
    Johnson,
    Karl,
    Liana,
    Lisa,
    Milana,
    Neit,
    Ralf,
    Rufus,
    Sterling
}

/// <summary>
/// Компонент загрузки спрайтов
/// </summary>
public class LoadSptitesDL : MonoBehaviour
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
    /// Загрузка спрайтов
    /// </summary>
    /// <param name="spritesDictionary">Словарь спрайтов</param>
    public void LoadSptites(Dictionary<SpritesKey, Sprite> spritesDictionary)
    {
        spritesDictionary.Clear();

        spritesDictionary.Add(SpritesKey.None, null);

        spritesDictionary.Add(SpritesKey.AlfredHouse, Resources.Load<Sprite>("Sprites/Background/AlfredHouse"));
        spritesDictionary.Add(SpritesKey.AlfredRoom, Resources.Load<Sprite>("Sprites/Background/AlfredRoom"));
        spritesDictionary.Add(SpritesKey.BadEnd, Resources.Load<Sprite>("Sprites/Background/BadEnd"));
        spritesDictionary.Add(SpritesKey.BarEnd, Resources.Load<Sprite>("Sprites/Background/BarEnd"));
        spritesDictionary.Add(SpritesKey.Cafe, Resources.Load<Sprite>("Sprites/Background/Cafe"));
        spritesDictionary.Add(SpritesKey.CarlRoom, Resources.Load<Sprite>("Sprites/Background/CarlRoom"));
        spritesDictionary.Add(SpritesKey.DarkForest, Resources.Load<Sprite>("Sprites/Background/DarkForest"));
        spritesDictionary.Add(SpritesKey.EdvardHouse, Resources.Load<Sprite>("Sprites/Background/EdvardHouse"));
        spritesDictionary.Add(SpritesKey.EdvardRoom, Resources.Load<Sprite>("Sprites/Background/EdvardRoom"));
        spritesDictionary.Add(SpritesKey.GasStation, Resources.Load<Sprite>("Sprites/Background/GasStation"));
        spritesDictionary.Add(SpritesKey.Hotel, Resources.Load<Sprite>("Sprites/Background/Hotel"));
        spritesDictionary.Add(SpritesKey.HotelRoom, Resources.Load<Sprite>("Sprites/Background/HotelRoom"));
        spritesDictionary.Add(SpritesKey.KillerPlace, Resources.Load<Sprite>("Sprites/Background/KillerPlace"));
        spritesDictionary.Add(SpritesKey.Lonlifarm, Resources.Load<Sprite>("Sprites/Background/Lonlifarm"));
        spritesDictionary.Add(SpritesKey.MartonOffice, Resources.Load<Sprite>("Sprites/Background/MartonOffice"));
        spritesDictionary.Add(SpritesKey.NeitRoom, Resources.Load<Sprite>("Sprites/Background/NeitRoom"));
        spritesDictionary.Add(SpritesKey.Police, Resources.Load<Sprite>("Sprites/Background/Police"));
        spritesDictionary.Add(SpritesKey.RalfHouse, Resources.Load<Sprite>("Sprites/Background/RalfHouse"));
        spritesDictionary.Add(SpritesKey.RalfRoom, Resources.Load<Sprite>("Sprites/Background/RalfRoom"));
        spritesDictionary.Add(SpritesKey.RoadInTheMountains, Resources.Load<Sprite>("Sprites/Background/RoadInTheMountains"));
        spritesDictionary.Add(SpritesKey.School, Resources.Load<Sprite>("Sprites/Background/School"));
        spritesDictionary.Add(SpritesKey.SchoolRoom, Resources.Load<Sprite>("Sprites/Background/SchoolRoom"));
        spritesDictionary.Add(SpritesKey.TrueEnd, Resources.Load<Sprite>("Sprites/Background/TrueEnd"));
        spritesDictionary.Add(SpritesKey.VigsHouse, Resources.Load<Sprite>("Sprites/Background/VigsHouse"));
        spritesDictionary.Add(SpritesKey.VigsRoom, Resources.Load<Sprite>("Sprites/Background/VigsRoom"));
        spritesDictionary.Add(SpritesKey.WisliHouse, Resources.Load<Sprite>("Sprites/Background/WisliHouse"));
        spritesDictionary.Add(SpritesKey.WisliRoom, Resources.Load<Sprite>("Sprites/Background/WisliRoom"));

        spritesDictionary.Add(SpritesKey.Alfred, Resources.Load<Sprite>("Sprites/Person/Alfred"));
        spritesDictionary.Add(SpritesKey.Anna, Resources.Load<Sprite>("Sprites/Person/Anna"));
        spritesDictionary.Add(SpritesKey.Bill, Resources.Load<Sprite>("Sprites/Person/Bill"));
        spritesDictionary.Add(SpritesKey.Daniel, Resources.Load<Sprite>("Sprites/Person/Daniel"));
        spritesDictionary.Add(SpritesKey.Don, Resources.Load<Sprite>("Sprites/Person/Don"));
        spritesDictionary.Add(SpritesKey.Edvard, Resources.Load<Sprite>("Sprites/Person/Edvard"));
        spritesDictionary.Add(SpritesKey.Genry, Resources.Load<Sprite>("Sprites/Person/Genry"));
        spritesDictionary.Add(SpritesKey.Johnson, Resources.Load<Sprite>("Sprites/Person/Johnson"));
        spritesDictionary.Add(SpritesKey.Karl, Resources.Load<Sprite>("Sprites/Person/Karl"));
        spritesDictionary.Add(SpritesKey.Liana, Resources.Load<Sprite>("Sprites/Person/Liana"));
        spritesDictionary.Add(SpritesKey.Lisa, Resources.Load<Sprite>("Sprites/Person/Lisa"));
        spritesDictionary.Add(SpritesKey.Milana, Resources.Load<Sprite>("Sprites/Person/Milana"));
        spritesDictionary.Add(SpritesKey.Neit, Resources.Load<Sprite>("Sprites/Person/Neit"));
        spritesDictionary.Add(SpritesKey.Ralf, Resources.Load<Sprite>("Sprites/Person/Ralf"));
        spritesDictionary.Add(SpritesKey.Rufus, Resources.Load<Sprite>("Sprites/Person/Rufus"));
        spritesDictionary.Add(SpritesKey.Sterling, Resources.Load<Sprite>("Sprites/Person/Sterling"));
    }
}
