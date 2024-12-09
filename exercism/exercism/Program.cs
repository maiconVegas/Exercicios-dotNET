//-----------------------------------------------------------------------------------------------
using exercism.annalyns_infiltration;
using exercism.elons_toys;
using exercism.hello_world;
using exercism.lucians_luscious_lasagna;
using exercism.squeaky_clean;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
//-----------------------------------------------------------------------------------------------

//Console.WriteLine(HelloWorld.Hello());

//-----------------------------------------------------------------------------------------------

//var lasagna = new Lasagna();
//Console.WriteLine(lasagna.ExpectedMinutesInOven());
//Console.WriteLine(lasagna.RemainingMinutesInOven(30));
//Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
//Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));

//-----------------------------------------------------------------------------------------------

//Console.WriteLine(QuestLogic.CanFastAttack(false));
//Console.WriteLine(QuestLogic.CanSpy(true, false, false));
//Console.WriteLine(QuestLogic.CanSignalPrisoner(false, true));
//Console.WriteLine(QuestLogic.CanFreePrisoner(true, false, false, true));

//-----------------------------------------------------------------------------------------------
// LogLine
//Console.WriteLine("letra".IndexOf("e"));
//Console.WriteLine("letra".Substring(1, 4));

//-----------------------------------------------------------------------------------------------

//RemoteControlCar car = RemoteControlCar.Buy();
//for (int i = 0; i < 54; i++)
//{
//    car.Drive();
//}

//Console.WriteLine(car.DistanceDisplay());
//Console.WriteLine(car.BatteryDisplay());

//-----------------------------------------------------------------------------------------------

//int[] birdsPerDay = new int[] { 2, 5, 0, 7, 4, 1 };
//Console.WriteLine(birdsPerDay.Take(4).Sum());
//Console.WriteLine(birdsPerDay.Length - 1);
//foreach (var item in birdsPerDay)
//{
//    Console.WriteLine(item == 0);
//}

//-----------------------------------------------------------------------------------------------

//var identi = Identifier.Clean("my   Id");
//Console.WriteLine(identi);

//var identifier = "my  id";

//identifier = identifier.Replace(" ", "_");
//Console.WriteLine(identifier);

var identifier = "my\0Id";
var result = new StringBuilder();
foreach (char c in identifier)
{
    if (char.IsControl(c))
    {
        
    }
}
Console.WriteLine(identifier);



