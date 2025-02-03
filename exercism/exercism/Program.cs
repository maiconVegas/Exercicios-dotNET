//-----------------------------------------------------------------------------------------------
using exercism.annalyns_infiltration;
using exercism.booking_up_for_beauty;
using exercism.elons_toys;
using exercism.EXERCICIOSExtensionMethods.accumulate;
using exercism.EXERCICIOSExtensionMethods.log_analysis;
using exercism.EXERCICIOSExtensionMethods.roman_numerals;
using exercism.EXERCICIOSStrings.acronym;
using exercism.EXERCICIOSStrings.bob;
using exercism.EXERCICIOSStrings.isogram;
using exercism.EXERCICIOSStrings.pangram;
using exercism.EXERCICIOSStrings.rotational_cipher;
using exercism.EXERCICIOSStrings.run_length_encoding;
using exercism.hello_world;
using exercism.interest_is_interesting;
using exercism.international_calling_connoisseur;
using exercism.lucians_luscious_lasagna;
using exercism.squeaky_clean;
using exercism.tracks_on_tracks_on_tracks;
using exercism.wizards_and_warriors;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
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

//-----------------------------------------------------------------------------------------------

//Console.WriteLine("");
//char a = 'A';
//char b = 'B';
//char sdd = Convert.ToChar(Convert.ToInt32(a) + Convert.ToInt32(b));
//string qualqeur = "aaaaa";
//string aa = (char)(qualqeur[0]+1) + "";
//Console.WriteLine(aa);

//Console.WriteLine(RotationalCipher.Rotate("Abc. aaa", 3));

//-----------------------------------------------------------------------------------------------
//string ass = "como";
//string pergunta = "Does this cryogenic chamber make me look fat?";
//Console.WriteLine(pergunta[pergunta.Length - 1]);
//Console.WriteLine(Bob.Response("Does this cryogenic chamber make me look fat?"));

//Console.WriteLine(Bob.Response("1, 2, 3"));

//-----------------------------------------------------------------------------------------------
//char qualquer = 'T';

//Console.WriteLine((char)(qualquer + 2));

//char[] caracteres = { 'D', 'B', 'c', 'A', 'd', 't'};
//Array.Sort(caracteres);
//string aaaaa = new string(caracteres.Distinct().ToArray());
//Console.WriteLine(aaaaa.ToLower());

//char inicio = 'A';
//int inic = inicio;
//Console.WriteLine((char)(inic + 25));

//string aaa = "abcdomopss";
//string resultado = new string(aaa.OrderBy(c => c).Distinct().ToArray());
//Console.WriteLine(resultado);

//Console.WriteLine((char)('A'+1));

//string frase1 = "The quick brown fox jumps over the lazy dog";
//string frase2 = "Hello World";

//Console.WriteLine(Pangram.IsPangram(frase1));
//Console.WriteLine(Pangram.IsPangram(frase2));

//Console.WriteLine(Isogram.IsIsogram("Alphabet"));

//string palavra = "six-year-old";
//Console.WriteLine(palavra.Where(char.IsLetter).Count());
//Console.WriteLine(palavra.Count());
//Console.WriteLine('a'.Equals('A'));

//-----------------------------------------------------------------------------------------------

//string frase3 = "amem deus it's ceu";
//Console.WriteLine(frase3.Split()[2].ToString()[0]);

//string gasdasd = "AB";
//gasdasd += "C";
//Console.WriteLine(gasdasd);

//-----------------------------------------------------------------------------------------------

//string teste = "Halley's - Comet";
//string teste2 = new string(teste.Where(char.IsPunctuation).ToArray());
//Console.WriteLine(teste2);
//Console.WriteLine(teste.Replace(teste2, " "));
//Console.WriteLine(Acronym.Abbreviate("The-Roa'd _Not_ Taken"));


//var qualquerrr = "The Road _Not_-Taken";
//var poooo = qualquerrr.Replace("_", " ").Replace("-", " ");
//Console.WriteLine(poooo);
//var oooooo = poooo.Split();
//Console.WriteLine(poooo);
//foreach (var item in oooooo)
//{
//    Console.WriteLine(item);
//}

//string texto = "The Road _Not_-Taken's -   Super";

//// Removendo pontuações e caracteres indesejados, mantendo apenas letras e espaços
//string textoLimpo = Regex.Replace(texto, @"[^\p{L}]", " ");

//// Separando as palavras em um array
//string[] palavras = textoLimpo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//// Exibindo as palavras
//foreach (string palavra in palavras)
//{
//    Console.WriteLine(palavra);
//}


//-----------------------------------------------------------------------------------------------
//Console.WriteLine(".....Teste.....");

