﻿//-----------------------------------------------------------------------------------------------
using exercism.annalyns_infiltration;
using exercism.booking_up_for_beauty;
using exercism.elons_toys;
using exercism.hello_world;
using exercism.interest_is_interesting;
using exercism.international_calling_connoisseur;
using exercism.lucians_luscious_lasagna;
using exercism.squeaky_clean;
using exercism.tracks_on_tracks_on_tracks;
using exercism.wizards_and_warriors;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
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

////var identi = Identifier.Clean("my   Id");
////Console.WriteLine(identi);

////var identifier = "my  id";

////identifier = identifier.Replace(" ", "_");
////Console.WriteLine(identifier);

//var identifier = "my\0Id";
////int i = 0;
////foreach (var letter in identifier)
////{
////    Console.WriteLine(letter);
////    Console.WriteLine(i += 1);

//int ind = 0;
//foreach (var item in identifier)
//{
//    if (char.IsControl(item))
//    {
//        ind = identifier.IndexOf(item);
//        identifier = identifier.Replace(item, 'L');
//    }
//}

//identifier = identifier.Insert(ind, "CTR");
////var result = new StringBuilder();
////foreach (char c in identifier)
////{
////    if (char.IsControl(c))
////    {

////    }
////}
//Console.WriteLine(identifier);
//Console.WriteLine("/////////////");
//identifier = "my   Id";
//Console.WriteLine(Identifier.Clean(identifier));

//identifier = "à-ḃç";
//Console.WriteLine(identifier);
//Console.WriteLine(Identifier.Clean(identifier));
//Console.WriteLine(identifier[2 - 1]);

//Console.WriteLine(Identifier.Clean("àḃç"));

//Console.WriteLine(Convert.ToChar('a' + 2));
//Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
////var teste = "MyΟβιεγτFinder";

////var teste2 = Convert.ToInt32('α');
////var teste3 = Convert.ToInt32('ω');
////Console.WriteLine(teste2);
////Console.WriteLine(teste3);
//Console.WriteLine('ε' < 'α' || 'ε' > 'ω');
////foreach (var letra in teste)
////{
////    if (letra < 'α' || letra > 'ω')
////    {
////        Console.WriteLine(letra);
////    }
////}

//-----------------------------------------------------------------------------------------------

//var data = DateTime.Now;
//Console.WriteLine(data.ToString(new CultureInfo("pt-BR")));
//var date = DateTime.ParseExact("7/25/2019 13:45:00", "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
//Console.WriteLine(date);

//var date1 = DateTime.Parse("July 25, 2019 13:45:00");
//Console.WriteLine(date1);
//var date2 = DateTime.Parse("Thursday, July 25, 2019 13:45:00");
//Console.WriteLine(date2);

//Console.WriteLine(Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));

//Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 17, 0, 0)));

//Console.WriteLine(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));

//Console.WriteLine(Appointment.AnniversaryDate().ToString());

//-----------------------------------------------------------------------------------------------

//Console.WriteLine(SavingsAccount.InterestRate(balance: 200.75m));
//Console.WriteLine(SavingsAccount.Interest(balance: 200.75m));
//Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m));

//-----------------------------------------------------------------------------------------------

// foi testado os remoteControlCar nao

//-----------------------------------------------------------------------------------------------

//var teste = new Warrior();

//-----------------------------------------------------------------------------------------------

//////////////////////// SOMENTE TESTANDO MESMO, NAO ESTA ENVOLVIDO COM O EXERCICIO NAO
//int[] numbers = [0, 1, 2, 3, 4, 5, 6];
//var numQuery = from num  in numbers where (num%2)==0 select num;

//foreach (var item in numQuery)
//{
//    Console.WriteLine(item);
//}



//int teste1 = 5;
//int teste2 = 6;
//int teste3 = 7;


//var retorno = teste2 switch
//{
//    < 2 => "menor que dois",
//    < 6 => "menor que seis",
//    _ => "menor que nada"
//};

//Console.WriteLine(retorno);
//Console.WriteLine(uint.MaxValue);
//var teste = BitConverter.GetBytes(5).Prepend((byte)(256 - 8));
//Console.WriteLine(teste.ToString());
//Console.WriteLine("///////////");
//var amem = BitConverter.GetBytes(long.MinValue).Prepend((byte)(256 - 8));
//var testee = amem.Concat(new byte[9 - amem.Count()]).ToArray();
//Console.WriteLine(testee[0]);

//-----------------------------------------------------------------------------------------------
//Console.WriteLine("Teste");
//Languages.RemoveLanguage(Languages.GetExistingLanguages(), "Clojure");

//-----------------------------------------------------------------------------------------------

//Console.WriteLine(DialingCodes.GetExistingDictionary()[1]);

//var dicionario = new Dictionary<int, string>() {
//    [1] = "Banana",
//    [2] = "Maça",
//    [3] = "Maracuja",
//    [4] = "Laranja"
//};

//Console.WriteLine(dicionario.Values.OrderByDescending(n => n.Length).FirstOrDefault());

//-----------------------------------------------------------------------------------------------

//string teste = "amem";
//Console.WriteLine(teste);
//teste = null;
//string? teste2 = null;
//Console.WriteLine(teste);

//-----------------------------------------------------------------------------------------------

//string testador = "outro";
//testador = "aaaaa";
//Console.WriteLine(testador ?? "bbbb");