//string[] palavras = { "Alo", "Ola", "Amor","LoA", "mora", "lOa" };
//string[] analisador = palavras.Select(x => x.ToLower()).ToArray();
//string encontre = "loa";
//string[] encontrado = analisador.Where(x => x != encontre).ToArray();
//string[] resultados = palavras
//    .Where(w => w.ToLower() != encontre.ToLower())
//    .Where(x => x.ToLower().OrderBy(l=>l) == encontre.ToLower().OrderBy(l=>l))
//    .ToArray();

//foreach (var item in resultados)
//{
//    Console.WriteLine(item);

//}
//foreach (var provavel in palavras)
//{
//    if (!provavel.ToLower().Equals(encontre))
//    {
//        //Console.WriteLine(provavel);
//        if (IsAnagram(provavel, encontre))
//        {
//            Console.WriteLine(provavel);
//        }
//    }
//}

//bool IsAnagram(string provavel, string match)
//{
//    provavel = string.Concat(provavel.ToLower().OrderBy(x=>x));
//    match = string.Concat(match.ToLower().OrderBy(x => x));
//    return provavel == match;
//}

//-----------------------------------------------------------------------------------------------
//Console.WriteLine(".....Teste.....");
//string teste = "aaaaaaaaccccccSSds3wsRSr";
////teste += "A";
////teste += "B";
////teste += "B";
////teste += "B";
////teste += "C";

//Console.WriteLine(teste[^1]);
//string gggg = "";
////gggg += $"{3* 'A'}";
//for (int i = 0; i < 3; i++)
//{
//    gggg += $"{'a'}";
//}

//Console.WriteLine(gggg);
//string resultado = string.Empty;
//int count = 0;
//char equaled = teste[0];
//for (int i = 0; i < teste.Length; i++)
//{
//    if (equaled.Equals(teste[i]))
//    {
//        count++;
//    }
//    else
//    {
//        resultado += $"{(count > 1? count : "")}{equaled}";
//        equaled = teste[i];
//        count = 1;
//    }
//}
//resultado += $"{(count > 1 ? count : "")}{equaled}";
//Console.WriteLine(resultado);
//Console.WriteLine(RunLengthEncoding.Encode("aaaaaaaaccccccSSds3wsRSr"));
//Console.WriteLine(RunLengthEncoding.Decode("A5SV15T4 6y"));

//----------------------------------ATE AGORA E MUITO SIMPLES ISSO MAS AO MESMO TEPO COMPLICADO-------------------------------------------------------------
//Console.WriteLine(".....Teste.....");

////Console.WriteLine(new String('A', 17));

//string teste = "F4b11R";
////string resultado2 = Regex.Replace(teste, @"(\D)", new string);
////string resultado = Regex.Replace(teste, @"(\d+)(\D)", m => new String(m.Groups[2].Value[0], Convert.ToInt32(m.Groups[1].Value)));
////Console.WriteLine(resultado);
//Console.WriteLine(String.Concat(teste.Reverse()));

//string log = "[INFO]: File Deleted.";
//string result = log.SubstringAfter(": ");
//Console.WriteLine(result); // Output: "File Deleted."

//var loge = "[ASDASDASD]: File Deleted.";
//Console.WriteLine(loge.SubstringBetween("[", "]")); // => returns "INFO"

//var logee = "[ERROR]: Missing ; on line 20.";
//Console.WriteLine(logee.Message()); // => returns "Missing ; on line 20."

//var logi = "[ERROR]: Missing ; on line 20.";
//Console.WriteLine(logi.LogLevel()); // => returns "ERROR"
//var testy = logi.Split();
//foreach (var item in testy)
//{
//    Console.WriteLine(item);
//}

//-----------------------------------------------------------------------------------------------
//Console.WriteLine(".....Teste.....");
//var lista = new List<string> { "hello", "world" }.Accumulate(x => x.ToUpper());
//foreach (var item in lista)
//{
//    Console.WriteLine(item);
//}

////-----------------------------------------------------------------------------------------------
//Console.WriteLine(".....Teste.....");

//(string, int, char) tupl;
//tupl = ("mensagem", 12, 'a');
//Console.WriteLine(tupl);

//Console.WriteLine("123".Equals("12"));

//string teste = "abcde";
//Console.WriteLine(teste.StartsWith("ab2"));

//-----------------------------------------------------------------------------------------------
/*Console.WriteLine(".....Teste.....");

IEnumerable<string> teste = Enumerable.Empty<string>();

teste = teste.Append("aaa");
teste = teste.Append("bbbb");
teste.ToList().ForEach(nome => Console.WriteLine(nome));

//var test2 = new List<(int, int)>() { (1, 2), (5, 3), (3, 1), (1, 2), (2, 4), (1, 6), (2, 3), (3, 4), (5, 6) };
//var test2 = new List<(int, int)>() { (1, 2), (2, 3), (3, 1), (2, 4), (2, 4) };
var test2 = new List<(int, int)>() { (1, 2), (2, 3), (3, 1), (4, 4) };


//test2.Add((1, 2));
//test2.Add((3, 1));
//test2.Add((2, 3));
var mimi = test2.OrderBy(x => x.Item1 + x.Item2);
Console.WriteLine(mimi.First());
Console.WriteLine("\n\n\n");
mimi.ToList().ForEach(nome => Console.WriteLine(nome));
Console.WriteLine("\n\n");
Console.WriteLine(mimi.Count());

Console.WriteLine("TESTEEEEEEEEEEEEEEEEEEEEEEEEE");
var primeiro = test2.OrderBy(x => x.Item1 + x.Item2).First();
test2.Remove(primeiro);
//test2.ToList().ForEach(nome => Console.WriteLine(nome));
//Console.WriteLine("TESTEEEEEEEEEEEEEEEEEEEEEEEEE");

var decrescente = test2.OrderByDescending(x => x.Item1 + x.Item2).ToList();
//Console.WriteLine(primeiro);
//decrescente.ForEach(nome => Console.WriteLine(nome));
//Console.WriteLine($"{primeiro.Item1} {primeiro.Item2}");
var primeiroA = primeiro.Item1;
var ladoB = primeiro.Item2;
int ladoA;
//foreach (var item in decrescente)
//{
//    //if (ladoB.Equals(item.Item1))
//    //{
//    //    ladoA = item.Item1;
//    //    ladoB = item.Item2;
//    //    //decrescente.Remove(item);
//    //}
//    //else if (ladoB.Equals(item.Item2))
//    //{
//    //    ladoA = item.Item2;
//    //    ladoB = item.Item1;
//    //    //decrescente.Remove(item);
//    //}
//    //else
//    //{
//    //    Console.WriteLine("NAO FAZ CORRENTE");
//    //}
//    if (decrescente.Any(x => item.Item1 == ladoB))
//    {
//        ladoA = item.Item1;
//        ladoB = item.Item2;
//        //decrescente.Remove(item);
//    }
//    else if (decrescente.Any(x => item.Item2 == ladoB))
//    {
//        ladoA = item.Item2;
//        ladoB = item.Item1;
//        //decrescente.Remove(item);
//    }
//    else
//    {
//        Console.WriteLine("NAO FAZ CORRENTE");
//    }
//}
//Console.WriteLine("FAZ CORRENTE");
int count = decrescente.Count();
while (count > 0)
{
    foreach (var item in decrescente)
    {
        if (ladoB.Equals(item.Item1))
        {
            ladoA = item.Item1;
            ladoB = item.Item2;
            decrescente.Remove(item);
            break;
            //decrescente.Remove(item);
        }
        else if (ladoB.Equals(item.Item2))
        {
            ladoA = item.Item2;
            ladoB = item.Item1;
            decrescente.Remove(item);
            break;
            //decrescente.Remove(item);
        }
    }
    count--;
}
Console.WriteLine(primeiroA==ladoB && decrescente.Count == 0);
//int count = decrescente.Count();
//for (int i = 0; i < count; i++)
//{
//    if (ladoB.Equals(decrescente[i].Item1))
//    {
//        ladoA = decrescente[i].Item1;
//        ladoB = decrescente[i].Item2;
//        //decrescente.Remove(decrescente[i]);
//    }
//    else if (ladoB.Equals(decrescente[i].Item2))
//    {
//        ladoA = decrescente[i].Item2;
//        ladoB = decrescente[i].Item1;
//        //decrescente.Remove(decrescente[i]);
//    }
//}
//Console.WriteLine(decrescente.Any(x => x.Item1 == ladoB));
decrescente.ForEach(nome => Console.WriteLine(nome));

*/
//-----------------------------------------------------------------------------------------------
Console.WriteLine(".....Teste.....");

int[,] matrix = new int[3, 5];
matrix[0, 0] = 0;
matrix[0, 1] = 1;
matrix[0, 2] = 2;
matrix[1, 0] = 3;
matrix[1, 1] = 4;
matrix[1, 2] = 5;
matrix[2, 0] = 6;
matrix[2, 1] = 7;
matrix[2, 2] = 8;
foreach (var item in Enumerable.Range(0, matrix.GetLength(0)))
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine(matrix[2,1]);


//-----------------------------------------------------------------------------------------------
Console.WriteLine(".....Teste.....");

Console.WriteLine(2.ToRoman());